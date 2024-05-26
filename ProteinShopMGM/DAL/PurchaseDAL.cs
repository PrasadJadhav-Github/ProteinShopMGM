using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM.DAL
{
    internal class PurchaseDAL : IPurchaseDAL
    {
        private readonly Connection _connection = new Connection();
        private readonly ISupplierDAL _supplierDAL = new SupplierDAL();

        List<Purchase> IPurchaseDAL.GetAll(int? purchaseStatus, DateTime? fromDate, DateTime? toDate)
        {
            // Initialize.
            List<Purchase> purchases = new List<Purchase>();
            _connection.Connect();

            // Set conditions for query.
            string conditionString = string.Empty;
            if (purchaseStatus != null && PURCHASESTATUS.IsMember((int)purchaseStatus))
            {
                conditionString = "purchasestatus = " + purchaseStatus;
            }
            if (fromDate != null && toDate != null && fromDate <= toDate)
            {
                if (Common.Validation.IsNotEmpty(conditionString))
                {
                    conditionString += " AND ";
                }

                conditionString += "purchasedate >= '" + fromDate + "' AND purchasedate <= '" + toDate + "'";
            }
            if (Common.Validation.IsNotEmpty(conditionString))
            {
                conditionString += " AND ";
            }

            string queryString = "SELECT * FROM public.\"Purchase\" WHERE " + conditionString + "statusbit = " + STATUSCODES.STATUS_ACTIVE + " ORDER BY purchasedate DESC;";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            Purchase purchase = new Purchase();
                            purchase.Id = reader.GetGuid(1);
                            purchase.SupplierId = reader.GetGuid(2);

                            // Retrieve the supplier details.
                            Supplier supplier = _supplierDAL.GetById(purchase.SupplierId);
                            if (supplier != null)
                            {
                                purchase.SupplierName = supplier.Name;
                            }

                            purchase.PurchaseDate = reader.GetDateTime(3);
                            purchase.CreatedOn = reader.GetDateTime(4);
                            purchase.UpdatedOn = reader.GetDateTime(5);
                            purchase.CreatedBy = reader.GetGuid(6);
                            purchase.UpdatedBy = reader.GetGuid(7);
                            purchase.StatusBit = reader.GetInt32(8);
                            purchase.PurchaseStatus = reader.GetInt32(9);
                            purchase.PurchaseStatusText = PURCHASESTATUS.GetText(purchase.PurchaseStatus);

                            purchases.Add(purchase);
                        }
                    }
                }
            }
            catch (Exception) { }

            return purchases;
        }

        Purchase IPurchaseDAL.GetPurchaseById(int purchaseId)
        {
            Purchase purchase = new Purchase();
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Purchase\" WHERE id = @id";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            purchase = new Purchase();
                            purchase.Id = reader.GetGuid(1);
                            purchase.SupplierId = reader.GetGuid(2);
                            purchase.PurchaseDate = reader.GetDateTime(3);
                            purchase.CreatedOn = reader.GetDateTime(4);
                            purchase.UpdatedOn = reader.GetDateTime(5);
                            purchase.CreatedBy = reader.GetGuid(6);
                            purchase.UpdatedBy = reader.GetGuid(7);
                            purchase.StatusBit = reader.GetInt32(8);
                            purchase.PurchaseStatus = reader.GetInt32(9);
                            purchase.PurchaseStatusText = PURCHASESTATUS.GetText(purchase.PurchaseStatus);
                        }
                    }
                }
            }
            catch (Exception) { }

            return purchase;
        }

        bool IPurchaseDAL.Save(Guid supplierId, DateTime purchaseDate, int purchaseStatus, Guid userId, out Guid purchaseId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            purchaseId = Guid.Empty;
            errorMessage = string.Empty;

            _connection.Connect();

            string queryString = "INSERT INTO public.\"Purchase\" (id, supplierid, purchasedate, createdon, updatedon, createdby, updatedby, statusbit, purchasestatus) VALUES(:id, :supplierid, :purchasedate, :createdon, :updatedon, :createdby, :updatedby, :statusbit, :purchasestatus);";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    purchaseId = Guid.NewGuid();
                    command.Parameters.AddWithValue(":id", purchaseId);
                    command.Parameters.AddWithValue(":supplierid", supplierId);
                    command.Parameters.AddWithValue(":purchasedate", purchaseDate);
                    command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":createdby", userId);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":purchasestatus", Common.PURCHASESTATUS.INPROCESS);

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

        bool IPurchaseDAL.UpdateStatus(Guid purchaseId, int purchaseStatus, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            // Validate input.
            if (!PURCHASESTATUS.IsMember(purchaseStatus))
            {
                return returnValue;
            }

            _connection.Connect();

            string queryString = "UPDATE public.\"Purchase\" SET purchasestatus = :purchasestatus, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", purchaseId);
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":purchasestatus", purchaseStatus);

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
