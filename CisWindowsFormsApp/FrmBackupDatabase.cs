using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmBackupDatabase : Form
    {
        string fileLoc = string.Empty;

        public FrmBackupDatabase()
        {
            InitializeComponent();
        }

        private void backgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var defConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                var connString = new System.Data.SqlClient.SqlConnectionStringBuilder(defConnectionString);
                var fileDir = Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "BACKUP_DATABASE"));
                var fileName = $"{connString.InitialCatalog}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.bak"; 
                fileLoc = Path.Combine(fileDir.FullName, fileName);

                Server dbServer = new Server(new ServerConnection(connString.DataSource, connString.UserID, connString.Password));
                Backup dbBackup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = connString.InitialCatalog
                };
                dbBackup.Devices.AddDevice($"{fileLoc}", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.SqlBackupAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorkerBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbExport.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Proses backup database telah selesai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFileLocation.Text = fileLoc;
            pbExport.Value = 0;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            fileLoc = string.Empty;
            txtFileLocation.Text = string.Empty;

            pbExport.Maximum = 100;
            pbExport.Step = 1;
            pbExport.Value = 0;
            backgroundWorkerBackup.RunWorkerAsync();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileLoc))
                return;

            Process.Start(Path.GetDirectoryName(fileLoc));
        }

        private void FrmBackupDatabase_Load(object sender, EventArgs e)
        {
           
        }
    }
}
