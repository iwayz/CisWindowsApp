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
        public FrmReportingDashboard()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FrmInvoiceRecap frmInvoiceRecap = new FrmInvoiceRecap();
            frmInvoiceRecap.ShowDialog();
        }
    }
}
