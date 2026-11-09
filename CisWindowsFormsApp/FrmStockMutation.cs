using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    // Per-product stock mutation summary: opening balance, incoming block, outgoing block, closing balance.
    public partial class FrmStockMutation : Form
    {
        CisDbContext dbContext;

        public FrmStockMutation()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
            BuildColumns();
        }

        private void BuildColumns()
        {
            AddColumn("colCode", "Kode Barang", 80, false);
            AddColumn("colName", "Nama Barang", 220, false);
            AddColumn("colUom", "SAT", 45, false);
            AddColumn("colOpening", "Saldo Awal", 75, true);
            AddColumn("colPurchase", "Pembelian", 75, true);
            AddColumn("colAdjIn", "Adjustment (+)", 80, true);
            AddColumn("colPurchaseReturn", "Retur Pembelian", 80, true);
            AddColumn("colTransferIn", "Mutasi (+)", 75, true);
            AddColumn("colTotalIn", "Total +", 80, true, Color.FromArgb(255, 242, 204));
            AddColumn("colSales", "Penjualan", 75, true);
            AddColumn("colAdjOut", "Adjustment (-)", 80, true);
            AddColumn("colSalesReturn", "Retur Penjualan", 80, true);
            AddColumn("colTransferOut", "Mutasi (-)", 75, true);
            AddColumn("colTotalOut", "Total -", 80, true, Color.FromArgb(255, 242, 204));
            AddColumn("colClosing", "Saldo Akhir", 85, true);
        }

        private void AddColumn(string name, string header, int width, bool numeric, Color? back = null)
        {
            var col = new DataGridViewTextBoxColumn { Name = name, HeaderText = header, Width = width, ReadOnly = true };
            if (numeric) col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (back.HasValue) col.DefaultCellStyle.BackColor = back.Value;
            col.HeaderCell.Style.Alignment = numeric ? DataGridViewContentAlignment.MiddleRight : DataGridViewContentAlignment.MiddleLeft;
            dgvMutation.Columns.Add(col);
        }

        private void FrmStockMutation_Load(object sender, EventArgs e)
        {
            dtpDateFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDateTo.Value = DateTime.Today;
            LoadData();
        }

        private static string Fmt(int v) => v == 0 ? "-" : string.Format("{0:n0}", v);

        private List<StockMutationReportRow> GetData()
        {
            var from = dtpDateFrom.Value.Date;
            var to = dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1);
            var search = txtSearch.Text.Trim().ToLower();

            var movements = new UnitOfWork<StockMovement>(dbContext).Repository.GetAll()
                .Where(m => m.MovementDate <= to)
                .Select(m => new MovementLite { ProductId = m.ProductId, Date = m.MovementDate, Type = m.MovementType, Direction = m.Direction, Qty = m.Qty })
                .ToList();
            var byProduct = movements.GroupBy(m => m.ProductId).ToDictionary(g => g.Key, g => g.ToList());

            var products = new UnitOfWork<Product>(dbContext).Repository.GetAll()
                .OrderBy(p => p.ProductCode)
                .Select(p => new { p.Id, p.ProductCode, p.ProductName, p.UnitId })
                .ToList();
            var uoms = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetAll()
                .ToDictionary(u => u.Id, u => u.UomCode);

            var rows = new List<StockMutationReportRow>();
            foreach (var p in products)
            {
                if (!string.IsNullOrEmpty(search)
                    && !p.ProductCode.ToLower().Contains(search) && !p.ProductName.ToLower().Contains(search))
                    continue;

                var all = byProduct.TryGetValue(p.Id, out var list) ? list : new List<MovementLite>();
                var before = all.Where(m => m.Date < from);
                var period = all.Where(m => m.Date >= from).ToList();

                int opening = before.Sum(m => m.Signed);

                // Net per type in the period (In - Out), so cancellations/reversals net out correctly.
                int purchase = Net(period, StockMovementType.PurchaseReceipt);
                int adjIn = Net(period, StockMovementType.AdjustmentIn) + Net(period, StockMovementType.OpeningStock);
                int purchaseReturn = Net(period, StockMovementType.PurchaseReturn);   // negative when goods are returned
                int transferIn = Net(period, StockMovementType.TransferIn);
                int totalIn = opening + purchase + adjIn + purchaseReturn + transferIn;

                int sales = -Net(period, StockMovementType.SalesOut);
                int adjOut = -Net(period, StockMovementType.AdjustmentOut);
                int salesReturn = -Net(period, StockMovementType.SalesReturn);        // negative when goods come back
                int transferOut = -Net(period, StockMovementType.TransferOut);
                int totalOut = sales + adjOut + salesReturn + transferOut;

                rows.Add(new StockMutationReportRow
                {
                    ProductCode = p.ProductCode,
                    ProductName = p.ProductName,
                    Uom = uoms.TryGetValue(p.UnitId, out var u) ? u : string.Empty,
                    OpeningStr = Fmt(opening),
                    PurchaseStr = Fmt(purchase),
                    AdjInStr = Fmt(adjIn),
                    PurchaseReturnStr = Fmt(purchaseReturn),
                    TransferInStr = Fmt(transferIn),
                    TotalInStr = Fmt(totalIn),
                    SalesStr = Fmt(sales),
                    AdjOutStr = Fmt(adjOut),
                    SalesReturnStr = Fmt(salesReturn),
                    TransferOutStr = Fmt(transferOut),
                    TotalOutStr = Fmt(totalOut),
                    ClosingStr = Fmt(totalIn - totalOut)
                });
            }
            return rows;
        }

        private static int Net(List<MovementLite> list, StockMovementType type)
            => list.Where(m => m.Type == type).Sum(m => m.Signed);

        private void LoadData()
        {
            var data = GetData();
            dgvMutation.Rows.Clear();
            foreach (var r in data)
            {
                dgvMutation.Rows.Add(r.ProductCode, r.ProductName, r.Uom, r.OpeningStr, r.PurchaseStr, r.AdjInStr,
                    r.PurchaseReturnStr, r.TransferInStr, r.TotalInStr, r.SalesStr, r.AdjOutStr,
                    r.SalesReturnStr, r.TransferOutStr, r.TotalOutStr, r.ClosingStr);
            }
            lblTotal.Text = $"Total: {data.Count} barang";
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var data = GetData();
            if (data.Count == 0)
            { MessageBox.Show("Tidak ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var viewer = new FrmRptStockMutationViewer
            {
                ReportData = data,
                PrintDate = DateTime.Now,
                DateFrom = dtpDateFrom.Value,
                DateTo = dtpDateTo.Value,
                SearchFilter = txtSearch.Text.Trim()
            };
            viewer.Show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; LoadData(); }
        }

        private class MovementLite
        {
            public string ProductId { get; set; }
            public DateTime Date { get; set; }
            public StockMovementType Type { get; set; }
            public MovementDirection Direction { get; set; }
            public int Qty { get; set; }
            public int Signed => Direction == MovementDirection.In ? Qty : -Qty;
        }
    }

    public class StockMutationReportRow
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Uom { get; set; }
        public string OpeningStr { get; set; }
        public string PurchaseStr { get; set; }
        public string AdjInStr { get; set; }
        public string PurchaseReturnStr { get; set; }
        public string TransferInStr { get; set; }
        public string TotalInStr { get; set; }
        public string SalesStr { get; set; }
        public string AdjOutStr { get; set; }
        public string SalesReturnStr { get; set; }
        public string TransferOutStr { get; set; }
        public string TotalOutStr { get; set; }
        public string ClosingStr { get; set; }
    }
}
