using Cis.Data;
using Cis.Model;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmMain : Form
    {
        public Form RefToLoginForm { get; set; }

        private Form activeForm;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblToday.Text = DateTime.Now.ToString("dddd, dd-MMM-yyyy");
            lblCurrentUser.Text = Properties.Settings.Default.CurrentUser.ToUpper();
            lblCompanyName.Text = Properties.Settings.Default.CompName.ToUpper();
            lblCompanyWeb.Text = Properties.Settings.Default.CompWebsite;
            btnMasterData.PerformClick();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMasterDataDashboard(), sender);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTransactionDashboard(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReportingDashboard(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.RefToLoginForm.Show();
            this.Hide();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildren.Controls.Add(childForm);
            this.pnlChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHeader.Text = childForm.Text;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void manualBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            try
            {
                var path = Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(Path.Combine(path, @"Resources\CisPosManual.pdf"));
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Unexpected");
                CommonMessageHelper.ContactAdminError();
            }
            finally
            {
                LogManager.Shutdown();
            }

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompanyInfo frmCompanyInfo = new FrmCompanyInfo();
            frmCompanyInfo.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only Super Admin can do the backup
            using (var context = new CisDbContext())
            {
                var userRole = new UnitOfWork<UserRole>(context).Repository.GetAll()
                    .Where(u => u.UserId == Properties.Settings.Default.CurrentUserId).FirstOrDefault();
                var isSuperAdmin = new UnitOfWork<Role>(context).Repository.GetAll()
                    .Where(r => r.Id == userRole.RoleId && r.RoleCode == "SUPER").FirstOrDefault() != null;

                if (!isSuperAdmin)
                {
                    CommonMessageHelper.NoAccess();
                    return;
                }
                FrmBackupDatabase frmBackupDatabase = new FrmBackupDatabase();
                frmBackupDatabase.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
