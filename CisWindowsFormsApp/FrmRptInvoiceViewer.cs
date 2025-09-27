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
            var pic = ((DataSources.DataSourceInvoice.DataTableInvoiceRow)dt.Rows[0]).PersonInCharge;
            var sipaNo = ((DataSources.DataSourceInvoice.DataTableInvoiceRow)dt.Rows[0]).SipaNo;
            var compPicParam = new ReportParameter("CompPic", pic + Environment.NewLine + sipaNo);
            var soIdParam = new ReportParameter("SalesOrderId", SalesOrderId);
            var compDetail = @Properties.Settings.Default.CompAddress + Environment.NewLine
                + "Telepon: " + Properties.Settings.Default.CompPhone + ", Email: "+ Properties.Settings.Default.CompEmail + Environment.NewLine
                + "Nomor Izin PBOT: " + Properties.Settings.Default.CompLicenseNo + Environment.NewLine 
                + "NPWP: " + Properties.Settings.Default.CompNpwp + Environment.NewLine;
            var compDetailParam = new ReportParameter("CompDetail", compDetail);

            reportViewerInvoice.LocalReport.SetParameters(compNameParam);
            reportViewerInvoice.LocalReport.SetParameters(compDetailParam);
            reportViewerInvoice.LocalReport.SetParameters(compPicParam);
            reportViewerInvoice.LocalReport.SetParameters(soIdParam);
            reportViewerInvoice.RefreshReport();

            reportViewerInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerInvoice.ZoomMode = ZoomMode.Percent;
            reportViewerInvoice.ZoomPercent = 100;
            var marginBottom = 40;
            if (dt.Rows.Count <= 6)
                marginBottom = 20;
            reportViewerInvoice.SetPageSettings(
                new PageSettings
                {
                    //Landscape = true,
                    PaperSize = new PaperSize("Faktur CISPOS", 950, 550),
                    Margins = new Margins { Top = 20, Left = 20, Right = 20, Bottom = marginBottom }
                }
            );
            reportViewerInvoice.ShowExportButton = false;
            reportViewerInvoice.RefreshReport();

        }
    }
}
