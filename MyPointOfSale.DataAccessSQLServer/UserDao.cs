using MyPointOfSale.Common.Cache;
using MyPointOfSale.Models;
using System;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class UserDao : ConnectionToSQLServer
    {
        public void CrearUsuario(User user)
        {
            using (SqlConnection conn = ConnectionString)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [dbo].[Users] ([Username],[Password],[FirstName],[LastName],[Position],[Email],[DocumentId],[DocumentNumber]) VALUES('Username=@Username','Password=@Password','FirstName=@FirstName','LastName=@LastName','Position=@Position','Email=@Email','DocumentId=@DocumentId','DocumentNumber=@DocumentNumber');";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@DocumentNumber", user.DocumentNumber);
                    cmd.Parameters.AddWithValue("@DocumentTypeId", user.DocumentType.DocumentID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows) {
                            throw new Exception("No se pudo crear el usuario");
                        }
                    }
                }
            }
        }

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
