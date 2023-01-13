using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Configuration;
using System.IO;

namespace CisWindowsFormsApp
{
    public partial class FrmLogin : Form
    {
        CisDbContext dbContext;
        FrmMain frmMain;
        UnitOfWork<CompanyInfo> uowCompInfo;

        public FrmLogin()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }


        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0'; 
            }

            if (txtUserName.Text == "Username")
                txtUserName.Text = string.Empty;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
                txtUserName.Text = "Username";

            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var uow = new UnitOfWork<User>(dbContext);
            var pwd = new UserHelper().HashPassword(txtPassword.Text.Trim());
            var user = uow.Repository.GetAll().Where(u => u.Username == txtUserName.Text.Trim() && u.Password == pwd).FirstOrDefault();
            if (user != null)
            {
                txtUserName.Text = "Username";
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                lnkExit.Focus();
                Properties.Settings.Default["CurrentUser"] = user.Username;
                Properties.Settings.Default["CurrentUserId"] = user.Id.ToString().ToUpper();
                Properties.Settings.Default.Save();
                SetAppConfigCompanyInfo();
                this.Hide();

                frmMain = new FrmMain();
                frmMain.RefToLoginForm = this;
                this.Visible = false;
                frmMain.ShowDialog();
            }
            else
                MessageBox.Show("Username atau Password Anda salah.",
                 "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SetAppConfigCompanyInfo()
        {
            var compInfo = uowCompInfo.Repository.GetAll();
            if (compInfo.Any())
            {
                var compName = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompName)).FirstOrDefault().Value;
                var compAddress = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompAddress)).FirstOrDefault().Value;
                var compPhone = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompPhone)).FirstOrDefault().Value;
                var compEmail = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompEmail)).FirstOrDefault().Value;
                var compWeb = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompWebsite)).FirstOrDefault().Value;
                var compPbf = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompLicenseNo)).FirstOrDefault().Value;
                var compNpwp = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompNpwp)).FirstOrDefault().Value;
                var picName = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.PicName)).FirstOrDefault().Value;
                var picSipaNo = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.PicLicenseNo)).FirstOrDefault().Value;

                Properties.Settings.Default[nameof(Properties.Settings.Default.CompName)] = compName;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompAddress)] = compAddress;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompPhone)] = compPhone;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompEmail)] = compEmail;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompWebsite)] = compWeb;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompLicenseNo)] = compPbf;
                Properties.Settings.Default[nameof(Properties.Settings.Default.CompNpwp)] = compNpwp;
                Properties.Settings.Default[nameof(Properties.Settings.Default.PicName)] = picName;
                Properties.Settings.Default[nameof(Properties.Settings.Default.PicLicenseNo)] = picSipaNo;
                Properties.Settings.Default.Save();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            uowCompInfo = new UnitOfWork<CompanyInfo>(dbContext);
            lblWebsite.Text = Properties.Settings.Default.CompWebsite;
        }
    }
}
