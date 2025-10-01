using Cis.Data;
using Cis.Data.Migrations;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var s = new UserHelper().HashPassword("T77Qqxhc");

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CisDbContext, Configuration>());
            using (var context = new CisDbContext())
                context.Database.Initialize(force: false);
            
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new FrmBackupDatabase());
        }
    }
}
