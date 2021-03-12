using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using NLog;

namespace CisWindowsFormsApp
{
    public partial class FrmInvoiceRecap : Form
    {
        CisDbContext dbContext;
        UnitOfWork<SalesOrder> uowSo;
        UnitOfWork<SalesOrderItem> uowSoi;
        UnitOfWork<Customer> uowCus;
        UnitOfWork<OutletType> uowOt;
        UnitOfWork<SalesArea> uowSa;
        UnitOfWork<Representative> uowRe;
        string fileLoc = string.Empty;
        string exceptionMessage = string.Empty;

        public FrmInvoiceRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmInvoiceRecap_Load(object sender, EventArgs e)
        {
            uowSo = new UnitOfWork<SalesOrder>(dbContext);
            uowSoi = new UnitOfWork<SalesOrderItem>(dbContext);
            uowCus = new UnitOfWork<Customer>(dbContext);
            uowOt = new UnitOfWork<OutletType>(dbContext);
            uowSa = new UnitOfWork<SalesArea>(dbContext);
            uowRe = new UnitOfWork<Representative>(dbContext);

            // set the date from to beginning of current month
            var year = dtpFrom.Value.Year;
            var month = dtpFrom.Value.Month;
            dtpFrom.Value = new DateTime(year, month, 1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pnlDateRange.Enabled = false;
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
                var representative = uowRe.Repository.GetAll();
                var salesArea = uowSa.Repository.GetAll()
                    .Join(representative, sa => sa.RepresentativeId, re => re.Id, (sa, re) => new { sa, re }).Select(res => res);
                var customer = uowCus.Repository.GetAll();
                var outlet = uowOt.Repository.GetAll();
                var cusDet = customer.Join(outlet, c => c.OutletTypeId, o => o.Id, (c, o) => new { c, o })
                    .Select(res => new
                    {
                        res.c.Id,
                        res.c.CustomerCode,
                        res.c.CustomerName,
                        res.c.OutletTypeId,
                        res.o.OutletTypeCode,
                        res.o.Description
                    }).ToList();

                var salesOrder = uowSo.Repository.GetAll().
                    Where(s => s.SalesDate >= dtpFrom.Value && s.SalesDate <= dtpTo.Value && s.Status == Constant.RecordStatus.Active);
                var salesOrderItem = uowSoi.Repository.GetAll();
                var salesOrderDetail = salesOrderItem
                    .Join(salesOrder, soi => soi.SalesOrderId, so => so.Id, (soi, so) => new { soi, so })
                    .Select(res => new
                    {
                        res.so.SalesDate,
                        res.so.SalesNo,
                        res.so.CustomerId,
                        res.so.CustomerName,
                        res.so.CustomerNpwp,
                        res.so.CustomerAddress,
                        res.so.CustomerDistrict,
                        res.so.SalesmanCode,
                        res.so.SalesAreaId,
                        res.so.SalesAreaCode,
                        res.so.CustomerProvince,
                        res.soi.ProductCode,
                        res.soi.ProductName,
                        res.soi.BatchCode,
                        res.soi.ExpiredDate,
                        res.soi.UomCode,
                        res.soi.Quantity,
                        res.soi.Price,
                        res.soi.TotalAmount,
                        res.soi.DiscountPercentage,
                        res.so.TaxBaseAmount,
                        res.so.ValueAddedTaxAmount,
                        res.so.ExtraDiscountAmount,
                        res.so.GrandTotalAmount,
                        res.so.DueDate,
                        res.so.DeliveryAddress,
                        res.so.DeliveryDistrict,
                        res.so.CustomerPhone
                    })
                    .ToList();

                var recapDetail = salesOrderDetail.Join(cusDet, sod => sod.CustomerId, cusd => cusd.Id, (sod, cusd) => new { sod, cusd })
                    .Join(salesArea, sodcusd => sodcusd.sod.SalesAreaId, sa => sa.sa.Id, (sodcusd, sa) => new { sodcusd, sa })
                    .ToList().OrderBy(res => res.sodcusd.sod.SalesNo);

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "UBICAPS";
                xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;

                // Header
                xlWorkSheet.Cells[1, 1] = "TANGGAL";
                xlWorkSheet.Cells[1, 2] = "NO. FAKTUR";
                xlWorkSheet.Cells[1, 3] = "KODE PELANGGAN";
                xlWorkSheet.Cells[1, 4] = "NAMA PELANGGAN";
                xlWorkSheet.Cells[1, 5] = "NPWP";
                xlWorkSheet.Cells[1, 6] = "ALAMAT LENGKAP";
                xlWorkSheet.Cells[1, 7] = "KOTA";
                xlWorkSheet.Cells[1, 8] = "NAMA SALES";
                xlWorkSheet.Cells[1, 9] = "RAYON";
                xlWorkSheet.Cells[1, 10] = "PERWAKILAN";
                xlWorkSheet.Cells[1, 11] = "JENIS OUTLET";
                xlWorkSheet.Cells[1, 12] = "KODE BARANG";
                xlWorkSheet.Cells[1, 13] = "NAMA BARANG";
                xlWorkSheet.Cells[1, 14] = "NOMER BATCH";
                xlWorkSheet.Cells[1, 15] = "KADALUWARSA";
                xlWorkSheet.Cells[1, 16] = "SAT";
                xlWorkSheet.Cells[1, 17] = "QTY";
                xlWorkSheet.Cells[1, 18] = "HARGA HNA";
                xlWorkSheet.Cells[1, 19] = "GROSS VALUE";
                xlWorkSheet.Cells[1, 20] = "%DISKON";
                xlWorkSheet.Cells[1, 21] = "EXT. DISKON";
                xlWorkSheet.Cells[1, 22] = "DPP";
                xlWorkSheet.Cells[1, 23] = "PPN 10%";
                xlWorkSheet.Cells[1, 24] = "NETT VALUE";
                xlWorkSheet.Cells[1, 25] = "TGL.JTH TEMPO";
                xlWorkSheet.Cells[1, 26] = "ALAMAT KIRIM";
                xlWorkSheet.Cells[1, 27] = "KOTA";
                xlWorkSheet.Cells[1, 28] = "NO. TELPON";

                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = recapDetail.Count();
                foreach (var item in recapDetail)
                {
                    var qty = item.sodcusd.sod.Quantity;
                    var price = item.sodcusd.sod.Price;
                    var grossValue = qty * price;
                    var discountPercentage = Math.Round(item.sodcusd.sod.DiscountPercentage / 100, 2);
                    var extraDiscount = item.sodcusd.sod.ExtraDiscountAmount;

                    // Set the Extra Discount proportionally
                    var sumOfGrossValue = recapDetail.Where(so => so.sodcusd.sod.SalesNo == item.sodcusd.sod.SalesNo)
                        .Sum(aa => (aa.sodcusd.sod.Quantity * aa.sodcusd.sod.Price));
                    var propotionalExtraDiscount = (grossValue / sumOfGrossValue) * extraDiscount;

                    var taxBaseAmount = Math.Round((grossValue * (1 - Convert.ToDecimal(discountPercentage)) - propotionalExtraDiscount), 5, MidpointRounding.AwayFromZero);
                    var valueAddedAmount = Math.Round(taxBaseAmount * Convert.ToDecimal(0.1), 5, MidpointRounding.AwayFromZero);
                    var netValue = Math.Round(taxBaseAmount + valueAddedAmount, 5, MidpointRounding.AwayFromZero);

                    xlWorkSheet.Cells[rowNumber, 1].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 1] = item.sodcusd.sod.SalesDate.ToShortDateString();
                    xlWorkSheet.Cells[rowNumber, 2] = item.sodcusd.sod.SalesNo;
                    xlWorkSheet.Cells[rowNumber, 3].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 3] = item.sodcusd.cusd.CustomerCode.ToString();
                    xlWorkSheet.Cells[rowNumber, 4] = item.sodcusd.cusd.CustomerName;
                    xlWorkSheet.Cells[rowNumber, 5].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 5] = item.sodcusd.sod.CustomerNpwp;
                    xlWorkSheet.Cells[rowNumber, 6] = item.sodcusd.sod.CustomerAddress;
                    xlWorkSheet.Cells[rowNumber, 7] = item.sodcusd.sod.CustomerDistrict;
                    xlWorkSheet.Cells[rowNumber, 8] = item.sodcusd.sod.SalesmanCode;
                    xlWorkSheet.Cells[rowNumber, 9] = item.sa.sa.Description;
                    xlWorkSheet.Cells[rowNumber, 10] = item.sa.re.Description;
                    xlWorkSheet.Cells[rowNumber, 11] = item.sodcusd.cusd.Description;
                    xlWorkSheet.Cells[rowNumber, 12] = item.sodcusd.sod.ProductCode;
                    xlWorkSheet.Cells[rowNumber, 13] = item.sodcusd.sod.ProductName;
                    xlWorkSheet.Cells[rowNumber, 14].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 14] = item.sodcusd.sod.BatchCode;
                    xlWorkSheet.Cells[rowNumber, 15].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 15].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 15] = item.sodcusd.sod.ExpiredDate.ToString("MM/yyyy");
                    xlWorkSheet.Cells[rowNumber, 16] = item.sodcusd.sod.UomCode.ToString();
                    xlWorkSheet.Cells[rowNumber, 17].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 17] = qty;
                    xlWorkSheet.Cells[rowNumber, 18].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 18] = price;
                    xlWorkSheet.Cells[rowNumber, 19].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 19] = grossValue;
                    xlWorkSheet.Cells[rowNumber, 20].NumberFormat = "0,0%";
                    xlWorkSheet.Cells[rowNumber, 20] = discountPercentage;
                    xlWorkSheet.Cells[rowNumber, 21].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 21] = propotionalExtraDiscount;
                    xlWorkSheet.Cells[rowNumber, 22].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 22] = taxBaseAmount;
                    xlWorkSheet.Cells[rowNumber, 23].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 23] = valueAddedAmount;
                    xlWorkSheet.Cells[rowNumber, 24].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 24] = netValue;
                    xlWorkSheet.Cells[rowNumber, 25].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 25].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 25] = item.sodcusd.sod.DueDate.ToShortDateString();
                    xlWorkSheet.Cells[rowNumber, 26] = item.sodcusd.sod.DeliveryAddress;
                    xlWorkSheet.Cells[rowNumber, 27] = item.sodcusd.sod.DeliveryDistrict;
                    xlWorkSheet.Cells[rowNumber, 28].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 28] = item.sodcusd.sod.CustomerPhone;

                    var progress = ((rowNumber - 1) * 100) / totalRecord;
                    backgroundWorker.ReportProgress(progress);
                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI"));
                var fileName = "REKAPITULASI FAKTUR_" + DateTime.Now.ToString("yyyyMMddHHmmss");
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
            } else
            {
                CommonMessageHelper.ContactAdminError();
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(exceptionMessage);
            }
            pnlDateRange.Enabled = true;
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
