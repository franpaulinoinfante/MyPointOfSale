using MyPointOfSale.Common.Cache;
using MyPointOfSale.Models;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class UserDao : ConnectionToSQLServer
    {
        public bool Login(User user)
        {
            using (SqlConnection connection = ConnectionString)
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLoginCache.UserId = reader.GetInt32(0);
                                UserLoginCache.FirstName = reader.GetString(3);
                                UserLoginCache.LastName = reader.GetString(4);
                                UserLoginCache.Position = reader.GetString(5);
                                UserLoginCache.Email = reader.GetString(6);
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

    }
}
