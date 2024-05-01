using DevExpress.UserSkins;
using School_Management.Manager.Course;
using School_Management.Manager.Student;
using System;

using System.Windows.Forms;

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
            Application.Run(new Manager_Student());

        }
    }
}
