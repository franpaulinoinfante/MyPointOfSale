using MyPointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class InvoiceDao : ConnectionToSQLServer
    {
        public Client GetClientBy(string document)
        {
            Client client = new Client();
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"SELECT 
                        	[ClientId], 
                        	[FirstName], 
                        	[LastName], 
                        	[dbo].[Clients].[DocumentId],
	                        [DocumentName],
                        	[DucmentNumber] 
                        FROM [dbo].[Clients] 
                        RIGHT JOIN [dbo].[Documents] ON [dbo].[Clients].[DocumentId] = [dbo].[Documents].[DocumentId]
                        WHERE [DucmentNumber] = @Document";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Document", document);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        client = new Client()
                        {
                            ClientId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            DocumentType = new DocumentType()
                            {
                                DocumentID = reader.GetInt32(3),
                                DocumentName = reader.GetString(4)
                            },
                            DocumentNumber = reader.GetString(5)

                        };
                    }
                }
            }

            return client;
        }

        public IReadOnlyList<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"SELECT 
                        	[ClientId], 
                        	[FirstName], 
                        	[LastName], 
                        	[dbo].[Clients].[DocumentId],
	                        [DocumentName],
                        	[DucmentNumber] 
                        FROM [dbo].[Clients] 
                        RIGHT JOIN [dbo].[Documents] ON [dbo].[Clients].[DocumentId] = [dbo].[Documents].[DocumentId]";

                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                ClientId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                DocumentType = new DocumentType()
                                {
                                    DocumentID = reader.GetInt32(3),
                                    DocumentName = reader.GetString(4)
                                },
                                DocumentNumber = reader.GetString(5)
                            });
                        }
                    }
                }
            }

            return clients;
        }

        public (int, string) GetNCF()
        {
            (int id, string sequence) results = default;
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"SELECT TOP 1 
                            NCFId,
                            Serial + TypeOfReceipt + RIGHT('00000000' + CAST(Sequence AS VARCHAR), 8) AS NextNCF
                        FROM NCFs
                        WHERE isActive = 1
                        ORDER BY Sequence;";
                    sqlCommand.CommandType = CommandType.Text;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            results.id = reader.GetInt32(0);
                            results.sequence = reader.GetString(1);
                        }
                    }
                }
            }

            return results;
        }

        public IReadOnlyList<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"SELECT [ProductId]
                            ,[Description]
                            ,[Price]
                            ,[ITBIS]
                            ,[Products].[CategoryId]
                            ,[Categories].[CategoryName]
                        FROM [MyPointOfSaleDB].[dbo].[Products]
                        LEFT JOIN [dbo].[Categories] 
                        ON [dbo].[Products].[CategoryId] = [dbo].[Categories].[CategoryId];";

                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductId = reader.GetInt32(0),
                                Description = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                ITBIS = reader.GetDecimal(3),
                                Category = new Category()
                                {
                                    Id = reader.GetInt32(4),
                                    CategoryName = reader.GetString(5)
                                }
                            });
                        }
                    }
                }
            }

            return products;
        }

        public void ProcessInvoice(Invoice invoice)
        {
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"INSERT INTO [dbo].[Invoices]
                            ([CreateAt], [ClientId], [Total], [ITBIS], [UserId], [NCF])
                            VALUES (@CreateAt, @ClientId, @Total, @ITBIS, @UserId, @NCF);
                            SELECT SCOPE_IDENTITY() AS NewClientId;";
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.AddWithValue("@CreateAt", DateTime.UtcNow);
                    sqlCommand.Parameters.AddWithValue("@ClientId", invoice.Client.ClientId);
                    sqlCommand.Parameters.AddWithValue("@Total", invoice.GetTotal);
                    sqlCommand.Parameters.AddWithValue("@ITBIS", invoice.GetITBIS);
                    sqlCommand.Parameters.AddWithValue("@UserId", invoice.User.UserId);

                    if (invoice.NCFID > 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@NCF", invoice.NCFID);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@NCF", DBNull.Value);
                    }

                    int newInvoiceId = sqlCommand.ExecuteNonQuery();
                    if (newInvoiceId > 0)
                    {
                        int lineRowsAffected = CreateInvoiceLines(invoice.InvoiceLines, newInvoiceId, sqlConnection);
                    }

                    if (invoice.NCFID > 0)
                    {
                        SetNfcNotActive(invoice.NCF, sqlConnection);
                    }
                }
            }
        }

        private void SetNfcNotActive(string nCF, SqlConnection sqlConnection)
        {
            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = @"UPDATE [dbo].[NCFs]
                                              SET [IsActive] = @IsActive
                                            WHERE Sequence = @Sequence";
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.AddWithValue("@Sequence", nCF.Substring(3));
                sqlCommand.Parameters.AddWithValue("@IsActive", 0);

                sqlCommand.ExecuteNonQuery();
            }
        }

        private int CreateInvoiceLines(List<InvoiceLine> invoiceLines, int newInvoiceId, SqlConnection sqlConnection)
        {
            int rowAffected = default;
            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = @"INSERT INTO [dbo].[InvoiceLines] ([InvoiceId], [ProductId], [Description], [Price], [Cantidad], [ITBIS])
                                            VALUES(@InvoiceId, @ProductId, @Description, @Price, @Cantidad, @ITBIS)";
                sqlCommand.CommandType = CommandType.Text;

                foreach (InvoiceLine invoiceLine in invoiceLines)
                {
                    sqlCommand.Parameters.AddWithValue("@InvoiceId", newInvoiceId);
                    sqlCommand.Parameters.AddWithValue("@ProductId", invoiceLine.ProductId);
                    sqlCommand.Parameters.AddWithValue("@Description", invoiceLine.Description);
                    sqlCommand.Parameters.AddWithValue("@Price", invoiceLine.Price);
                    sqlCommand.Parameters.AddWithValue("@Cantidad", invoiceLine.Quantity);
                    sqlCommand.Parameters.AddWithValue("@ITBIS", invoiceLine.ITBIS);

                    rowAffected += sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                }
            }

            return rowAffected;
        }

        public IReadOnlyList<decimal> GetSales()
        {
            List<decimal> invoices = new List<decimal>();
            using (SqlConnection sqlConnction = ConnectionString)
            {
                sqlConnction.Open();
                using (SqlCommand sqlCommand = sqlConnction.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT [Total] FROM [MyPointOfSaleDB].[dbo].[Invoices]";
                    sqlCommand.CommandType = CommandType.Text;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            invoices.Add(sqlDataReader.GetDecimal(0));
                        }
                    }
                }
            }

            return invoices;
        }

        public int CountNCFs()
        {
            int total = default;

            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = @"SELECT COUNT(IsActive)
                                                FROM [MyPointOfSaleDB].[dbo].[NCFs]
                                                WHERE IsActive = 0;";
                    sqlCommand.CommandType = CommandType.Text;
                    total = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
            }

            return total;
        }
    }
}