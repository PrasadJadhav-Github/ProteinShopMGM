using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Data.Common;

namespace ProteinShopMGM.DAL
{
    internal class SellDetailsDAL : ISellDetailsDAL
    {
        private readonly Connection _connection = new Connection();
        private readonly IProductDAL _productDAL = new ProductDAL();

        bool ISellDetailsDAL.Save(Guid sellId, Guid productId, int quantity, float price, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            _connection.Connect();

            string queryString = "INSERT INTO public.\"SellDetails\" (id, sellid, productid, quantity, price, createdon, updatedon, createdby, updatedby, statusbit) VALUES(:id, :sellid, :productid, :quantity, :price, :createdon, :updatedon, :createdby, :updatedby, :statusbit);";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", Guid.NewGuid());
                    command.Parameters.AddWithValue(":sellid", sellId);
                    command.Parameters.AddWithValue(":productid", productId);
                    command.Parameters.AddWithValue(":quantity", quantity);
                    command.Parameters.AddWithValue(":price", price);
                    command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":createdby", userId);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);

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
    }
}
