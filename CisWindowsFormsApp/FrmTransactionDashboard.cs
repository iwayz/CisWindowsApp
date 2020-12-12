using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmTransactionDashboard : Form
    {
        private Form activeForm;

        public FrmTransactionDashboard()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUserRole(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUserRole(), sender);

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
            this.pnlTransactionChildren.Controls.Add(childForm);
            this.pnlTransactionChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTransactionChildHeader.Text = childForm.Text;
        }
    }
}
