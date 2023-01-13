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
        private int activeMenu = 1;

        enum ActiveMenu
        {
            Master = 1, Transaction = 2, Reporting = 3
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblToday.Text = DateTime.Now.ToString("dddd, dd-MMM-yyyy");
            lblYear.Text = "© " + DateTime.Now.Year.ToString();
            lblCurrentUser.Text = Properties.Settings.Default.CurrentUser.ToUpper();
            lblCompanyName.Text = Properties.Settings.Default.CompName.ToUpper();
            lblCompanyWeb.Text = Properties.Settings.Default.CompWebsite;
            btnMasterData.PerformClick();

            setQotd();
        }


        // Width, Height
        private Tuple<int, int> GetUsableArea()
        {
            return Tuple.Create(this.ClientSize.Width - 172, this.ClientSize.Height - 50);
        }
        private void btnMasterData_Click(object sender, EventArgs e)
        {
            activeMenu = (int)ActiveMenu.Master;

            var usableArea = GetUsableArea();
            var form = new FrmMasterDataDashboard();
            form.AreaWidth = usableArea.Item1;
            form.AreaHeight = usableArea.Item2;
            OpenChildForm(form, sender);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            activeMenu = (int)ActiveMenu.Transaction;
            
            var usableArea = GetUsableArea();
            var form = new FrmTransactionDashboard();
            form.AreaWidth = usableArea.Item1;
            form.AreaHeight = usableArea.Item2;
            OpenChildForm(form, sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            activeMenu = (int)ActiveMenu.Reporting;

            var usableArea = GetUsableArea();
            var form = new FrmReportingDashboard();
            form.AreaWidth = usableArea.Item1;
            form.AreaHeight = usableArea.Item2;
            OpenChildForm(form, sender);
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

            var areaWitdh = this.ClientSize.Width - 172;
            var areaHight = this.ClientSize.Height - 50;
            
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

        #region FUN code

        private void setQotd()
        {
            var lstQotd = new List<string>()
            {
                "The only way to do great work is to love what you do -- Steve Jobs",
                "Believe you can and you're halfway there -- Theodore Roosevelt",
                "Be the change you wish to see in the world -- Mahatma Gandhi",
                "Happiness is not something ready made. It comes from your own actions -- Dalai Lama 14",
                "It does not matter how slowly you go as long as you do not stop -- Confucius",
                "You miss 100% of the shots you don't take -- Wayne Gretzky",
                "The only limit to our realization of tomorrow will be our doubts of today -- Franklin D. Roosevelt",
                "The greatest glory in living lies not in never falling, but in rising every time we fall -- Nelson Mandela",
                "It is during our darkest moments that we must focus to see the light -- Aristotle",
                "Positive anything is better than negative nothing -- Elbert Hubbard",
                "The power of imagination makes us infinite -- John Muir",
                "You can't build a reputation on what you are going to do -- Henry Ford",
                "Life is 10% what happens to you and 90% how you react to it -- Charles R. Swindoll",
                "Success is not final, failure is not fatal: it is the courage to continue that counts -- Winston Churchill",
                "Hardships often prepare ordinary people for an extraordinary destiny -- C.S. Lewis",
                "You are never too old to set another goal or to dream a new dream -- C.S Lewis",
                "The biggest adventure you can ever take is to live the life of your dreams -- Oprah Winfrey",
                "Life is like riding a bicycle. To keep your balance, you must keep moving -- Albert Einstein",
                "You can't use up creativity. The more you use, the more you have -- Maya Angelou",
                "It is not the mountain we conquer, but ourselves -- Edmund Hillary"
            };
            var random = new Random();
            var qotd = lstQotd[random.Next(lstQotd.Count())];

            toolTip.SetToolTip(pnlDateTime, qotd);
            toolTip.SetToolTip(pictureBoxDate, qotd);
            toolTip.SetToolTip(lblToday, qotd);
        }

        #endregion

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            switch (activeMenu)
            {
                case (int)ActiveMenu.Master:
                    btnMasterData.PerformClick();
                    break;
                case (int)ActiveMenu.Transaction:
                    btnTransaksi.PerformClick();
                    break;
                case (int)ActiveMenu.Reporting:
                    btnReporting.PerformClick();
                    break;
                default:
                    btnMasterData.PerformClick();
                    break;
            }
        }
    }
}
