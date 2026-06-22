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
    public partial class FrmStockMovement : Form
    {
        CisDbContext dbContext;

        public FrmStockMovement()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmStockMovement_Load(object sender, EventArgs e)
        {
            dtpDateFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDateTo.Value = DateTime.Today;

            var types = new Dictionary<string, string>
            {
                { "ALL",                              "-- Semua Tipe --" },
                { StockMovementType.PurchaseReceipt.ToString(), "Purchase Receipt" },
                { StockMovementType.SalesOut.ToString(),         "Sales Out" },
                { StockMovementType.PurchaseReturn.ToString(),  "Purchase Return" },
                { StockMovementType.SalesReturn.ToString(),     "Sales Return" },
                { StockMovementType.AdjustmentIn.ToString(),    "Adjustment In" },
                { StockMovementType.AdjustmentOut.ToString(),   "Adjustment Out" },
                { StockMovementType.TransferOut.ToString(),     "Transfer Out" },
                { StockMovementType.TransferIn.ToString(),      "Transfer In" },
                { StockMovementType.OpeningStock.ToString(),    "Opening Stock" }
            };
            cbMovementType.DataSource = new System.Windows.Forms.BindingSource(types, null);
            cbMovementType.DisplayMember = "Value";
            cbMovementType.ValueMember = "Key";
            cbMovementType.SelectedValue = "ALL";

            LoadData();
        }

        private List<StockMovementReportRow> GetData()
        {
            var from = dtpDateFrom.Value.Date;
            var to = dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1);
            var search = txtSearch.Text.Trim().ToLower();
            var typeFilter = cbMovementType.SelectedValue?.ToString();

            var query = new UnitOfWork<StockMovement>(dbContext).Repository.GetAll()
                .Where(m => m.MovementDate >= from && m.MovementDate <= to);

            if (!string.IsNullOrEmpty(typeFilter) && typeFilter != "ALL")
            {
                var type = (StockMovementType)Enum.Parse(typeof(StockMovementType), typeFilter);
                query = query.Where(m => m.MovementType == type);
            }

            var rows = query.OrderBy(m => m.MovementDate)
                            .ThenBy(m => m.ProductCode)
                            .AsEnumerable()
                            .Select((m, i) => new StockMovementReportRow
                            {
                                No = i + 1,
                                MovementDate = m.MovementDate,
                                MovementDateStr = m.MovementDate.ToString("dd/MM/yyyy"),
                                MovementType = m.MovementType.ToString(),
                                MovementTypeLabel = MovementTypeLabel(m.MovementType),
                                Direction = m.Direction.ToString(),
                                ProductCode = m.ProductCode,
                                ProductName = m.ProductName,
                                BatchCode = m.BatchCode ?? string.Empty,
                                Remarks = m.Remarks ?? string.Empty,
                                QtyIn = m.Direction == MovementDirection.In ? m.Qty : 0,
                                QtyOut = m.Direction == MovementDirection.Out ? m.Qty : 0,
                                QtyInStr = m.Direction == MovementDirection.In ? string.Format("{0:n0}", m.Qty) : string.Empty,
                                QtyOutStr = m.Direction == MovementDirection.Out ? string.Format("{0:n0}", m.Qty) : string.Empty
                            });

            if (!string.IsNullOrEmpty(search))
                rows = rows.Where(r => r.ProductCode.ToLower().Contains(search)
                                    || r.ProductName.ToLower().Contains(search)
                                    || r.BatchCode.ToLower().Contains(search)
                                    || r.Remarks.ToLower().Contains(search));

            return rows.ToList();
        }

        private string MovementTypeLabel(StockMovementType t)
        {
            switch (t)
            {
                case StockMovementType.PurchaseReceipt: return "Purchase Receipt";
                case StockMovementType.SalesOut:        return "Sales Out";
                case StockMovementType.PurchaseReturn:  return "Purchase Return";
                case StockMovementType.SalesReturn:     return "Sales Return";
                case StockMovementType.AdjustmentIn:    return "Adjustment In";
                case StockMovementType.AdjustmentOut:   return "Adjustment Out";
                case StockMovementType.TransferOut:     return "Transfer Out";
                case StockMovementType.TransferIn:      return "Transfer In";
                case StockMovementType.OpeningStock:    return "Opening Stock";
                default:                                return t.ToString();
            }
        }

        private void LoadData()
        {
            var data = GetData();

            dgvMovement.Rows.Clear();
            foreach (var row in data)
            {
                int r = dgvMovement.Rows.Add();
                var dr = dgvMovement.Rows[r];
                dr.Cells["colNo"].Value = row.No;
                dr.Cells["colDate"].Value = row.MovementDateStr;
                dr.Cells["colType"].Value = row.MovementTypeLabel;
                dr.Cells["colProductCode"].Value = row.ProductCode;
                dr.Cells["colProductName"].Value = row.ProductName;
                dr.Cells["colBatchCode"].Value = row.BatchCode;
                dr.Cells["colRemarks"].Value = row.Remarks;
                dr.Cells["colQtyIn"].Value = row.QtyInStr;
                dr.Cells["colQtyOut"].Value = row.QtyOutStr;

                if (row.Direction == MovementDirection.In.ToString())
                    dr.Cells["colQtyIn"].Style.ForeColor = Color.FromArgb(59, 109, 17);
                else
                    dr.Cells["colQtyOut"].Style.ForeColor = Color.FromArgb(163, 45, 45);
            }

            var totalIn = data.Sum(r => r.QtyIn);
            var totalOut = data.Sum(r => r.QtyOut);
            lblTotal.Text = $"Total: {data.Count} baris  |  Total Masuk: {totalIn:n0}  |  Total Keluar: {totalOut:n0}";
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var data = GetData();
            if (data.Count == 0)
            { MessageBox.Show("Tidak ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var viewer = new FrmRptStockMovementViewer();
            viewer.ReportData = data;
            viewer.PrintDate = DateTime.Now;
            viewer.DateFrom = dtpDateFrom.Value;
            viewer.DateTo = dtpDateTo.Value;
            viewer.TypeFilter = cbMovementType.SelectedItem is System.Collections.Generic.KeyValuePair<string, string> kv ? kv.Value : "Semua Tipe";
            viewer.SearchFilter = txtSearch.Text.Trim();
            viewer.Show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; LoadData(); }
        }
    }

    public class StockMovementReportRow
    {
        public int No { get; set; }
        public DateTime MovementDate { get; set; }
        public string MovementDateStr { get; set; }
        public string MovementType { get; set; }
        public string MovementTypeLabel { get; set; }
        public string Direction { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchCode { get; set; }
        public string Remarks { get; set; }
        public decimal QtyIn { get; set; }
        public decimal QtyOut { get; set; }
        public string QtyInStr { get; set; }
        public string QtyOutStr { get; set; }
    }
}
