using Cis.Data;
using Cis.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmStockCard : Form
    {
        CisDbContext dbContext;

        public FrmStockCard()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmStockCard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private List<StockCardReportRow> GetData()
        {
            var cards = new UnitOfWork<StockCard>(dbContext).Repository.GetAll();
            var batches = new UnitOfWork<Batch>(dbContext).Repository.GetAll();
            var products = new UnitOfWork<Product>(dbContext).Repository.GetAll();
            var uoms = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetAll();

            var search = txtSearch.Text.Trim().ToLower();

            var rows = (from sc in cards
                        join p in products on sc.ProductId equals p.Id
                        join u in uoms on p.UnitId equals u.Id into uomJoin
                        from u in uomJoin.DefaultIfEmpty()
                        join b in batches on sc.BatchId equals b.Id into batchJoin
                        from b in batchJoin.DefaultIfEmpty()
                        select new StockCardReportRow
                        {
                            ProductCode = sc.ProductCode,
                            ProductName = sc.ProductName,
                            BatchCode = sc.BatchCode ?? string.Empty,
                            ExpiredDate = b != null ? b.ExpiredDate : (DateTime?)null,
                            UomCode = u != null ? u.UomCode : string.Empty,
                            QtyOnHand = sc.QtyOnHand,
                            QtyReserved = sc.QtyReserved,
                            QtyAvailable = sc.QtyOnHand - sc.QtyReserved
                        }).AsEnumerable();

            if (!string.IsNullOrEmpty(search))
                rows = rows.Where(r => r.ProductCode.ToLower().Contains(search)
                                    || r.ProductName.ToLower().Contains(search)
                                    || r.BatchCode.ToLower().Contains(search));

            if (chkHideZero.Checked)
                rows = rows.Where(r => r.QtyOnHand != 0);

            return rows.OrderBy(r => r.ProductCode).ThenBy(r => r.BatchCode).ToList();
        }

        private void LoadData()
        {
            var data = GetData();

            dgvStock.Rows.Clear();
            int no = 1;
            foreach (var row in data)
            {
                int r = dgvStock.Rows.Add();
                var dr = dgvStock.Rows[r];
                dr.Cells["colNo"].Value = no++;
                dr.Cells["colProductCode"].Value = row.ProductCode;
                dr.Cells["colProductName"].Value = row.ProductName;
                dr.Cells["colBatchCode"].Value = row.BatchCode;
                dr.Cells["colExpDate"].Value = row.ExpiredDate.HasValue ? row.ExpiredDate.Value.ToString("dd/MM/yyyy") : string.Empty;
                dr.Cells["colUomCode"].Value = row.UomCode;
                dr.Cells["colQtyOnHand"].Value = string.Format("{0:n0}", row.QtyOnHand);
                dr.Cells["colQtyReserved"].Value = string.Format("{0:n0}", row.QtyReserved);
                dr.Cells["colQtyAvailable"].Value = string.Format("{0:n0}", row.QtyAvailable);

                if (row.QtyOnHand < 0)
                    dr.DefaultCellStyle.ForeColor = Color.FromArgb(163, 45, 45);
                else if (row.QtyOnHand == 0)
                    dr.DefaultCellStyle.ForeColor = Color.FromArgb(133, 79, 11);
            }

            lblTotal.Text = $"Total: {data.Count} baris  |  " +
                            $"Stok Negatif: {data.Count(r => r.QtyOnHand < 0)}  |  " +
                            $"Stok Habis: {data.Count(r => r.QtyOnHand == 0)}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var data = GetData();
            if (data.Count == 0)
            { MessageBox.Show("Tidak ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var viewer = new FrmRptStockCardViewer();
            viewer.ReportData = data;
            viewer.PrintDate = DateTime.Now;
            viewer.SearchFilter = txtSearch.Text.Trim();
            viewer.Show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; LoadData(); }
        }

        private void chkHideZero_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }

    public class StockCardReportRow
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchCode { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string UomCode { get; set; }
        public decimal QtyOnHand { get; set; }
        public decimal QtyReserved { get; set; }
        public decimal QtyAvailable { get; set; }

        public string ExpiredDateStr => ExpiredDate.HasValue ? ExpiredDate.Value.ToString("dd/MM/yyyy") : string.Empty;
        public string QtyOnHandStr => string.Format("{0:n0}", QtyOnHand);
        public string QtyReservedStr => string.Format("{0:n0}", QtyReserved);
        public string QtyAvailableStr => string.Format("{0:n0}", QtyAvailable);
    }
}
