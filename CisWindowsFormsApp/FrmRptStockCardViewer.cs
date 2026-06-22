using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmRptStockCardViewer : Form
    {
        public List<StockCardReportRow> ReportData { get; set; }
        public DateTime PrintDate { get; set; }
        public string SearchFilter { get; set; }

        public FrmRptStockCardViewer()
        {
            InitializeComponent();
        }

        private void FrmRptStockCardViewer_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("DataSetStockCard", ReportData);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);

            reportViewer.LocalReport.SetParameters(new ReportParameter("CompName", Properties.Settings.Default.CompName));
            reportViewer.LocalReport.SetParameters(new ReportParameter("PrintDate", PrintDate.ToString("dd/MM/yyyy HH:mm")));
            reportViewer.LocalReport.SetParameters(new ReportParameter("SearchFilter", string.IsNullOrEmpty(SearchFilter) ? "Semua Barang" : SearchFilter));

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
