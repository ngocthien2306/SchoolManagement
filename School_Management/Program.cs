using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using School_Management.Manager.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using School_Management.Manager.Contact;
namespace School_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new Login_Account());
        }
    }
}
