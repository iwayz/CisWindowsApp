using Cis.Data;
using Cis.Model;
using NLog;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CisWindowsFormsApp
{
    public partial class FrmPurchaseRecap : Form
    {
        CisDbContext dbContext;
        UnitOfWork<PurchaseOrder> uowPo;
        UnitOfWork<PurchaseOrderItem> uowPoi;
        UnitOfWork<Principal> uowPri;
        UnitOfWork<Representative> uowRep;

        string fileLoc = string.Empty;
        string exceptionMessage = string.Empty;

        public FrmPurchaseRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmPurchaseRecap_Load(object sender, EventArgs e)
        {
            uowPo = new UnitOfWork<PurchaseOrder>(dbContext);
            uowPoi = new UnitOfWork<PurchaseOrderItem>(dbContext);
            uowPri = new UnitOfWork<Principal>(dbContext);
            uowRep = new UnitOfWork<Representative>(dbContext);

            // set the date from to beginning of current month
            var year = dtpFrom.Value.Year;
            var month = dtpFrom.Value.Month;
            dtpFrom.Value = new DateTime(year, month, 1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtpTo.Value < dtpFrom.Value)
            {
                MessageBox.Show("Tanggal Akhir harus lebih besar dari Tanggal Awal.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                var fromDate = dtpFrom.Value.Date;
                var toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

                var purchaseOrders = uowPo.Repository.GetAll()
                    .Where(po => po.PostingStatus == PurchaseOrderStatus.Received
                              && po.OrderDate >= fromDate
                              && po.OrderDate <= toDate)
                    .ToList();

                var poIds = purchaseOrders.Select(po => po.Id).ToList();

                var items = uowPoi.Repository.GetAll()
                    .Where(i => poIds.Contains(i.PurchaseOrderId))
                    .ToList();

                var supplierCodes = uowPri.Repository.GetAll()
                    .ToDictionary(p => p.Id, p => p.PrincipalCode);

                var representativeNames = uowRep.Repository.GetAll()
                    .ToDictionary(r => r.Id, r => r.Description);

                var recapDetail = (from item in items
                                    join po in purchaseOrders on item.PurchaseOrderId equals po.Id
                                    orderby po.PONumber, item.ProductCode
                                    select new { po, item })
                                    .ToList();

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "UBICAPS PEMBELIAN";
                xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;

                var ppnHeader = recapDetail.Any() && recapDetail.Max(r => r.po.ReceivedDate.Value) >= new DateTime(2022, 4, 1)
                    ? "PPN 11%" : "PPN 10%";

                // Header
                xlWorkSheet.Cells[1, 1] = "TGL. TERIMA BARANG";
                xlWorkSheet.Cells[1, 2] = "NO. FAKTUR";
                xlWorkSheet.Cells[1, 3] = "KODE SUPPLIER";
                xlWorkSheet.Cells[1, 4] = "NAMA SUPPLIER";
                xlWorkSheet.Cells[1, 5] = "ALAMAT SUPPLIER";
                xlWorkSheet.Cells[1, 6] = "TGL. FAKTUR";
                xlWorkSheet.Cells[1, 7] = "TGL. FAKTUR PAJAK";
                xlWorkSheet.Cells[1, 8] = "NO. FAKTUR PAJAK";
                xlWorkSheet.Cells[1, 9] = "Perwakilan";
                xlWorkSheet.Cells[1, 10] = "KODE BARANG";
                xlWorkSheet.Cells[1, 11] = "NAMA BARANG";
                xlWorkSheet.Cells[1, 12] = "NOMER BATCH";
                xlWorkSheet.Cells[1, 13] = "KADALUWARSA";
                xlWorkSheet.Cells[1, 14] = "SAT";
                xlWorkSheet.Cells[1, 15] = "QTY";
                xlWorkSheet.Cells[1, 16] = "HARGA";
                xlWorkSheet.Cells[1, 17] = "HNA";
                xlWorkSheet.Cells[1, 18] = "DISCOUNT";
                xlWorkSheet.Cells[1, 19] = "DPP";
                xlWorkSheet.Cells[1, 20] = ppnHeader;
                xlWorkSheet.Cells[1, 21] = "NETT VALUE";
                xlWorkSheet.Cells[1, 22] = "TGL.JTH TEMPO";
                xlWorkSheet.Cells[1, 23] = "Saldo Awal";

                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = recapDetail.Count;
                foreach (var rec in recapDetail)
                {
                    var po = rec.po;
                    var item = rec.item;

                    var qty = item.Quantity;
                    var price = item.Price;
                    var hna = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
                    var dpp = item.TotalAmount;
                    var discount = hna - dpp;
                    var taxPct = po.OrderDate >= new DateTime(2022, 4, 1) ? 0.11m : 0.10m;
                    var ppn = Math.Round(dpp * taxPct, 0, MidpointRounding.AwayFromZero);
                    var nettValue = dpp + ppn;

                    var supplierCode = supplierCodes.TryGetValue(po.SupplierId, out var sCode) ? sCode : string.Empty;
                    var perwakilan = !string.IsNullOrEmpty(po.RepresentativeId) && representativeNames.TryGetValue(po.RepresentativeId, out var repName)
                        ? repName : string.Empty;

                    xlWorkSheet.Cells[rowNumber, 1].NumberFormat = "dd/mm/yyyy;@";
                    xlWorkSheet.Cells[rowNumber, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 1] = po.ReceivedDate.Value;

                    xlWorkSheet.Cells[rowNumber, 2] = po.SupplierInvoiceNumber ?? string.Empty;

                    xlWorkSheet.Cells[rowNumber, 3].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 3] = supplierCode;

                    xlWorkSheet.Cells[rowNumber, 4] = po.SupplierName;

                    xlWorkSheet.Cells[rowNumber, 5] = po.SupplierAddress;

                    if (po.SupplierInvoiceDate.HasValue)
                    {
                        xlWorkSheet.Cells[rowNumber, 6].NumberFormat = "dd/mm/yyyy;@";
                        xlWorkSheet.Cells[rowNumber, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                        xlWorkSheet.Cells[rowNumber, 6] = po.SupplierInvoiceDate.Value;

                        xlWorkSheet.Cells[rowNumber, 7].NumberFormat = "dd/mm/yyyy;@";
                        xlWorkSheet.Cells[rowNumber, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                        xlWorkSheet.Cells[rowNumber, 7] = po.SupplierInvoiceDate.Value;
                    }

                    xlWorkSheet.Cells[rowNumber, 8].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 8] = po.TaxInvoiceNumber ?? string.Empty;

                    xlWorkSheet.Cells[rowNumber, 9] = perwakilan;

                    xlWorkSheet.Cells[rowNumber, 10] = item.ProductCode;

                    xlWorkSheet.Cells[rowNumber, 11] = item.ProductName;

                    xlWorkSheet.Cells[rowNumber, 12].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 12] = item.BatchCode ?? string.Empty;

                    xlWorkSheet.Cells[rowNumber, 13].NumberFormat = "dd/mm/yyyy;@";
                    xlWorkSheet.Cells[rowNumber, 13].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 13] = item.ExpiredDate;

                    xlWorkSheet.Cells[rowNumber, 14] = item.UomCode;

                    xlWorkSheet.Cells[rowNumber, 15].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 15] = qty;

                    xlWorkSheet.Cells[rowNumber, 16].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 16] = price;

                    xlWorkSheet.Cells[rowNumber, 17].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 17] = hna;

                    xlWorkSheet.Cells[rowNumber, 18].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 18] = discount;

                    xlWorkSheet.Cells[rowNumber, 19].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 19] = dpp;

                    xlWorkSheet.Cells[rowNumber, 20].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 20] = ppn;

                    xlWorkSheet.Cells[rowNumber, 21].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 21] = nettValue;

                    // col 22 TGL.JTH TEMPO, col 23 Saldo Awal intentionally left blank

                    if (totalRecord > 0)
                    {
                        var progress = ((rowNumber - 1) * 100) / totalRecord;
                        backgroundWorker.ReportProgress(progress);
                    }

                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "REKAPITULASI", "UBICAPS"));
                var fileName = "REKAPITULASI PEMBELIAN_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
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
                pnlProgress.Location = new System.Drawing.Point(16, 114);
                pnlResult.Location = new System.Drawing.Point(16, 220);
            }
            else
            {
                pnlProgress.Location = new System.Drawing.Point(16, 220);
                pnlResult.Location = new System.Drawing.Point(16, 114);
            }
        }
    }
}
