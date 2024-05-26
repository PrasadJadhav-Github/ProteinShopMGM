using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;

namespace ProteinShopMGM.DAL
{
    internal class SellDAL : ISellDAL
    {
        private readonly Connection _connection = new Connection();
        private readonly ICustomerDAL _customerDAL = new CustomerDAL();

        bool ISellDAL.Save(Guid customerId, DateTime billDate, float totalAmount, float discount, float netAmount, Guid userId, out Guid sellId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            sellId = Guid.Empty;
            errorMessage = string.Empty;

            _connection.Connect();

            string queryString = "INSERT INTO public.\"Sell\" (id, customerid, billdate, totalamount, discount, finalamount, createdon, updatedon, createdby, updatedby, statusbit) VALUES(:id, :customerid, :billdate, :totalamount, :discount, :finalamount, :createdon, :updatedon, :createdby, :updatedby, :statusbit);";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    sellId = Guid.NewGuid();
                    command.Parameters.AddWithValue(":id", sellId);
                    command.Parameters.AddWithValue(":customerid", customerId);
                    command.Parameters.AddWithValue(":billdate", billDate);
                    command.Parameters.AddWithValue(":totalamount", totalAmount);
                    command.Parameters.AddWithValue(":discount", discount);
                    command.Parameters.AddWithValue(":finalamount", netAmount);
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

        double ISellDAL.GetTotalSell(DateTime fromDate, DateTime toDate)
        {
            double totalSell = 0;
            _connection.Connect();

            string queryString = "SELECT SUM(finalamount) FROM public.\"Sell\" WHERE statusbit = :statusbit AND billdate >= :fromdate AND billdate <= :todate";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {                    
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":fromdate", fromDate);
                    command.Parameters.AddWithValue(":todate", toDate);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            totalSell = reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception) { }

            return totalSell;
        }
    }
}
