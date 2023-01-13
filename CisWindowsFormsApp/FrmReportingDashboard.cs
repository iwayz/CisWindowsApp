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

        private void FrmReportingDashboard_Load(object sender, EventArgs e)
        {
            gbMenuReporting.Left = (AreaWidth - gbMenuReporting.Width) / 2;
            gbMenuReporting.Top = (AreaHeight - gbMenuReporting.Height) / 5;

            lblReportingChildHeader.Left = (this.pnlChildHeader.Width - lblReportingChildHeader.Width) / 2;
            lblReportingChildHeader.Top = (this.pnlChildHeader.Height - lblReportingChildHeader.Height) / 2;
        }
    }
}
