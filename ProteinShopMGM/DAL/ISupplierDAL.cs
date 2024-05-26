using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal interface ISupplierDAL
    {
        List<Supplier> GetAll(string nameFilter);
        Supplier GetById(Guid supplierId);
        Supplier GetByName(string supplierName);
        bool Save(Guid? supplierId, string name, string address, string contact, int supplierType, Guid userId, out string errorMessage);
        bool Delete(Guid supplierId, Guid userId, out string errorMessage);
    }
}
