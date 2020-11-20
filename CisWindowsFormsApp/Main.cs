using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class Main : Form
    {
        Login loginFrm;
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginFrm = new Login();
            loginFrm.ShowDialog();
            lblToday.Text = DateTime.Now.ToString("dddd, dd-MMM-yyyy");
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MasterDataDashboard(), sender);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTest(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnReporting.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginFrm.ShowDialog();
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
    }
}
