using System;

namespace ProteinShopMGM.DAL
{
    internal interface IStockDAL
    {
        bool Save(Guid productId, int quantity, Guid userId, out string errorMessage);
        int GetStockQuantityByProductId(Guid productId);
    }
}
