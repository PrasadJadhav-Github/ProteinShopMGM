using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;
namespace ProteinShopMGM.DAL
{
    internal interface IProductDAL
    {
        List<Product> GetAll(string nameFilter, Guid? categoryFilter);
        Product GetByCode(string productCode);
        Product GetById(Guid productId);        
        bool Save(Guid? productId, string productCode, string name, float price, Guid productCategoryId, string description, int reorderLevel, string size, Guid userId, out string errorMessage);
        bool Delete(Guid productId, Guid userId, out string errorMessage);
    }
}
