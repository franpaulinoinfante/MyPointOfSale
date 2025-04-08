using MyPointOfSale.Controllers;
using System;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
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

            UserController user = new UserController();

            Application.Run(new Login(user));
        }
    }
}
