using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetInvoice";
            var dt = this.dataTableInvoiceTableAdapter.GetData("89815B73-F9A9-46BB-9801-1C8357038267" );
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);


            // TODO: This line of code loads data into the 'dataSet1.OutletType' table. You can move, or remove it, as needed.
            // 89815B73-F9A9-46BB-9801-1C8357038267
            var compNameParam = new ReportParameter("CompName", Properties.Settings.Default.CompName);
            var soIdParam = new ReportParameter("SalesOrderId", "89815B73-F9A9-46BB-9801-1C8357038267");
            var compDetailParam = new ReportParameter("CompDetail", "Jalan jalan aja");
            
            //reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(compNameParam);
            this.reportViewer1.LocalReport.SetParameters(compDetailParam);
            this.reportViewer1.LocalReport.SetParameters(soIdParam);
            reportViewer1.RefreshReport();

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //var pgSetting = new PageSettings();
            //pgSetting.Landscape = true;
            //pgSetting.PaperSize = new PaperSize("A5", 580, 830);
            //this.reportViewer1.SetPageSettings(pgSetting);  
            this.reportViewer1.SetPageSettings(
                new PageSettings
                {
                    Landscape = true,
                    PaperSize = new PaperSize("A5", 580, 830),
                    Margins = new Margins { Top = 10 }
                }
            );


            this.reportViewer1.RefreshReport();

        }

    }
}
