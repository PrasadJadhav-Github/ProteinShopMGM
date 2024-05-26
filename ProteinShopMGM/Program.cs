using System;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MDIParent._loggedInUser == null)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new MDIParent());
            }
        }
    }
}
