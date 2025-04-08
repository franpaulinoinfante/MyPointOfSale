using System.Configuration;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class ConnectionToSQLServer
    {
        private readonly string _connectionString;

        public ConnectionToSQLServer()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        protected SqlConnection ConnectionString => new SqlConnection(_connectionString);
    }
}
