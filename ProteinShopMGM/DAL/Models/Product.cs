using System;

namespace ProteinShopMGM.DAL.Models
{
    internal class Product : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public string Code { get; set; }
        public string Name { get; set;}
        public string Size { get; set; }
        public float Price { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public string Description { get; set; }
        public int ReorderLevel { get; set; }
    }
}
