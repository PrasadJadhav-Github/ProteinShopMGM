using System;

namespace ProteinShopMGM.DAL.Models
{
    /// <summary>
    /// This class defines the User model.
    /// </summary>
    public class User : IBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusBit { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
