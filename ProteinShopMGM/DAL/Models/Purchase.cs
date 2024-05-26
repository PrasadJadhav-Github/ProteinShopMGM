using System;

namespace ProteinShopMGM.DAL.Models
{
    public class Purchase : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchaseStatus { get; set; }
        public string PurchaseStatusText { get; set; }
    }
}
