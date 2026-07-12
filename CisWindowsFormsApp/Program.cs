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

            try
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<CisDbContext, Configuration>());
                using (var context = new CisDbContext())
                    context.Database.Initialize(force: false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memperbarui struktur database:\n\n" + ex.Message +
                    "\n\nAplikasi tidak dapat dijalankan. Hubungi administrator sistem.",
                    "Kesalahan Migrasi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new FrmBackupDatabase());
        }
    }
}
