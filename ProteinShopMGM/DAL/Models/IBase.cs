using System;

namespace ProteinShopMGM.DAL.Models
{
    /// <summary>
    /// This interface specifies the common properties of model classes.
    /// </summary>
    internal interface IBase
    {
        Guid Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        int StatusBit { get; set; }

        Guid? CreatedBy { get; set; }
        Guid? UpdatedBy { get; set; }
    }
}
