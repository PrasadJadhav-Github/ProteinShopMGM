using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    /// <summary>
    /// This class implements the Product Category related database operations.
    /// </summary>
    internal class ProductCategoryDAL : IProductCategoryDAL
    {
        private readonly Connection _connection = new Connection();

        List<ProductCategory> IProductCategoryDAL.GetAll(string nameFilter)
        {
            // Initialize.
            List<ProductCategory> productCategories = new List<ProductCategory>();
            _connection.Connect();

            string queryString = Common.Validation.IsNotEmpty(nameFilter) ? 
                "SELECT * FROM public.\"ProductCategory\" WHERE name LIKE '%" + nameFilter + "%' AND statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;" : 
                "SELECT * FROM public.\"ProductCategory\" WHERE statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            ProductCategory category = new ProductCategory();
                            category.Id = reader.GetGuid(1);
                            category.Name = reader.GetString(2);
                            category.Description = reader.GetString(3);
                            category.CreatedOn = reader.GetDateTime(4);
                            category.UpdatedOn = reader.GetDateTime(5);
                            category.StatusBit = reader.GetInt32(6);
                            if (!reader.IsDBNull(7))
                            {
                                category.CreatedBy = reader.GetGuid(7);
                            }
                            if (!reader.IsDBNull(8))
                            {
                                category.UpdatedBy = reader.GetGuid(8);
                            }
                            if (!reader.IsDBNull(9))
                            {
                                category.SubCategoryName = reader.GetString(9);
                            }

                            productCategories.Add(category);
                        }
                    }
                }
            }
            catch { }

            return productCategories;
        }

        ProductCategory IProductCategoryDAL.GetById(Guid productCategoryId)
        {
            // Initialize.
            ProductCategory productCategory = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"ProductCategory\" WHERE id = :id";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue("id", productCategoryId);
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            productCategory = new ProductCategory();
                            productCategory.Id = reader.GetGuid(1);
                            productCategory.Name = reader.GetString(2);
                            productCategory.Description = reader.GetString(3);
                            productCategory.CreatedOn = reader.GetDateTime(4);
                            productCategory.UpdatedOn = reader.GetDateTime(5);
                            productCategory.StatusBit = reader.GetInt32(6);
                            if (!reader.IsDBNull(7))
                            {
                                productCategory.CreatedBy = reader.GetGuid(7);
                            }
                            if (!reader.IsDBNull(8)) 
                            {
                                productCategory.UpdatedBy = reader.GetGuid(8);
                            }
                            if (!reader.IsDBNull(9))
                            {
                                productCategory.SubCategoryName = reader.GetString(9);
                            }
                        }
                    }
                }
            }
            catch { }

            return productCategory;
        }

        ProductCategory IProductCategoryDAL.GetByName(string productCategoryName, string subCategoryName)
        {
            // Initialize.
            ProductCategory productCategory = null;
            _connection.Connect();

            string queryString = null;
            if (subCategoryName != null && subCategoryName.Trim() != string.Empty)
            {
                queryString = "SELECT * FROM public.\"ProductCategory\" WHERE UPPER(name) = :name AND UPPER(subcategoryname) = :subcategoryname AND statusbit = :statusbit;";
            }
            else
            {
                queryString = "SELECT * FROM public.\"ProductCategory\" WHERE UPPER(name) = :name AND statusbit = :statusbit;";
            }

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue("name", productCategoryName.ToUpper());
                    command.Parameters.AddWithValue("subcategoryname", subCategoryName.ToUpper());
                    command.Parameters.AddWithValue("statusbit", Common.STATUSCODES.STATUS_ACTIVE);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            productCategory = new ProductCategory();
                            productCategory.Id = reader.GetGuid(1);
                            productCategory.Name = reader.GetString(2);
                            productCategory.Description = reader.GetString(3);
                            productCategory.CreatedOn = reader.GetDateTime(4);
                            productCategory.UpdatedOn = reader.GetDateTime(5);
                            productCategory.StatusBit = reader.GetInt32(6);
                            productCategory.CreatedBy = reader.GetGuid(7);
                            productCategory.UpdatedBy = reader.GetGuid(8);
                            productCategory.SubCategoryName = reader.GetString(9);
                        }
                    }
                }
            }
            catch { }

            return productCategory;
        }

        bool IProductCategoryDAL.Save(Guid? productCategoryId, string name, string description, string subCategoryName, Guid? userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            // Validate.
            if (!Common.Validation.IsNotEmpty(name))
            {
                return returnValue;
            }

            _connection.Connect();

            string queryString;
            if (productCategoryId == null)
            {
                queryString = "INSERT INTO public.\"ProductCategory\" (id, name, description, createdon, updatedon, statusbit, subcategoryname) VALUES(:id, :name, :description, :createdon, :updatedon, :statusbit, :subcategoryname);";
            }
            else
            {
                queryString = "UPDATE public.\"ProductCategory\" SET description = :description, updatedon = :updatedon, subcategoryname = :subcategoryname WHERE id = :id;";
            }

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", productCategoryId == null ? Guid.NewGuid() : productCategoryId);
                    command.Parameters.AddWithValue(":name", name);
                    command.Parameters.AddWithValue(":description", description);
                    if (productCategoryId == null)
                    {
                        command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":createdby", userId);
                    }
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":subcategoryname", subCategoryName);

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

        bool IProductCategoryDAL.Delete(Guid productCategoryId, Guid userId, out string errorMessage)
        {
            bool returnValue = false;
            errorMessage = string.Empty;
            _connection.Connect();

            string queryString = "UPDATE public.\"ProductCategory\" SET statusbit = :statusbit, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
            {
                command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_DELETED);
                command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                command.Parameters.AddWithValue(":updatedby", userId);
                command.Parameters.AddWithValue(":id", productCategoryId);

                if (command.ExecuteNonQuery() > 0)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }
    }
}
