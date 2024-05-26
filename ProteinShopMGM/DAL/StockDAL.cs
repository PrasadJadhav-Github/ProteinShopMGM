using Npgsql;
using ProteinShopMGM.Utility;
using System;

namespace ProteinShopMGM.DAL
{
    internal class StockDAL : IStockDAL
    {
        private readonly Connection _connection = new Connection();

        bool IStockDAL.Save(Guid productId, int quantity, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            _connection.Connect();

            try
            {
                string queryString = "SELECT id, quantity FROM public.\"Stock\" WHERE statusbit = :statusbit AND productid = :productid;";

                bool fExists = false;
                Guid stockId = Guid.Empty;
                int quantityEx = 0;
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":productid", productId);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.                        
                        if (reader.Read())
                        {
                            fExists = true;
                            stockId = reader.GetGuid(0);
                            quantityEx = reader.GetInt32(1);
                        }
                    }
                }

                if (fExists)
                {
                    queryString = "UPDATE public.\"Stock\" SET quantity = :quantity WHERE id = :id;";
                }
                else
                {
                    queryString = "INSERT INTO public.\"Stock\" (id, productid, quantity, createdon, updatedon, createdby, updatedby, statusbit) VALUES(:id, :productid, :quantity, :createdon, :updatedon, :createdby, :updatedby, :statusbit);";
                }

                _connection.Connect();
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    if (fExists)
                    {
                        command.Parameters.AddWithValue(":quantity", quantityEx + quantity);
                        command.Parameters.AddWithValue(":id", stockId);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(":id", Guid.NewGuid());
                        command.Parameters.AddWithValue(":productid", productId);
                        command.Parameters.AddWithValue(":quantity", quantity);
                        command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":createdby", userId);
                        command.Parameters.AddWithValue(":updatedby", userId);
                        command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    }

                    if (command.ExecuteNonQuery() > 0)
                    {
                        returnValue = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return returnValue;
        }
        
        int IStockDAL.GetStockQuantityByProductId(Guid productId)
        {
            int quantity = 0;
            _connection.Connect();

            string queryString = "SELECT quantity FROM public.\"Stock\" WHERE statusbit = :statusbit AND productid = :productid";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":productid", productId);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            quantity = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception) { }

            return quantity;
        }
    }
}
