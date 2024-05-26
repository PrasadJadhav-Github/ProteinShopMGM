using System;

namespace ProteinShopMGM.DAL.Models
{
    public class Supplier : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int SupplierType { get; set; }
        public string SupplierTypeText { get; set; }
    }
}
