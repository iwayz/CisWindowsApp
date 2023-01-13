using Cis.Model;
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

        public int AreaWidth { get; set; } = 1024;
        public int AreaHeight { get; set; } = 800;

        public FrmTransactionDashboard()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Transaction.Sales)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            pnlMenuTransaction.Hide();
            OpenChildForm(new FrmSalesOrder(), sender);

        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Transaction.Order)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            pnlMenuTransaction.Hide();
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
            this.pnlTransactionChildren.Controls.Add(childForm);
            this.pnlTransactionChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTransactionChildHeader.Text = childForm.Text;
            this.pnlMenuTransaction.Visible = false;
        }

        private void FrmTransactionDashboard_Load(object sender, EventArgs e)
        {
            gbMenuTransaction.Left = (AreaWidth - gbMenuTransaction.Width) / 2;
            gbMenuTransaction.Top = (AreaHeight - gbMenuTransaction.Height) / 5;

            lblTransactionChildHeader.Left = (this.pnlChildHeader.Width - lblTransactionChildHeader.Width) / 2;
            lblTransactionChildHeader.Top = (this.pnlChildHeader.Height - lblTransactionChildHeader.Height) / 2;
        }
    }
}
