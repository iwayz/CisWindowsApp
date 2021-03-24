using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmRptInvoiceViewer : Form
    {
        public string SalesOrderId { get; set; }

        public FrmRptInvoiceViewer()
        {
            InitializeComponent();
        }

        private void FrmRptInvoiceViewer_Load(object sender, EventArgs e)
        {
            DataTable dt = dataTableInvoiceTableAdapter.GetData(SalesOrderId);
            ReportDataSource rds = new ReportDataSource("DataSetInvoice", dt);
            reportViewerInvoice.LocalReport.DataSources.Add(rds);

            // parameters
            var compNameParam = new ReportParameter("CompName", Properties.Settings.Default.CompName);
            var compPicParam = new ReportParameter("CompPic", Properties.Settings.Default.SalesPicName + Environment.NewLine + Properties.Settings.Default.SalesPicSipaNo);
            var soIdParam = new ReportParameter("SalesOrderId", SalesOrderId);
            var compDetail = @Properties.Settings.Default.CompAddress + Environment.NewLine
                + "Telepon: " + Properties.Settings.Default.CompPhone + ", Email: "+ Properties.Settings.Default.CompEmail + Environment.NewLine
                + "PBF: " + Properties.Settings.Default.CompPbf + Environment.NewLine 
                + "SIUP: " + Properties.Settings.Default.CompSiup + Environment.NewLine
                + "NPWP: " + Properties.Settings.Default.CompNpwp + Environment.NewLine;
            var compDetailParam = new ReportParameter("CompDetail", compDetail);

            reportViewerInvoice.LocalReport.SetParameters(compNameParam);
            reportViewerInvoice.LocalReport.SetParameters(compDetailParam);
            reportViewerInvoice.LocalReport.SetParameters(compPicParam);
            reportViewerInvoice.LocalReport.SetParameters(soIdParam);
            reportViewerInvoice.RefreshReport();

            reportViewerInvoice.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewerInvoice.ZoomMode = ZoomMode.Percent;
            reportViewerInvoice.ZoomPercent = 100;
            reportViewerInvoice.SetPageSettings(
                new PageSettings
                {
                    Landscape = true,
                    PaperSize = new PaperSize("Cont. Form A5", 580, 830),
                    Margins = new Margins { Top = 10, Left = 20, Right = 40, Bottom = 40 }
                }
            );
            reportViewerInvoice.ShowExportButton = false;
            reportViewerInvoice.RefreshReport();

        }
    }
}
