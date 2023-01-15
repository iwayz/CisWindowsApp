using Cis.Data;
using Cis.Model;
using NLog;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
        UnitOfWork<Product> uowPrd;
        UnitOfWork<Principal> uowPri;

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
            uowPrd= new UnitOfWork<Product>(dbContext);
            uowPri = new UnitOfWork<Principal>(dbContext);

            // set the date from to beginning of current month
            var year = dtpFrom.Value.Year;
            var month = dtpFrom.Value.Month;
            dtpFrom.Value = new DateTime(year, month, 1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dtpTo.Value < dtpFrom.Value)
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
                var representative = uowRe.Repository.GetAll();
                var salesAreaDet = uowSa.Repository.GetAll()
                    .Join(representative, sa => sa.RepresentativeId, re => re.Id, (sa, re) => new { sa, re })
                    .Select(res => new
                    {
                        res.sa.Id,
                        res.sa.AreaCode,
                        Rayon = res.sa.Description,
                        Representative = res.re.Description
                    });

                var outlet = uowOt.Repository.GetAll();
                var cusDet = uowCus.Repository.GetAll()
                    .Join(outlet, c => c.OutletTypeId, o => o.Id, (c, o) => new { c, o })
                    .Select(res => new
                    {
                        res.c.Id,
                        res.c.CustomerCode,
                        res.c.CustomerName,
                        res.c.OutletTypeId,
                        res.o.OutletTypeCode,
                        OutletType = res.o.Description
                    });

                var principal = uowPri.Repository.GetAll();
                var productDet = uowPrd.Repository.GetAll()
                    .Join(principal, prd => prd.PrincipalId, pri => pri.Id, (prd, pri) => new { prd, pri })
                    .Select(res => new
                    {
                        ProductId = res.prd.Id,
                        res.prd.ProductCode,
                        res.prd.ProductName,
                        res.prd.PrincipalId,
                        res.pri.PrincipalName
                    });

                var salesOrder = uowSo.Repository.GetAll().
                    Where(s => s.SalesDate >= dtpFrom.Value && s.SalesDate <= dtpTo.Value && s.Status == Constant.RecordStatus.Active);

                var recapDetail = uowSoi.Repository.GetAll()
                    .Join(salesOrder, soi => soi.SalesOrderId, so => so.Id, (soi, so) => new { soi, so })
                    .Join(productDet, soiSo => soiSo.soi.ProductId, prdDet => prdDet.ProductId, (soiSo, prdDet) => new { soiSo, prdDet })
                    .Join(cusDet, soiSoPrd => soiSoPrd.soiSo.so.CustomerId, cusd => cusd.Id, (soiSoPrd, cusd) => new { soiSoPrd, cusd })
                    .Join(salesAreaDet, soiSoPrdCus => soiSoPrdCus.soiSoPrd.soiSo.so.SalesAreaId, sa => sa.Id, (soiSoPrdCus, sa) => new { soiSoPrdCus, sa })
                    .Select(res => new
                    {
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.SalesDate,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.SalesNo,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerId,
                        res.soiSoPrdCus.cusd.CustomerCode,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerName,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerNpwp,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerAddress,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerDistrict,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.SalesmanCode,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.SalesAreaId,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.SalesAreaCode,
                        res.sa.Rayon,
                        res.sa.Representative,
                        res.soiSoPrdCus.cusd.OutletType,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerProvince,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.ProductId,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.ProductCode,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.ProductName,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.BatchCode,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.ExpiredDate,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.UomCode,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.Quantity,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.Price,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.TotalAmount,
                        res.soiSoPrdCus.soiSoPrd.soiSo.soi.DiscountPercentage,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.TaxBaseAmount,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.ValueAddedTaxAmount,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.ExtraDiscountAmount,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.GrandTotalAmount,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.DueDate,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.DeliveryAddress,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.DeliveryDistrict,
                        res.soiSoPrdCus.soiSoPrd.soiSo.so.CustomerPhone,
                        res.soiSoPrdCus.soiSoPrd.prdDet.PrincipalName
                    })
                    .OrderBy(res => res.SalesNo)
                    .ToList();

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
                xlWorkSheet.Cells[1, 22] = "TOTAL DISKON";
                xlWorkSheet.Cells[1, 23] = "DPP";
                xlWorkSheet.Cells[1, 24] = recapDetail.Max(s => s.SalesDate) >= new DateTime(2022, 4, 1) ? "PPN 11%" : "PPN 10%";
                xlWorkSheet.Cells[1, 25] = "NETT VALUE";
                xlWorkSheet.Cells[1, 26] = "TGL.JTH TEMPO";
                xlWorkSheet.Cells[1, 27] = "ALAMAT KIRIM";
                xlWorkSheet.Cells[1, 28] = "KOTA";
                xlWorkSheet.Cells[1, 29] = "NO. TELPON";
                xlWorkSheet.Cells[1, 30] = "PRINCIPAL";

                var salesOrderHelper = new SalesOrderHelper();
                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = recapDetail.Count();
                foreach (var item in recapDetail)
                {
                    var qty = item.Quantity;
                    var nettPrice = item.Price;
                    var grossValue = salesOrderHelper.CalculateGrossValue(qty, nettPrice);
                    var discountPercent = Math.Round(Convert.ToDecimal(item.DiscountPercentage / 100), 4, MidpointRounding.AwayFromZero);
                    var extraDiscount = item.ExtraDiscountAmount;

                    // Set the Extra Discount proportionally
                    var sumOfGrossValue = recapDetail.Where(so => so.SalesNo == item.SalesNo)
                        .Sum(rc => (rc.Quantity * rc.Price));
                    var propotionalExtraDiscount = (grossValue / sumOfGrossValue) * extraDiscount;
                    var totalDiscount = Math.Round(Convert.ToDecimal(grossValue * discountPercent), 4, MidpointRounding.AwayFromZero) + propotionalExtraDiscount;

                    var taxBaseAmount = salesOrderHelper.CalculateTaxBaseAmount(qty, nettPrice, discountPercent, extraDiscount);
                    var valueAddedAmount = salesOrderHelper.CalculateValueAddedAmount(taxBaseAmount, item.SalesDate);
                    var netValue = salesOrderHelper.CalculateNettValueAmount(taxBaseAmount, valueAddedAmount);

                    xlWorkSheet.Cells[rowNumber, 1].NumberFormat = "dd/mm/yyyy;@";
                    xlWorkSheet.Cells[rowNumber, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 1] = item.SalesDate;

                    xlWorkSheet.Cells[rowNumber, 2] = item.SalesNo.Substring(2);

                    xlWorkSheet.Cells[rowNumber, 3].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 3] = item.CustomerCode.ToString().Trim();

                    xlWorkSheet.Cells[rowNumber, 4] = item.CustomerName;

                    xlWorkSheet.Cells[rowNumber, 5].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 5] = item.CustomerNpwp;

                    xlWorkSheet.Cells[rowNumber, 6] = item.CustomerAddress;

                    xlWorkSheet.Cells[rowNumber, 7] = item.CustomerDistrict;

                    xlWorkSheet.Cells[rowNumber, 8] = item.SalesmanCode;

                    xlWorkSheet.Cells[rowNumber, 9] = item.Rayon;

                    xlWorkSheet.Cells[rowNumber, 10] = item.Representative;

                    xlWorkSheet.Cells[rowNumber, 11] = item.OutletType;

                    xlWorkSheet.Cells[rowNumber, 12] = item.ProductCode;

                    xlWorkSheet.Cells[rowNumber, 13] = item.ProductName;

                    xlWorkSheet.Cells[rowNumber, 14].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 14] = item.BatchCode;

                    xlWorkSheet.Cells[rowNumber, 15].NumberFormat = "dd/mm/yyyy;@";
                    xlWorkSheet.Cells[rowNumber, 15].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 15] = item.ExpiredDate;

                    xlWorkSheet.Cells[rowNumber, 16] = item.UomCode.ToString();

                    xlWorkSheet.Cells[rowNumber, 17].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 17] = qty;

                    xlWorkSheet.Cells[rowNumber, 18].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 18] = nettPrice;

                    xlWorkSheet.Cells[rowNumber, 19].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 19] = grossValue;

                    xlWorkSheet.Cells[rowNumber, 20].NumberFormat = "0,0%";
                    xlWorkSheet.Cells[rowNumber, 20] = discountPercent;

                    xlWorkSheet.Cells[rowNumber, 21].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 21] = propotionalExtraDiscount;

                    xlWorkSheet.Cells[rowNumber, 22].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 22] = totalDiscount;

                    xlWorkSheet.Cells[rowNumber, 23].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 23] = taxBaseAmount;

                    xlWorkSheet.Cells[rowNumber, 24].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 24] = valueAddedAmount;

                    xlWorkSheet.Cells[rowNumber, 25].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 25] = netValue;

                    xlWorkSheet.Cells[rowNumber, 26].NumberFormat = "dd/mm/yyyy;@";
                    xlWorkSheet.Cells[rowNumber, 26].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 26] = item.DueDate;

                    xlWorkSheet.Cells[rowNumber, 27] = item.DeliveryAddress;

                    xlWorkSheet.Cells[rowNumber, 28] = item.DeliveryDistrict;

                    xlWorkSheet.Cells[rowNumber, 29].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 29] = item.CustomerPhone;

                    xlWorkSheet.Cells[rowNumber, 30] = item.PrincipalName;

                    // progress bar
                    var progress = ((rowNumber - 1) * 100) / totalRecord;
                    backgroundWorker.ReportProgress(progress);

                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI", "UBICAPS"));
                var fileName = "REKAPITULASI FAKTUR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
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

        #region Research / Testing

        private DataTable ReadDataInvoiceRecap(DateTime fromDate, DateTime toDate)
        {
            var connString = ((ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings")).ConnectionStrings["DefaultConnection"].ConnectionString;

            DataTable recapData = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = $@"SELECT 
	                                SO.SalesDate, 
	                                SO.SalesNo,
	                                SO.CustomerId,
	                                CUST.CustomerCode,
	                                SO.CustomerName,
	                                SO.CustomerNpwp,
	                                SO.CustomerAddress,
	                                SO.CustomerDistrict,
	                                SO.CustomerProvince,
	                                SO.SalesmanCode,
	                                SO.SalesAreaId,
	                                SO.SalesAreaCode,
	                                SAR.Description Rayon,
	                                REP.Description Representative,
	                                OTL.Description OutletType,
	                                SOI.ProductId,
	                                SOI.ProductCode,
	                                SOI.ProductName,
	                                SOI.BatchCode,
	                                SOI.ExpiredDate,
	                                SOI.UomCode,
	                                SOI.Quantity,
	                                SOI.Price,
	                                SOI.TotalAmount,
	                                SOI.DiscountPercentage,
	                                SO.TaxBaseAmount,
	                                SO.ValueAddedTaxAmount,
	                                SO.ExtraDiscountAmount,
	                                SO.GrandTotalAmount,
	                                SO.DueDate,
	                                SO.DeliveryAddress,
	                                SO.DeliveryDistrict,
	                                CUST.Phone,
	                                PRI.PrincipalName
                                FROM SalesOrderItem SOI
                                JOIN SalesOrder SO ON SOI.SalesOrderId = SO.Id
                                JOIN Customer CUST ON SO.CustomerId = CUST.Id
                                JOIN OutletType OTL ON CUST.OutletTypeId = OTL.Id
                                JOIN Product PRD ON SOI.ProductId = PRD.Id
                                JOIN Principal PRI ON PRD.PrincipalId = PRI.Id
                                JOIN SalesArea SAR ON SO.SalesAreaId = SAR.Id
                                JOIN Representative REP ON SAR.RepresentativeId = REP.Id
                                WHERE SO.SalesDate >= @fromDate AND SO.SalesDate <= @toDate
                                    AND SO.Status = @recordStatus
                                ORDER BY SO.SalesNo";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fromDate", fromDate);
                    cmd.Parameters.AddWithValue("@toDate", toDate);
                    cmd.Parameters.AddWithValue("@recordStatus", Constant.RecordStatus.Active);

                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(recapData);
                    conn.Close();
                    da.Dispose();

                }
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
            }

            return recapData;
        }

        private void DoRecap()
        {
            try
            {
                var recapDetail = ReadDataInvoiceRecap(dtpFrom.Value, dtpTo.Value);

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
                xlWorkSheet.Cells[1, 22] = "TOTAL DISKON";
                xlWorkSheet.Cells[1, 23] = "DPP";
                xlWorkSheet.Cells[1, 24] = "PPN 10%";
                xlWorkSheet.Cells[1, 25] = "NETT VALUE";
                xlWorkSheet.Cells[1, 26] = "TGL.JTH TEMPO";
                xlWorkSheet.Cells[1, 27] = "ALAMAT KIRIM";
                xlWorkSheet.Cells[1, 28] = "KOTA";
                xlWorkSheet.Cells[1, 29] = "NO. TELPON";
                xlWorkSheet.Cells[1, 30] = "PRINCIPAL";

                var salesOrderHelper = new SalesOrderHelper();
                var rowNumber = 2; // Row number 1 is Header
                var totalRecord = recapDetail.Rows.Count;
                for (int i = 0; i < totalRecord; i++)
                {
                    var item = recapDetail.Rows[i];

                    var qty = Convert.ToInt32(item["Quantity"]);
                    var nettPrice = Convert.ToDecimal(item["Price"]);
                    var grossValue = salesOrderHelper.CalculateGrossValue(qty, nettPrice);
                    var discountPercent = Math.Round(Convert.ToDecimal(Convert.ToDecimal(item["DiscountPercentage"]) / 100), 4, MidpointRounding.AwayFromZero);
                    var extraDiscount = Convert.ToDecimal(item["ExtraDiscountAmount"]);
                    var totalDiscount = Math.Round(Convert.ToDecimal(grossValue * discountPercent), 4, MidpointRounding.AwayFromZero); ;

                    
                    // Set the Extra Discount proportionally
                    var sumOfGrossValue = recapDetail.AsEnumerable().Where(so => so.Field<String>("SalesNo") == item["SalesNo"].ToString())
                        .Sum(rc => (rc.Field<int>("Quantity") * rc.Field<Decimal>("Price")));
                    var propotionalExtraDiscount = (grossValue / sumOfGrossValue) * extraDiscount;

                    var taxBaseAmount = salesOrderHelper.CalculateTaxBaseAmount(qty, nettPrice, discountPercent, extraDiscount);
                    var valueAddedAmount = salesOrderHelper.CalculateValueAddedAmount(taxBaseAmount, DateTime.Parse(item["SalesDate"].ToString()));
                    var netValue = salesOrderHelper.CalculateNettValueAmount(taxBaseAmount, valueAddedAmount);

                    xlWorkSheet.Cells[rowNumber, 1].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 1] = DateTime.Parse(item["SalesDate"].ToString());

                    xlWorkSheet.Cells[rowNumber, 2] = item["SalesNo"].ToString().Trim();

                    xlWorkSheet.Cells[rowNumber, 3].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 3] = item["CustomerCode"].ToString().Trim();

                    xlWorkSheet.Cells[rowNumber, 4] = item["CustomerName"].ToString();

                    xlWorkSheet.Cells[rowNumber, 5].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 5] = item["CustomerNpwp"].ToString();

                    xlWorkSheet.Cells[rowNumber, 6] = item["CustomerAddress"].ToString();

                    xlWorkSheet.Cells[rowNumber, 7] = item["CustomerDistrict"].ToString();

                    xlWorkSheet.Cells[rowNumber, 8] = item["SalesmanCode"].ToString();

                    xlWorkSheet.Cells[rowNumber, 9] = item["Rayon"].ToString();

                    xlWorkSheet.Cells[rowNumber, 10] = item["Representative"].ToString();

                    xlWorkSheet.Cells[rowNumber, 11] = item["OutletType"].ToString();

                    xlWorkSheet.Cells[rowNumber, 12] = item["ProductCode"].ToString();

                    xlWorkSheet.Cells[rowNumber, 13] = item["ProductName"].ToString();

                    xlWorkSheet.Cells[rowNumber, 14].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 14] = item["BatchCode"].ToString();

                    xlWorkSheet.Cells[rowNumber, 15].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 15].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 15] = DateTime.Parse(item["ExpiredDate"].ToString()).ToString("MM/yyyy");

                    xlWorkSheet.Cells[rowNumber, 16] = item["UomCode"].ToString();

                    xlWorkSheet.Cells[rowNumber, 17].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 17] = qty;

                    xlWorkSheet.Cells[rowNumber, 18].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 18] = nettPrice;

                    xlWorkSheet.Cells[rowNumber, 19].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 19] = grossValue;

                    xlWorkSheet.Cells[rowNumber, 20].NumberFormat = "0,0%";
                    xlWorkSheet.Cells[rowNumber, 20] = discountPercent;

                    xlWorkSheet.Cells[rowNumber, 21].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 21] = propotionalExtraDiscount;

                    xlWorkSheet.Cells[rowNumber, 22].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 22] = totalDiscount;

                    xlWorkSheet.Cells[rowNumber, 23].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 24] = taxBaseAmount;

                    xlWorkSheet.Cells[rowNumber, 24].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 24] = valueAddedAmount;

                    xlWorkSheet.Cells[rowNumber, 25].NumberFormat = "#.##0";
                    xlWorkSheet.Cells[rowNumber, 25] = netValue;

                    xlWorkSheet.Cells[rowNumber, 26].NumberFormat = "dd/mm/yy;@";
                    xlWorkSheet.Cells[rowNumber, 26].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[rowNumber, 26] = DateTime.Parse(item["DueDate"].ToString());

                    xlWorkSheet.Cells[rowNumber, 27] = item["DeliveryAddress"].ToString();

                    xlWorkSheet.Cells[rowNumber, 28] = item["DeliveryDistrict"].ToString();

                    xlWorkSheet.Cells[rowNumber, 29].NumberFormat = "@";
                    xlWorkSheet.Cells[rowNumber, 29] = item["Phone"].ToString();

                    xlWorkSheet.Cells[rowNumber, 30] = item["PrincipalName"].ToString();

                    var progress = ((rowNumber - 1) * 100) / totalRecord;
                    backgroundWorker.ReportProgress(progress);
                    rowNumber++;
                }
                xlWorkSheet.Columns.AutoFit();
                var fileDir = Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "REKAPITULASI", "UBICAPS"));
                var fileName = "REKAPITULASI FAKTUR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
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

        #endregion
    }
}
