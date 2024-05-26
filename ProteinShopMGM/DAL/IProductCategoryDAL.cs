using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal interface IProductCategoryDAL
    {
        List<ProductCategory> GetAll(string nameFilter);
        ProductCategory GetById(Guid productCategoryId);
        ProductCategory GetByName(string productCategoryName, string subCategoryName);
        bool Save(Guid? productCategoryId, string name, string description, string subCategoryName, Guid? userId, out string errorMessage);
        bool Delete(Guid productCategoryId, Guid userId, out string errorMessage);
    }
}
