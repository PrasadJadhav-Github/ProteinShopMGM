using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal class PurchaseDetailsDAL : IPurchaseDetailsDAL
    {
        private readonly Connection _connection = new Connection();
        private readonly IProductDAL _productDAL = new ProductDAL();

        List<PurchaseDetails> IPurchaseDetailsDAL.GetAllByPurchaseId(Guid purchaseId)
        {
            // Initialize.
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"PurchaseDetails\" WHERE purchaseid = :id AND statusbit = :statusbit ORDER BY n;";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", purchaseId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            PurchaseDetails purchaseDetail = new PurchaseDetails();
                            purchaseDetail.Id = reader.GetGuid(1);
                            purchaseDetail.ProductId = reader.GetGuid(3);

                            // Retrieve the product details.
                            Product product = _productDAL.GetById(purchaseDetail.ProductId);
                            if (product != null)
                            {
                                purchaseDetail.ProductCode = product.Code;
                                purchaseDetail.ProductName = product.Name;
                            }

                            purchaseDetail.PackingDate = reader.GetDateTime(4);
                            purchaseDetail.ExpiryDate = reader.GetDateTime(5);
                            purchaseDetail.Quantity = reader.GetInt32(6);
                            purchaseDetail.Rate = (float)reader.GetDouble(7);
                            purchaseDetail.CreatedOn = reader.GetDateTime(8);
                            purchaseDetail.UpdatedOn = reader.GetDateTime(9);
                            purchaseDetail.CreatedBy = reader.GetGuid(10);
                            purchaseDetail.UpdatedBy = reader.GetGuid(11);
                            purchaseDetail.StatusBit = reader.GetInt32(12);
                            purchaseDetail.MRP = (float)reader.GetDouble(13);

                            purchaseDetails.Add(purchaseDetail);
                        }
                    }
                }
            }
            catch (Exception) { }

            return purchaseDetails;
        }

        bool IPurchaseDetailsDAL.Save(Guid purchaseId, Guid productId, DateTime packingDate, DateTime expiryDate, int quantity, float rate, float mrp, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            _connection.Connect();

            string queryString = "INSERT INTO public.\"PurchaseDetails\" (id, purchaseid, productid, packingdate, expirydate, quantity, rate, createdon, updatedon, createdby, updatedby, statusbit, mrp) VALUES(:id, :purchaseid, :productid, :packingdate, :expirydate, :quantity, :rate, :createdon, :updatedon, :createdby, :updatedby, :statusbit, :mrp);";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", Guid.NewGuid());
                    command.Parameters.AddWithValue(":purchaseid", purchaseId);
                    command.Parameters.AddWithValue(":productid", productId);
                    command.Parameters.AddWithValue(":packingdate", packingDate);
                    command.Parameters.AddWithValue(":expirydate", expiryDate);
                    command.Parameters.AddWithValue(":quantity", quantity);
                    command.Parameters.AddWithValue(":rate", rate);
                    command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":createdby", userId);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":mrp", mrp);

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

        float IPurchaseDetailsDAL.GetMRPByProductId(Guid productId)
        {
            float mrp = 0;
            _connection.Connect();

            string queryString = "SELECT mrp FROM public.\"PurchaseDetails\" WHERE statusbit = :statusbit AND productid = :productid AND expirydate >= :todaydate ORDER BY createdon DESC LIMIT 1";
            
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":productid", productId);
                    command.Parameters.AddWithValue(":todaydate", DateTime.Now.Date);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            mrp = (float)reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception) { }

            return mrp;
        }
    }
}
