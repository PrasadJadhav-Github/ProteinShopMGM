using System;

namespace ProteinShopMGM.DAL.Models
{
    internal class Sell : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public DateTime BillDate { get; set; }
        public float TotalAmount { get; set; }
        public float Discount { get; set; }
        public float NetAmount { get; set; }
    }
}
