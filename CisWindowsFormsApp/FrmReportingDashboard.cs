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
    public partial class FrmReportingDashboard : Form
    {
        private Form activeForm;

        public int AreaWidth { get; set; } = 1024;
        public int AreaHeight { get; set; } = 800;

        public FrmReportingDashboard()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Reporting.Sales)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            FrmInvoiceRecap frmInvoiceRecap = new FrmInvoiceRecap();
            frmInvoiceRecap.ShowDialog();
        }

        private void btnExportProduct_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Product)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            FrmProductRecap frmProductRecap = new FrmProductRecap();
            frmProductRecap.ShowDialog();
        }

        private void btnExportPelanggan_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Customer)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            FrmCustomerRecap frmCustomerRecap = new FrmCustomerRecap();
            frmCustomerRecap.ShowDialog();
        }

        private void btnStockMovement_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Reporting.StockMovement)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            OpenChildForm(new FrmStockMovement(), sender);
        }

        private void btnStockCard_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Reporting.StockMovement)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            OpenChildForm(new FrmStockCard(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlReportingChildren.Controls.Add(childForm);
            pnlReportingChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblReportingChildHeader.Text = childForm.Text;
            pnlMenuReporting.Visible = false;
        }

        private void CenterControls()
        {
            gbMenuReporting.Left = (pnlMenuReporting.Width - gbMenuReporting.Width) / 2;
            gbMenuReporting.Top = (pnlMenuReporting.Height - gbMenuReporting.Height) / 5;
            lblReportingChildHeader.Left = (pnlChildHeader.Width - lblReportingChildHeader.Width) / 2;
            lblReportingChildHeader.Top = (pnlChildHeader.Height - lblReportingChildHeader.Height) / 2;
        }

        private void FrmReportingDashboard_Load(object sender, EventArgs e) => CenterControls();
        private void FrmReportingDashboard_Resize(object sender, EventArgs e) => CenterControls();
    }
}
