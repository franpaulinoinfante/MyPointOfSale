using MyPointOfSale.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class ProductDao : ConnectionToSQLServer
    {
        public IReadOnlyList<Category> Category()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT [CategoryId],[CategoryName] FROM [dbo].[Categories]";
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Category category = new Category();
                        category.Id = sqlDataReader.GetInt32(0);
                        category.CategoryName = sqlDataReader.GetString(1);
                        categories.Add(category);
                    }

                    sqlConnection.Close();
                }
            }

            return categories;
        }

        public IReadOnlyList<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = ConnectionString)
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        @"SELECT [ProductId] ,[Categories].[CategoryName], [Description], [Price], [ITBIS]
                            FROM [dbo].[Products]
                            LEFT JOIN [dbo].[Categories] ON [dbo].[Products].CategoryId = [dbo].[Categories].CategoryId";
                    command.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.ProductId = reader.GetInt32(0);
                            product.Category = new Category()
                            {
                                CategoryName = reader.GetString(1)
                            };
                            product.Description = reader.GetString(2);
                            product.Price = reader.GetDecimal(3);
                            product.ITBIS = reader.GetDecimal(4);
                            products.Add(product);
                            //products.Add(new Product()
                            //{
                            //    Id = reader.GetInt32(0),
                            //    Category = new ProductCategory()
                            //    {
                            //        Category = reader.GetString(1)
                            //    },
                            //    Description = reader.GetString(2),
                            //    Price = reader.GetDecimal(3),
                            //    ITBIS = reader.GetFloat(4)
                            //});
                        }
                    }
                }
            }

            return products;
        }
    }
}
