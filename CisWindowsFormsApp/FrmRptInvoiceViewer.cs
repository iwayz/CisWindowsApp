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
            var soIdParam = new ReportParameter("SalesOrderId", "89815B73-F9A9-46BB-9801-1C8357038267");
            var compDetail = @"JL. Mayjend Bambang Sugeng Km.5 Magelang 56172" + Environment.NewLine
                + "Telpon 0293-325333 , Email: cise@sari-sehat.com" + Environment.NewLine
                + "Ijin PBF: xxxxxxxx" + Environment.NewLine 
                + "SIUP: xxxxxxxx" + Environment.NewLine
                + "NPWP: xxxxxxxx" + Environment.NewLine;
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
                    PaperSize = new PaperSize("A5", 580, 830),
                    Margins = new Margins { Top = 25, Left = 15, Right = 15, Bottom = 15 }
                }
            );
            reportViewerInvoice.RefreshReport();

        }
    }
}
