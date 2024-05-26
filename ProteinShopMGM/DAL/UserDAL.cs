using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;

namespace ProteinShopMGM.DAL
{
    /// <summary>
    /// This class implements the User related database operations.
    /// </summary>
    public class UserDAL : IUserDAL
    {
        private readonly Connection _connection = new Connection();

        User IUserDAL.GetByUsername(string username)
        {
            // Validate.
            if (!Common.Validation.IsNotEmpty(username))
            {
                return null;
            }

            _connection.Connect();

            User user = null;
            string queryString = "SELECT * FROM public.\"User\" WHERE username=:username";

            using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
            {
                command.Parameters.AddWithValue(":username", username);

                using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                {
                    if (reader.Read())
                    {
                        user = new User();
                        user.Id = reader.GetGuid(1);
                        user.Username = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.CreatedOn = reader.GetDateTime(4);
                        user.UpdatedOn = reader.GetDateTime(5);
                        user.StatusBit = reader.GetInt32(6);
                    }
                }
            }

            return user;
        }
    }
}
