using Npgsql;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM.DAL
{
    internal class ProductDAL : IProductDAL
    {
        private readonly Connection _connection = new Connection();
        private readonly IProductCategoryDAL _productCategoryDAL = new ProductCategoryDAL();

        List<Product> IProductDAL.GetAll(string nameFilter, Guid? categoryFilter)
        {
            // Initialize.
            List<Product> products = new List<Product>();
            _connection.Connect();

            string condition = Common.Validation.IsNotEmpty(nameFilter) ?
                "name LIKE '%" + nameFilter + "%'" :
                "";
            if (categoryFilter != null) {
                if (condition != "")
                {
                    condition += " AND ";
                }

                condition += "productcategoryid = '" + categoryFilter + "'";
            }

            string queryString = Common.Validation.IsNotEmpty(condition) ?
                "SELECT * FROM public.\"Product\" WHERE " + condition + " AND " + "statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;" :
                "SELECT * FROM public.\"Product\" WHERE statusbit = " + Common.STATUSCODES.STATUS_ACTIVE + " ORDER BY j;";
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.Id = reader.GetGuid(1);
                            product.Code = reader.GetString(2);
                            product.Name = reader.GetString(3);
                            product.Price = (float)reader.GetDouble(4);
                            product.CreatedOn = reader.GetDateTime(5);
                            product.UpdatedOn = reader.GetDateTime(6);
                            product.StatusBit = reader.GetInt32(7);
                            product.CreatedBy = reader.GetGuid(8);
                            product.UpdatedBy = reader.GetGuid(9);
                            product.ProductCategoryId = reader.GetGuid(10);
                            if (!reader.IsDBNull(11))
                            {
                                product.Description = reader.GetString(11);
                            }
                            product.ReorderLevel = reader.GetInt32(12);
                            product.Size = reader.GetString(13);

                            // Retreive the product category details.
                            ProductCategory productCategory = _productCategoryDAL.GetById(product.ProductCategoryId);
                            if (productCategory != null) 
                            {
                                product.ProductCategoryName = productCategory.Name;
                            }

                            products.Add(product);
                        }
                    }
                }
            }
            catch { }

            return products;
        }

        Product IProductDAL.GetById(Guid productId)
        {
            // Initialize.
            Product product = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Product\" WHERE id = :id";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", productId);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            product = new Product();
                            product.Id = reader.GetGuid(1);
                            product.Code = reader.GetString(2);
                            product.Name = reader.GetString(3);
                            product.Price = (float)reader.GetDouble(4);
                            product.CreatedOn = reader.GetDateTime(5);
                            product.UpdatedOn = reader.GetDateTime(6);
                            product.StatusBit = reader.GetInt32(7);
                            product.CreatedBy = reader.GetGuid(8);
                            product.UpdatedBy = reader.GetGuid(9);
                            product.ProductCategoryId = reader.GetGuid(10);
                            if (!reader.IsDBNull(11))
                            {
                                product.Description = reader.GetString(11);
                            }
                            product.ReorderLevel = reader.GetInt32(12);
                            product.Size = reader.GetString(13);

                            // Retreive the product category details.
                            ProductCategory productCategory = _productCategoryDAL.GetById(product.ProductCategoryId);
                            if (productCategory != null)
                            {
                                product.ProductCategoryName = productCategory.Name;
                            }
                        }
                    }
                }
            }
            catch { }

            return product;
        }

        Product IProductDAL.GetByCode(string productCode)
        {
            // Initialize.
            Product product = null;
            _connection.Connect();

            string queryString = "SELECT * FROM public.\"Product\" WHERE UPPER(code) = :code AND statusbit = :statusbit";
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":code", productCode.ToUpper());
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);

                    using (NpgsqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        // Loop through the available data.
                        if (reader.Read())
                        {
                            product = new Product();
                            product.Id = reader.GetGuid(1);
                            product.Code = reader.GetString(2);
                            product.Name = reader.GetString(3);
                            product.Price = (float)reader.GetDouble(4);
                            product.CreatedOn = reader.GetDateTime(5);
                            product.UpdatedOn = reader.GetDateTime(6);
                            product.StatusBit = reader.GetInt32(7);
                            product.CreatedBy = reader.GetGuid(8);
                            product.UpdatedBy = reader.GetGuid(9);
                            product.ProductCategoryId = reader.GetGuid(10);
                            if (!reader.IsDBNull(11))
                            {
                                product.Description = reader.GetString(11);
                            }
                            product.ReorderLevel = reader.GetInt32(12);
                            product.Size = reader.GetString(13);

                            // Retreive the product category details.
                            ProductCategory productCategory = _productCategoryDAL.GetById(product.ProductCategoryId);
                            if (productCategory != null)
                            {
                                product.ProductCategoryName = productCategory.Name;
                            }
                        }
                    }
                }
            }
            catch { }

            return product;
        }

        bool IProductDAL.Save(Guid? productId, string productCode, string name, float price, Guid productCategoryId, string description, int reorderLevel, string size, Guid userId, out string errorMessage)
        {
            // Initialize.
            bool returnValue = false;
            errorMessage = string.Empty;

            // Validate.
            if (!Common.Validation.IsNotEmpty(productCode) || 
                !Common.Validation.IsNotEmpty(name) || 
                price == 0 ||
                !Common.Validation.IsNotEmpty(size))
            {
                return returnValue;
            }
            
            
            _connection.Connect();

            string queryString;
            if (productId == null)
            {
                queryString = "INSERT INTO public.\"Product\" (id, productcode, name, price, createdon, updatedon, statusbit, createdby, updatedby,  productcategoryid, description, reorderlevel, size) VALUES(:id, :productcode, :name, :price, :createdon, :updatedon, :statusbit, :createdby, :updatedby, :productcategoryid, :description, :reorderlevel, :size);";
            }
            else
            {
                queryString = "UPDATE public.\"Product\" SET productcode = :productcode, price = :price, updatedon = :updatedon, updatedby = :updatedby,  productcategoryid = :productcategoryid, description = :description, reorderlevel = :reorderlevel, size = :size WHERE id = :id;";
            }

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
                {
                    command.Parameters.AddWithValue(":id", productId == null ? Guid.NewGuid() : productId);
                    command.Parameters.AddWithValue(":productcode", productCode);
                    command.Parameters.AddWithValue(":name", name);   
                    command.Parameters.AddWithValue(":price", price);
                    if (productId == null)
                    {
                        command.Parameters.AddWithValue(":createdon", DateTime.UtcNow);
                        command.Parameters.AddWithValue(":createdby", userId);
                    }
                    command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                    command.Parameters.AddWithValue(":updatedby", userId);
                    command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_ACTIVE);
                    command.Parameters.AddWithValue(":productcategoryid", productCategoryId);
                    command.Parameters.AddWithValue(":description", description);
                    command.Parameters.AddWithValue(":reorderlevel", reorderLevel);
                    command.Parameters.AddWithValue(":size", size);                    

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

        bool IProductDAL.Delete(Guid productId, Guid userId, out string errorMessage)
        {
            bool returnValue = false;
            errorMessage = string.Empty;
            _connection.Connect();

            string queryString = "UPDATE public.\"Product\" SET statusbit = :statusbit, updatedon = :updatedon, updatedby = :updatedby WHERE id = :id;";
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, _connection.Get()))
            {
                command.Parameters.AddWithValue(":statusbit", Common.STATUSCODES.STATUS_DELETED);
                command.Parameters.AddWithValue(":updatedon", DateTime.UtcNow);
                command.Parameters.AddWithValue(":updatedby", userId);
                command.Parameters.AddWithValue(":id", productId);

                if (command.ExecuteNonQuery() > 0)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }
    }
}
