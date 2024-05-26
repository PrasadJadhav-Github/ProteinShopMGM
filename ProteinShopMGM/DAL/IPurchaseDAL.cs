using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal interface IPurchaseDAL
    {
        List<Purchase> GetAll(int? purchaseStatus, DateTime? fromDate, DateTime? toDate);
        Purchase GetPurchaseById(int purchaseId);
        bool Save(Guid supplierId, DateTime purchaseDate, int purchaseStatus, Guid userId, out Guid purchaseId, out string errorMessage);
        bool UpdateStatus(Guid purchaseId, int purchaseStatus, Guid userId, out string errorMessage);
    }
}
