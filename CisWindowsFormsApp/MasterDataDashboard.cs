using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{

    public partial class MasterDataDashboard : Form
    {
        private Form activeForm;

        public MasterDataDashboard()
        {
            InitializeComponent();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            //var testFrm = new FormTest();
            //testFrm.ShowDialog();
            OpenChildForm(new FormTest(), sender);
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
            this.pnlMasterDataChildren.Controls.Add(childForm);
            this.pnlMasterDataChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblMasterDataChildHeader.Text = childForm.Text;
        }
    }
}
