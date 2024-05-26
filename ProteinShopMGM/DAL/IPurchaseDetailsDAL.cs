using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;

namespace ProteinShopMGM.DAL
{
    internal interface IPurchaseDetailsDAL
    {
        List<PurchaseDetails> GetAllByPurchaseId(Guid purchaseId);
        bool Save(Guid purchaseId, Guid productId, DateTime packingDate, DateTime expiryDate, int quantity, float rate, float mrp, Guid userId, out string errorMessage);
        float GetMRPByProductId(Guid productId);
    }
}
