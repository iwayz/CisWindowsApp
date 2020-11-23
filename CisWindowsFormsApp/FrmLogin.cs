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

namespace CisWindowsFormsApp
{
    public partial class FrmLogin : Form
    {
        CisDbContext dbContext;
        FrmMain frmMain;

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
                Properties.Settings.Default.Save();
                this.Hide();


                frmMain = new FrmMain();
                frmMain.RefToLoginForm = this;
                this.Visible = false;
                frmMain.ShowDialog();
            }
            else
                MessageBox.Show("Username or password invalid");
        }

    }
}
