using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            // TODO: This line of code loads data into the 'dataSet1.OutletType' table. You can move, or remove it, as needed.
            var compNameParam = new ReportParameter("CompanyName", Properties.Settings.Default.CompName);
            this.reportViewer1.LocalReport.SetParameters(compNameParam);
            this.outletTypeTableAdapter.Fill(this.dataSet1.OutletType);

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
