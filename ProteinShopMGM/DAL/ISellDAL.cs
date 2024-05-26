using System;

namespace ProteinShopMGM.DAL
{
    internal interface ISellDAL
    {
        bool Save(Guid customerId, DateTime billDate, float totalAmount, float discount, float netAmount, Guid userId, out Guid sellId, out string errorMessage);
        double GetTotalSell(DateTime fromDate, DateTime toDate);
    }
}
