using System;

namespace ProteinShopMGM.DAL.Models
{
    /// <summary>
    /// This class defines the Product Category model.
    /// </summary>
    public class ProductCategory : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string SubCategoryName { get; set; }
    }
}
