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
    public partial class FrmCustomerRecap : Form
    {
        CisDbContext dbContext;
        UnitOfWork<Customer> uowCustomer;
        UnitOfWork<Location> uowLocation;
        UnitOfWork<OutletType> uowOutletType;
        UnitOfWork<SalesArea> uowSalesarea;
        string fileLoc = string.Empty;
        string exceptionMessage = string.Empty;

        public FrmCustomerRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmCustomerRecap_Load(object sender, EventArgs e)
        {
            uowCustomer= new UnitOfWork<Customer>(dbContext);
            uowLocation = new UnitOfWork<Location>(dbContext);
            uowOutletType = new UnitOfWork<OutletType>(dbContext);
            uowSalesarea= new UnitOfWork<SalesArea>(dbContext);
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
                var customers = uowCustomer.Repository.GetAll();
                var locations = uowLocation.Repository.GetAll();
                var outletTypes = uowOutletType.Repository.GetAll();
                var salesAreas = uowSalesarea.Repository.GetAll();

                var report = customers
                    .Join(locations, cus => cus.ProvinceId, prov => prov.Id, (cus, prov) => new { cus, prov })
                    .Join(locations, cusProv => cusProv.cus.DistrictId, dis => dis.Id, (cusProv, dis) => new { cusProv, dis})
                    .Join(outletTypes, cusProvDis => cusProvDis.cusProv.cus.OutletTypeId, outt => outt.Id, (cusProvDis, outt) => new { cusProvDis, outt })
                    .Join(salesAreas, cusProvDisOutt => cusProvDisOutt.cusProvDis.cusProv.cus.SalesAreaId, sal => sal.Id, (cusProvDisOutt, sal) => new { cusProvDisOutt, sal })
                    .Select(res => new
                    {
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.CustomerCode,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.CustomerName,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.Address,
                        Province = res.cusProvDisOutt.cusProvDis.cusProv.prov.Name,
                        District = res.cusProvDisOutt.cusProvDis.dis.Name,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.PostalCode,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.Phone,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.Email,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.Npwp,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.PharmacistName,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.SipaNo,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.SipaExpiredDate,
                        res.cusProvDisOutt.cusProvDis.cusProv.cus.SiaNo,
                        OutletType = res.cusProvDisOutt.outt.Description,
                        SalesArea = res.sal.Description
                    }).OrderBy(ord => ord.CustomerCode).ToList();

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "PELANGGAN";
                xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;

                // Header
                xlWorkSheet.Cells[1, 1] = "KODE PELANGGAN";
                xlWorkSheet.Cells[1, 2] = "NAMA PELANGGAN";
                xlWorkSheet.Cells[1, 3] = "ALAMAT";
                xlWorkSheet.Cells[1, 4] = "PROVINSI";
                xlWorkSheet.Cells[1, 5] = "KOTA";
                xlWorkSheet.Cells[1, 6] = "KODE POS";
                xlWorkSheet.Cells[1, 7] = "TELEPON";
                xlWorkSheet.Cells[1, 8] = "EMAIL";
                xlWorkSheet.Cells[1, 9] = "NPWP";
                xlWorkSheet.Cells[1, 10] = "NAMA APOTEKER";
                xlWorkSheet.Cells[1, 11] = "NO. SIPA";
                xlWorkSheet.Cells[1, 12] = "EXPIRED SIPA";
                xlWorkSheet.Cells[1, 13] = "NO. SIA";
                xlWorkSheet.Cells[1, 14] = "JENIS OUTLET";
                xlWorkSheet.Cells[1, 15] = "AREA";

                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = report.Count();
                foreach (var item in report)
                {
                    xlWorkSheet.Cells[rowNumber, 1].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 1] = item.CustomerCode.Trim();

                    xlWorkSheet.Cells[rowNumber, 2] = item.CustomerName;

                    xlWorkSheet.Cells[rowNumber, 3] = item.Address;
                    
                    xlWorkSheet.Cells[rowNumber, 4] = item.Province;

                    xlWorkSheet.Cells[rowNumber, 5] = item.District;

                    xlWorkSheet.Cells[rowNumber, 6].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 6] = item.PostalCode;

                    xlWorkSheet.Cells[rowNumber, 7].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 7] = item.Phone;

                    xlWorkSheet.Cells[rowNumber, 8].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 8] = item.Email;

                    xlWorkSheet.Cells[rowNumber, 9].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 9] = item.Npwp;
                    
                    xlWorkSheet.Cells[rowNumber, 10] = item.PharmacistName;
                    
                    xlWorkSheet.Cells[rowNumber, 11].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 11] = item.SipaNo;

                    xlWorkSheet.Cells[rowNumber, 12].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 12].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight; 
                    xlWorkSheet.Cells[rowNumber, 12] = item.SipaExpiredDate;
                    
                    xlWorkSheet.Cells[rowNumber, 13].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 13] = item.SiaNo;
                    
                    xlWorkSheet.Cells[rowNumber, 14] = item.OutletType;
                    
                    xlWorkSheet.Cells[rowNumber, 15] = item.SalesArea;

                    // progress bar
                    var progress = ((rowNumber - 1) * 100) / totalRecord;
                    backgroundWorker.ReportProgress(progress);
                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI", "PELANGGAN"));
                var fileName = "REKAPITULASI PELANGGAN_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileLoc))
                return;

            Process.Start(Path.GetDirectoryName(fileLoc));
        }
    }
}
