using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookClub.Models;
using Microsoft.Extensions.Configuration;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Xml;
using DevExpress.XtraPrinting.Native;
using System.Data.SqlClient;

namespace BookClub
{

    internal static class Program
    {

        public static readonly string APP_DATABASE = "BookClub";
        public static XmlDocument Configuration { get; private set; }

        public static string GetConnectionString(string name)
        {
            var node = Configuration.DocumentElement.
                SelectSingleNode($"connectionStrings/add[@name='" + name + "']/@connectionString");
            return node?.InnerText;
        }

        public static SqlConnection GetAppConnection()
        {
            var connectionString = GetConnectionString(APP_DATABASE);
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configuration = new XmlDocument();
            Configuration.Load("BookClub.exe.config");

            DialogResult result;
            User currentUser = null;
            using (var loginForm = new LoginForm())
            {
                result = loginForm.ShowDialog();
                currentUser = loginForm.CurrentUser;
            }
            if (result == DialogResult.OK && currentUser != null)
            {
                Application.Run(new MainForm(currentUser));
            }
        }

    }
}
