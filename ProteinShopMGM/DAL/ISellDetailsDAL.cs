using System;

namespace ProteinShopMGM.DAL
{
    internal interface ISellDetailsDAL
    {
        bool Save(Guid sellId, Guid productId, int quantity, float price, Guid userId, out string errorMessage);
    }
}
