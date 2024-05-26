using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM.DAL
{
    internal class CustomerDAL : ICustomerDAL
    {
        private readonly Connection _connection = new Connection();

        List<Customer> ICustomerDAL.GetAll(string nameFilter)
        {
            // Initialize.
            List<Customer> customers = new List<Customer>();
            _connection.Connect();

            string queryString = Common.Validation.IsNotEmpty(nameFilter) ? 
                "SELECT * FROM public.\"Customer\" WHERE name LIKE '%" + nameFilter +  "%' AND statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;" : 
                "SELECT * FROM public.\"Customer\" WHERE statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;";
            
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.Id = reader.GetGuid(1);
                            customer.Name = reader.GetString(2);
                            customer.Contact = reader.GetString(3);
                            if (!reader.IsDBNull(4))
                            {
                                customer.Address = reader.GetString(4);
                            }
                            customer.CustomerType = reader.GetInt16(5);
                            customer.CreatedOn = reader.GetDateTime(6);
                            customer.UpdatedOn = reader.GetDateTime(7);
                            customer.StatusBit = reader.GetInt32(8);
                            if (!reader.IsDBNull(9))
                            {
                                customer.CreatedBy = reader.GetGuid(9);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                customer.UpdatedBy = reader.GetGuid(10);
                            }
                            
                            customer.CustomerTypeText = CUSTOMERTYPES.GetText(customer.CustomerType);

                            customers.Add(customer);
                        }
                    }
                }
            }
            catch (Exception) { }

            return customers;
        }

        Customer ICustomerDAL.GetById(Guid customerId)
        {
            // Initialize.
            Customer customer = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Customer\" WHERE id = " + customerId;

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            customer = new Customer();
                            customer.Id = reader.GetGuid(1);
                            customer.Name = reader.GetString(2);
                            customer.Contact = reader.GetString(3);
                            if (!reader.IsDBNull(4))
                            {
                                customer.Address = reader.GetString(4);
                            }
                            customer.CustomerType = reader.GetInt32(5);
                            customer.CreatedOn = reader.GetDateTime(6);
                            customer.UpdatedOn = reader.GetDateTime(7);
                            customer.StatusBit = reader.GetInt32(8);
                            if (!reader.IsDBNull(9))
                            {
                                customer.CreatedBy = reader.GetGuid(9);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                customer.UpdatedBy = reader.GetGuid(10);
                            }
                            customer.CustomerTypeText = CUSTOMERTYPES.GetText(customer.CustomerType);
                        }
                    }
                }
            }
            catch { }

            return customer;
        }

        Customer ICustomerDAL.GetByName(string customerName)
        {
            // Initialize.
            Customer customer = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Customer\" WHERE UPPER(name) = :name AND statusbit = :statusbit";
            
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue("name", customerName.ToUpper());
                    command.Parameters.AddWithValue("statusbit", Common.STATUSCODES.STATUS_ACTIVE);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            customer = new Customer();
                            customer.Id = reader.GetGuid(1);
                            customer.Name = reader.GetString(2);
                            customer.Contact = reader.GetString(3);
                            if (!reader.IsDBNull(4))
                            {
                                customer.Address = reader.GetString(4);
                            }
                            customer.CustomerType = reader.GetInt32(5);
                            customer.CreatedOn = reader.GetDateTime(6);
                            customer.UpdatedOn = reader.GetDateTime(7);
                            customer.StatusBit = reader.GetInt32(8);
                            if (!reader.IsDBNull(9))
                            {
                                customer.CreatedBy = reader.GetGuid(9);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                customer.UpdatedBy = reader.GetGuid(10);
                            }
                            customer.CustomerTypeText = CUSTOMERTYPES.GetText(customer.CustomerType);
                        }
                    }
                }
            }
            catch { }

            return customer;
        }

        bool ICustomerDAL.Save(Guid? customerId, string name, string contact, string address, int customerType, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            // Validate.
            if (!(Common.Validation.IsNotEmpty(name) && 
                Common.Validation.IsNotEmpty(contact) && 
                Common.Validation.IsNotEmpty(address) && 
                customerType > 0))
            {
                return returnValue;
            }
            
            _connection.Connect();

            string queryString;
            if (customerId == null)
            {
                queryString = "INSERT INTO public.\"Customer\" (id, name, contact, address, customertype, createdon, updatedon, statusbit, createdby, updatedby) VALUES(:id, :name, :contact, :address, :customertype, :createdon, :updatedon, :statusbit, :createdby, :updatedby);";
            }
            else
            {
                queryString = "UPDATE public.\"Customer\" SET contact = :contact, address = :address, customertype =:customertype, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";
            }
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", customerId == null ? Guid.NewGuid() : customerId);
                    command.Parameters.AddWithValue(":name", name);
                    command.Parameters.AddWithValue(":contact", contact);
                    command.Parameters.AddWithValue(":address", address);
                    command.Parameters.AddWithValue(":customertype", customerType);                    
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);                    
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    if (customerId == null)
                    {
                        command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":createdby", userId);
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

        bool ICustomerDAL.Delete(Guid customerId, Guid userId, out string errorMessage)
        {
            bool returnValue = false;
            errorMessage = string.Empty;
            _connection.Connect();

            string queryString = "UPDATE public.\"Customer\" SET statusbit = :statusbit, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
            {
                command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_DELETED);
                command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                command.Parameters.AddWithValue(":updatedby", userId);
                command.Parameters.AddWithValue(":id", customerId);

                if (command.ExecuteNonQuery() > 0)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }
    }
}
