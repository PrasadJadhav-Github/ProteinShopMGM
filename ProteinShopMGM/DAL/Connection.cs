using Npgsql;
using System.Configuration;

namespace ProteinShopMGM.DAL
{
    /// <summary>
    /// This class handles the database connection. 
    /// So whenever we need a database connection, we need to instantiate this class and call respective methods.
    /// </summary>
    internal class Connection
    {
        private readonly NpgsqlConnection _connection;

        /// <summary>
        /// This constructor initializes the connection.
        /// </summary>
        public Connection()
        {
            // Set the database connection.
            string connectionString = ConfigurationManager.ConnectionStrings["ProteinShopMGMConnString"].ConnectionString; 
            _connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection Get()
        {
            return _connection;
        }

        /// <summary>
        /// This method opens the database connection.
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            try
            {
                _connection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// This method closes the database connection.
        /// </summary>
        /// <returns></returns>
        public bool Close()
        {
            try
            {
                _connection.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
