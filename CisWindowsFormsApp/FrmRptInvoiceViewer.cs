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
            SalesOrderId = "89815B73-F9A9-46BB-9801-1C8357038267";
            DataTable dt = dataTableInvoiceTableAdapter.GetData(SalesOrderId);
            ReportDataSource rds = new ReportDataSource("DataSetInvoice", dt);
            reportViewerInvoice.LocalReport.DataSources.Add(rds);

            // parameters
            var compNameParam = new ReportParameter("CompName", Properties.Settings.Default.CompName);
            var soIdParam = new ReportParameter("SalesOrderId", "89815B73-F9A9-46BB-9801-1C8357038267");
            var compDetailParam = new ReportParameter("CompDetail", "Jalan jalan aja");

            reportViewerInvoice.LocalReport.SetParameters(compNameParam);
            reportViewerInvoice.LocalReport.SetParameters(compDetailParam);
            reportViewerInvoice.LocalReport.SetParameters(soIdParam);
            reportViewerInvoice.RefreshReport();

            reportViewerInvoice.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //var pgSetting = new PageSettings();
            //pgSetting.Landscape = true;
            //pgSetting.PaperSize = new PaperSize("A5", 580, 830);
            //this.reportViewer1.SetPageSettings(pgSetting);  
            reportViewerInvoice.SetPageSettings(
                new PageSettings
                {
                    Landscape = true,
                    PaperSize = new PaperSize("A5", 580, 830),
                    Margins = new Margins { Top = 10, Left = 10, Right = 10, Bottom = 10 }
                }
            );

        }
    }
}
