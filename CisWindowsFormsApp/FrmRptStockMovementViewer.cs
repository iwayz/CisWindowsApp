using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmRptStockMovementViewer : Form
    {
        public List<StockMovementReportRow> ReportData { get; set; }
        public DateTime PrintDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string TypeFilter { get; set; }
        public string SearchFilter { get; set; }

        public FrmRptStockMovementViewer()
        {
            InitializeComponent();
        }

        private void FrmRptStockMovementViewer_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("DataSetStockMovement", ReportData);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);

            var period = $"{DateFrom:dd/MM/yyyy} s/d {DateTo:dd/MM/yyyy}";
            var filterInfo = string.IsNullOrEmpty(SearchFilter) ? TypeFilter : $"{TypeFilter} | Barang: {SearchFilter}";

            reportViewer.LocalReport.SetParameters(new ReportParameter("CompName", Properties.Settings.Default.CompName));
            reportViewer.LocalReport.SetParameters(new ReportParameter("PrintDate", PrintDate.ToString("dd/MM/yyyy HH:mm")));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Period", period));
            reportViewer.LocalReport.SetParameters(new ReportParameter("FilterInfo", filterInfo));

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.ShowExportButton = true;
            reportViewer.SetPageSettings(new PageSettings
            {
                Landscape = true,
                PaperSize = new PaperSize("A4 Landscape", 1169, 827),
                Margins = new Margins { Top = 30, Left = 30, Right = 30, Bottom = 30 }
            });
            reportViewer.RefreshReport();
        }
    }
}
