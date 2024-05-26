using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal interface ICustomerDAL
    {
        List<Customer> GetAll(string nameFilter);
        Customer GetById(Guid customerId);
        Customer GetByName(string customerName);
        bool Save(Guid? customerId, string name, string contact, string address, int customerType, Guid userId, out string errorMessage);
        bool Delete(Guid customerId, Guid userId, out string errorMessage);
    }
}
