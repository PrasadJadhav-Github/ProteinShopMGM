using ProteinShopMGM.DAL.Models;

namespace ProteinShopMGM.DAL
{
    /// <summary>
    /// This interface declares the database operations required for the User model.
    /// </summary>
    internal interface IUserDAL
    {
        User GetByUsername(string username);
    }
}
