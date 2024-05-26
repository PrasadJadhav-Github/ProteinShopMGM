using System;

namespace ProteinShopMGM.DAL.Models
{
    public class PurchaseDetails : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public DateTime PackingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public float Rate { get; set; }
        public float MRP { get; set; }
    }
}
