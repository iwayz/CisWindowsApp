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
        string fileLoc = string.Empty;

        public FrmInvoiceRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmInvoiceRecap_Load(object sender, EventArgs e)
        {
            uowSo = new UnitOfWork<SalesOrder>(dbContext);
            uowSoi = new UnitOfWork<SalesOrderItem>(dbContext);
            uowCus= new UnitOfWork<Customer>(dbContext);
            uowOt= new UnitOfWork<OutletType>(dbContext);
            uowSa = new UnitOfWork<SalesArea>(dbContext);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pnlDateRange.Enabled = false;
            pbExport.Maximum = 100;
            pbExport.Step = 1;
            pbExport.Value = 0;
            backgroundWorker.RunWorkerAsync();

            this.Height = 255;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var salesArea = uowSa.Repository.GetAll();
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

            var salesOrder = uowSo.Repository.GetAll();
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
                    res.soi.UomCode,
                    res.soi.Quantity,
                    res.soi.Price,
                    res.soi.TotalAmount,
                    res.soi.DiscountPercentage,
                    res.so.TaxBaseAmount,
                    res.so.ValueAddedTaxAmount,
                    res.so.DueDate,
                    res.so.DeliveryAddress,
                    res.so.DeliveryDistrict,
                    res.so.CustomerPhone
                })
                .ToList();

            var recapDetail = salesOrderDetail.Join(cusDet, sod => sod.CustomerId, cusd => cusd.Id, (sod, cusd) => new { sod, cusd })
                .Join(salesArea, sodcusd => sodcusd.sod.SalesAreaId, sa => sa.Id, (sodcusd, sa) => new { sodcusd, sa })
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
            xlWorkSheet.Cells[1, 14] = "SAT";
            xlWorkSheet.Cells[1, 15] = "QTY";
            xlWorkSheet.Cells[1, 16] = "HARGA HNA";
            xlWorkSheet.Cells[1, 17] = "GROSS VALUE";
            xlWorkSheet.Cells[1, 18] = "%DISKON";
            xlWorkSheet.Cells[1, 19] = "DPP";
            xlWorkSheet.Cells[1, 20] = "PPN 10%";
            xlWorkSheet.Cells[1, 21] = "NETT VALUE";
            xlWorkSheet.Cells[1, 22] = "TGL.JTH TEMPO";
            xlWorkSheet.Cells[1, 23] = "ALAMAT KIRIM";
            xlWorkSheet.Cells[1, 24] = "KOTA";
            xlWorkSheet.Cells[1, 25] = "NO. TELPON";

            var rowNum = 2;
            var totalRec = recapDetail.Count();
            foreach (var item in recapDetail)
            {
                xlWorkSheet.Cells[rowNum, 1] = item.sodcusd.sod.SalesDate.ToShortDateString();
                xlWorkSheet.Cells[rowNum, 2] = item.sodcusd.sod.SalesNo;
                xlWorkSheet.Cells[rowNum, 3] = "'" + item.sodcusd.cusd.CustomerCode.ToString();
                xlWorkSheet.Cells[rowNum, 4] = item.sodcusd.cusd.CustomerName;
                xlWorkSheet.Cells[rowNum, 5] = "'" + item.sodcusd.sod.CustomerNpwp;
                xlWorkSheet.Cells[rowNum, 6] = item.sodcusd.sod.CustomerAddress;
                xlWorkSheet.Cells[rowNum, 7] = item.sodcusd.sod.CustomerDistrict;
                xlWorkSheet.Cells[rowNum, 8] = item.sodcusd.sod.SalesmanCode;
                xlWorkSheet.Cells[rowNum, 9] = item.sa.Description;
                xlWorkSheet.Cells[rowNum, 10] = item.sodcusd.sod.CustomerProvince;
                xlWorkSheet.Cells[rowNum, 11] = item.sodcusd.cusd.Description;
                xlWorkSheet.Cells[rowNum, 12] = item.sodcusd.sod.ProductCode;
                xlWorkSheet.Cells[rowNum, 13] = item.sodcusd.sod.ProductName;
                xlWorkSheet.Cells[rowNum, 14] = item.sodcusd.sod.UomCode.ToString();
                xlWorkSheet.Cells[rowNum, 15] = item.sodcusd.sod.Quantity;
                xlWorkSheet.Cells[rowNum, 16] = item.sodcusd.sod.Price;
                xlWorkSheet.Cells[rowNum, 17] = item.sodcusd.sod.TotalAmount;
                xlWorkSheet.Cells[rowNum, 18] = item.sodcusd.sod.DiscountPercentage;
                xlWorkSheet.Cells[rowNum, 19] = item.sodcusd.sod.TaxBaseAmount;
                xlWorkSheet.Cells[rowNum, 20] = item.sodcusd.sod.ValueAddedTaxAmount;
                xlWorkSheet.Cells[rowNum, 21] = (item.sodcusd.sod.TaxBaseAmount + item.sodcusd.sod.ValueAddedTaxAmount);
                xlWorkSheet.Cells[rowNum, 22] = item.sodcusd.sod.DueDate.ToShortDateString();
                xlWorkSheet.Cells[rowNum, 23] = item.sodcusd.sod.DeliveryAddress;
                xlWorkSheet.Cells[rowNum, 24] = item.sodcusd.sod.DeliveryDistrict;
                xlWorkSheet.Cells[rowNum, 25] = item.sodcusd.sod.CustomerPhone;

                var progress = ((rowNum - 1) * 100) / totalRec;
                backgroundWorker.ReportProgress(progress);
                rowNum++;
            }
            xlWorkSheet.Columns.AutoFit();
            var fileDir = System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI"));
            var fileName = "REKAPITULASI FAKTUR_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            fileLoc = System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI",  fileName);
            xlWorkBook.SaveAs(fileLoc, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbExport.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Proses export Data Rekapitulasi telah selesai, silakan cek file di: " + Environment.NewLine + fileLoc, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlDateRange.Enabled = true;
            pbExport.Value = 0;
            this.Height = 160;
        }
    }
}
