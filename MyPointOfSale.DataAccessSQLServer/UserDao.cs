using MyPointOfSale.Common.Cache;
using MyPointOfSale.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class UserDao : ConnectionToSQLServer
    {
        public IEnumerable<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM Positions";
                    sqlCommand.CommandType = CommandType.Text;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            positions.Add(new Position
                            {
                                PositionId = sqlDataReader.GetInt32(0),
                                PositionName = sqlDataReader.GetString(1)
                            });
                        }
                    }
                }
            }

            return positions;
        }

        public IReadOnlyList<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection sqlConnection = ConnectionString)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        @"SELECT 
	                        [UserId],
	                        [dbo].[Positions].[PositionName],
	                        [FirstName],[LastName],
	                        [dbo].[Documents].[DocumentName],
	                        [DocumentNumber],[Email]
                        FROM [dbo].[Users]
                        LEFT JOIN [dbo].[Positions] ON [dbo].[Users].[PositionId] = [dbo].[Positions].[PositionId]
                        LEFT JOIN [dbo].[Documents] ON [dbo].[Users].[DocumentId] = [dbo].[Documents].[DocumentId];";
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User()
                            {
                                UserId = reader.GetInt32(0),
                                Position = new Position()
                                {
                                    PositionName = reader.GetString(1)
                                },
                                FirstName = reader.GetString(2),
                                LastName = reader.GetString(3),
                                DocumentType = new DocumentType()
                                {
                                    DocumentName = reader.GetString(4)
                                },
                                DocumentNumber = reader.GetString(5),
                                Email = reader.GetString(6)
                            });
                        }
                    }

                }
            }

            return users.AsReadOnly();
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
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLoginCache.UserId = reader.GetInt32(0);
                                UserLoginCache.FirstName = reader.GetString(3);
                                UserLoginCache.LastName = reader.GetString(4);
                                //UserLoginCache.Position = reader.GetString(6);
                                UserLoginCache.Email = reader.GetString(5);
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

        public void CrearUsuario(User user)
        {
            using (SqlConnection conn = ConnectionString)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [dbo].[Users] ([Username],[Password],[FirstName],[LastName],[Email],[DocumentId],[DocumentNumber],[PositionId]) VALUES(@Username,@Password,@FirstName,@LastName,@Email,@DocumentId,@DocumentNumber,@PositionId)";

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@DocumentId", user.DocumentType.DocumentID);
                    cmd.Parameters.AddWithValue("@DocumentNumber", user.DocumentNumber);
                    cmd.Parameters.AddWithValue("@PositionId", user.Position.PositionId);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarUsuario(User user)
        {
            using (SqlConnection conn = ConnectionString)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [dbo].[Users] SET [Username] = @Username, [Password] = @Password, [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [DocumentId] = @DocumentId, [DocumentNumber] = @DocumentNumber, [PositionId] = @PositionId WHERE UserId = @UserId";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@DocumentId", user.DocumentType.DocumentID);
                    cmd.Parameters.AddWithValue("@DocumentNumber", user.DocumentNumber);
                    cmd.Parameters.AddWithValue("@PositionId", user.Position.PositionId);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection conn = ConnectionString)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [dbo].[Users] WHERE UserId = @UserId";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@UserId", id);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

/*
 
                    cmd.Parameters.Add("@Password", SqlDbType.) = user.Password;
                    cmd.Parameters.Add("@FirstName",) =  user.FirstName;
                    cmd.Parameters.Add("@LastName", ) = user.LastName;
                    cmd.Parameters.Add("@Email",)= user.Email;
                    cmd.Parameters.Add("@DocumentId",)= user.DocumentType.DocumentID;
                    cmd.Parameters.Add("@DocumentNumber", )= user.DocumentNumber;
                    cmd.Parameters.Add("@PositionId", )= user.Position.PositionId;
 */