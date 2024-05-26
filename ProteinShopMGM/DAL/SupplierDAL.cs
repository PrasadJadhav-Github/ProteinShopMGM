using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM.DAL
{
    internal class SupplierDAL : ISupplierDAL
    {
        private readonly Connection _connection = new Connection();

        List<Supplier> ISupplierDAL.GetAll(string nameFilter)
        {
            // Initialize.
            List<Supplier> suppliers = new List<Supplier>();
            _connection.Connect();

            string queryString = Common.Validation.IsNotEmpty(nameFilter) ?
                "SELECT * FROM public.\"Supplier\" WHERE name LIKE '%" + nameFilter + "%' AND " + "statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;" :
                "SELECT * FROM public.\"Supplier\" WHERE statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;";
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier();
                            supplier.Id = reader.GetGuid(1);
                            supplier.Name = reader.GetString(2);
                            supplier.Address = reader.GetString(3);
                            supplier.CreatedOn = reader.GetDateTime(4);
                            supplier.UpdatedOn = reader.GetDateTime(5);
                            supplier.StatusBit = reader.GetInt32(6);
                            supplier.CreatedBy = reader.GetGuid(7);
                            supplier.UpdatedBy = reader.GetGuid(8);
                            supplier.Contact = reader.GetString(9);
                            supplier.SupplierType = reader.GetInt16(10);
                            supplier.SupplierTypeText = SUPPLIERTYPES.GetText(supplier.SupplierType);

                            suppliers.Add(supplier);
                        }
                    }
                }
            }
            catch { }

            return suppliers;
        }

        Supplier ISupplierDAL.GetById(Guid supplierId)
        {
            // Initialize.
            Supplier supplier = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Supplier\" WHERE id = :id";
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", supplierId);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            supplier = new Supplier();
                            supplier.Id = reader.GetGuid(1);
                            supplier.Name = reader.GetString(2);
                            supplier.Address = reader.GetString(3);
                            supplier.CreatedOn = reader.GetDateTime(4);
                            supplier.UpdatedOn = reader.GetDateTime(5);
                            supplier.StatusBit = reader.GetInt32(6);
                            supplier.CreatedBy = reader.GetGuid(7);
                            supplier.UpdatedBy = reader.GetGuid(8);
                            supplier.Contact = reader.GetString(9);
                            supplier.SupplierType = reader.GetInt32(10);
                            supplier.SupplierTypeText = SUPPLIERTYPES.GetText(supplier.SupplierType);
                        }
                    }
                }
            }
            catch { }

            return supplier;
        }

        Supplier ISupplierDAL.GetByName(string supplierName)
        {
            // Initialize.
            Supplier supplier = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Supplier\" WHERE UPPER(name) = :name AND statusbit = :statusbit";
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":name", supplierName.ToUpper());
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            supplier = new Supplier();
                            supplier.Id = reader.GetGuid(1);
                            supplier.Name = reader.GetString(2);
                            supplier.Address = reader.GetString(3);
                            supplier.CreatedOn = reader.GetDateTime(4);
                            supplier.UpdatedOn = reader.GetDateTime(5);
                            supplier.StatusBit = reader.GetInt32(6);
                            supplier.CreatedBy = reader.GetGuid(7);
                            supplier.UpdatedBy = reader.GetGuid(8);
                            supplier.Contact = reader.GetString(9);
                            supplier.SupplierType = reader.GetInt32(10);
                            supplier.SupplierTypeText = SUPPLIERTYPES.GetText(supplier.SupplierType);
                        }
                    }
                }
            }
            catch { }

            return supplier;
        }

        bool ISupplierDAL.Save(Guid? supplierId, string name, string address, string contact, int supplierType, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            // Validate.
            if (!Common.Validation.IsNotEmpty(name) || 
                !Common.Validation.IsNotEmpty(address) || 
                !Common.Validation.IsNotEmpty(contact) || 
                supplierType <= 0)
            {
                return returnValue;
            }

            _connection.Connect();

            string queryString;
            if (supplierId == null)
            {
                queryString = "INSERT INTO public.\"Supplier\" (id, name, address, createdon, updatedon, createdby, updatedby, statusbit, contact, suppliertype) VALUES(:id, :name, :address, :createdon, :updatedon, :createdby, :updatedby, :statusbit, :contact,:suppliertype);";
            }
            else
            {
                queryString = "UPDATE public.\"Supplier\" SET address = :address, updatedon = :updatedon, updatedby = :updatedby, contact = :contact, suppliertype = :suppliertype WHERE id = :id;";
            }
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", supplierId == null ? Guid.NewGuid() : supplierId);
                    command.Parameters.AddWithValue(":name", name);
                    command.Parameters.AddWithValue(":address", address);
                    if (supplierId == null)
                    {
                        command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":createdby", userId);
                    }
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":contact", contact);
                    command.Parameters.AddWithValue(":suppliertype", supplierType);

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

        bool ISupplierDAL.Delete(Guid supplierId, Guid userId, out string errorMessage)
        {
            bool returnValue = false;
            errorMessage = string.Empty;
            _connection.Connect();

            string queryString = "UPDATE public.\"Supplier\" SET statusbit = :statusbit, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
            {
                command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_DELETED);
                command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                command.Parameters.AddWithValue(":updatedby", userId);
                command.Parameters.AddWithValue(":id", supplierId);

                if (command.ExecuteNonQuery() > 0)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }
    }
}


