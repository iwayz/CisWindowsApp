using Cis.Data;
using Cis.Model;
using NLog;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CisWindowsFormsApp
{
    public partial class FrmProductRecap : Form
    {
        CisDbContext dbContext;
        UnitOfWork<Product> uowProduct;
        UnitOfWork<UnitOfMeasurement> uowUom;
        UnitOfWork<MedicineCat> uowMedicineCat;
        UnitOfWork<UsageType> uowUsageType;
        UnitOfWork<Principal> uowPrincipal;
        string fileLoc = string.Empty;
        string exceptionMessage = string.Empty;

        public FrmProductRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmProductRecap_Load(object sender, EventArgs e)
        {
            uowProduct = new UnitOfWork<Product>(dbContext);
            uowUom = new UnitOfWork<UnitOfMeasurement>(dbContext);
            uowMedicineCat = new UnitOfWork<MedicineCat>(dbContext);
            uowUsageType = new UnitOfWork<UsageType>(dbContext);
            uowPrincipal = new UnitOfWork<Principal>(dbContext);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pnlCriteria.Enabled = false;
            SetUiPanel(true);
            pbExport.Maximum = 100;
            pbExport.Step = 1;
            pbExport.Value = 0;
            backgroundWorker.RunWorkerAsync();
        }
        
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var products = uowProduct.Repository.GetAll();
                var unitOfMeasurements = uowUom.Repository.GetAll();
                var medicineCats = uowMedicineCat.Repository.GetAll();
                var usageTypes = uowUsageType.Repository.GetAll();
                var principals = uowPrincipal.Repository.GetAll();

                var report = products
                    .Join(unitOfMeasurements, pro => pro.UnitId, uom => uom.Id, (pro, uom) => new { pro, uom })
                    .Join(medicineCats, proUom => proUom.pro.MedicineCatId, med => med.Id, (proUom, med) => new { proUom, med })
                    .Join(usageTypes, proUomUsa => proUomUsa.proUom.pro.UsageTypeId, usa => usa.Id, (proUomUsa, usa) => new { proUomUsa, usa })
                    .Join(principals, proUomUsaPri => proUomUsaPri.proUomUsa.proUom.pro.PrincipalId, pri => pri.Id, (proUomUsaPri, pri) => new { proUomUsaPri, pri })
                    .Select(res => new
                    {
                        res.proUomUsaPri.proUomUsa.proUom.pro.ProductCode,
                        res.proUomUsaPri.proUomUsa.proUom.pro.ProductName,
                        res.proUomUsaPri.proUomUsa.proUom.pro.Price,
                        res.proUomUsaPri.proUomUsa.proUom.pro.PriceDecreeDate,
                        res.proUomUsaPri.proUomUsa.proUom.pro.Discount,
                        UnitOfMeasurement = res.proUomUsaPri.proUomUsa.proUom.uom.Description,
                        MedicineCat = res.proUomUsaPri.proUomUsa.med.Description,
                        UsageType = res.proUomUsaPri.usa.Description,
                        res.pri.PrincipalName
                    }).OrderBy(ord => ord.ProductCode).ToList();

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "PRODUK";
                xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;

                // Header
                xlWorkSheet.Cells[1, 1] = "KODE PRODUK";
                xlWorkSheet.Cells[1, 2] = "NAMA PRODUK";
                xlWorkSheet.Cells[1, 3] = "HARGA";
                xlWorkSheet.Cells[1, 4] = "TANGGAL S.K.";
                xlWorkSheet.Cells[1, 5] = "DISKON";
                xlWorkSheet.Cells[1, 6] = "UNIT";
                xlWorkSheet.Cells[1, 7] = "JENIS OBAT";
                xlWorkSheet.Cells[1, 8] = "JENIS PENGGUNAAN";
                xlWorkSheet.Cells[1, 9] = "PRINCIPAL";

                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = report.Count();
                foreach (var item in report)
                {
                    xlWorkSheet.Cells[rowNumber, 1] = item.ProductCode.Trim();

                    xlWorkSheet.Cells[rowNumber, 2] = item.ProductName;

                    xlWorkSheet.Cells[rowNumber, 3].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 3] = item.Price;

                    xlWorkSheet.Cells[rowNumber, 4].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight; 
                    xlWorkSheet.Cells[rowNumber, 4] = item.PriceDecreeDate;
                    
                    xlWorkSheet.Cells[rowNumber, 5].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 5] = item.Discount;
                    
                    xlWorkSheet.Cells[rowNumber, 6] = item.UnitOfMeasurement;
                    
                    xlWorkSheet.Cells[rowNumber, 7] = item.MedicineCat;
                    
                    xlWorkSheet.Cells[rowNumber, 8] = item.UsageType;
                    
                    xlWorkSheet.Cells[rowNumber, 9] = item.PrincipalName;

                    // progress bar
                    var progress = ((rowNumber - 1) * 100) / totalRecord;
                    backgroundWorker.ReportProgress(progress);
                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI", "PRODUK"));
                var fileName = "REKAPITULASI PRODUK_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                fileLoc = Path.Combine(fileDir.FullName, fileName);
                xlWorkBook.SaveAs(fileLoc, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbExport.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (string.IsNullOrEmpty(exceptionMessage))
            {
                MessageBox.Show("Proses export Data Rekapitulasi telah selesai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileLocation.Text = $"{fileLoc}.xls";
            }
            else
            {
                CommonMessageHelper.ContactAdminError();
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(exceptionMessage);
            }
            pnlCriteria.Enabled = true;
            pbExport.Value = 0;

            SetUiPanel(false);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileLoc))
                return;

            Process.Start(Path.GetDirectoryName(fileLoc));
        }

        private void SetUiPanel(bool isExport)
        {
            pnlResult.Visible = !isExport;
            pnlProgress.Visible = isExport;

            if (isExport)
            {
                pnlProgress.Location = new Point(16, 114);
                pnlResult.Location = new Point(16, 220);
            }
            else
            {
                pnlProgress.Location = new Point(16, 220);
                pnlResult.Location = new Point(16, 114);
            }
        }

    }
}
