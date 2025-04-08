using MyPointOfSale.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class DocumentDao : ConnectionToSQLServer
    {
        public IReadOnlyList<DocumentType> GetDocuments()
        {
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT [DocumentId], [DocumentName] FROM [MyPointOfSaleDB].[dbo].[Documents]";
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        List<DocumentType> documentTypes = new List<DocumentType>();
                        while (sqlDataReader.Read())
                        {
                            DocumentType documentType = new DocumentType
                            {
                                DocumentID = sqlDataReader.GetInt32(0),
                                DocumentName = sqlDataReader.GetString(1)
                            };
                            documentTypes.Add(documentType);
                        }
                        return documentTypes.AsReadOnly();
                    }
                }
            }
        }
    }
}
