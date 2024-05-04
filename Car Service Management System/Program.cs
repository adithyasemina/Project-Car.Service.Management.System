using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_Management_System
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
            Application.Run(new MainForm());
        }
    }

    public class AdminSession
    {
        public static bool isLoggedIn = false;
    }

    public class DatabaseConnection
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30";
    }

    public class applicationValidations
    {
        public static bool IsNumeric(string value)
        {
            return int.TryParse(value, out _) || decimal.TryParse(value, out _) || long.TryParse(value, out _);
        }
    }
}
