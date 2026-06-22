using Cis.Business;
using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmStockOpname : Form
    {
        CisDbContext dbContext;
        UnitOfWork<StockOpname> _uow;
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation { First, Previous, Next, Last }

        #region helpers

        private string CreateOpnameNumber()
        {
            var last = _uow.Repository.GetAll()
                .Where(e => e.OpnameDate.Month == dtpOpnameDate.Value.Month
                         && e.OpnameDate.Year == dtpOpnameDate.Value.Year)
                .OrderByDescending(s => s.OpnameNumber).FirstOrDefault();

            var yy = dtpOpnameDate.Value.Year.ToString().Substring(2);
            var mm = dtpOpnameDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}OPN-{mm}0001";
            var seq = Convert.ToInt64(last.OpnameNumber.Substring(last.OpnameNumber.Length - 4));
            return $"{yy}OPN-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private string CreateAdjustmentNumber()
        {
            var last = new UnitOfWork<StockAdjustment>(dbContext).Repository.GetAll()
                .Where(e => e.AdjustmentDate.Month == dtpOpnameDate.Value.Month
                         && e.AdjustmentDate.Year == dtpOpnameDate.Value.Year)
                .OrderByDescending(s => s.AdjustmentNumber).FirstOrDefault();

            var yy = dtpOpnameDate.Value.Year.ToString().Substring(2);
            var mm = dtpOpnameDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}ADJ-{mm}0001";
            var seq = Convert.ToInt64(last.AdjustmentNumber.Substring(last.AdjustmentNumber.Length - 4));
            return $"{yy}ADJ-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private void LoadDataItem(StockOpname op)
        {
            lblOpnameNumber.Text = op.OpnameNumber;
            dtpOpnameDate.Value = op.OpnameDate;
            cbOpnameType.SelectedValue = (int)op.OpnameType;
            txtNotes.Text = op.Notes ?? string.Empty;
            lblStatus.Text = op.PostingStatus.ToString();
            lblStatus.ForeColor = StatusColor(op.PostingStatus);

            txtOpnameId.Text = op.Id;
            txtModifiedAt.Text = op.ModifiedAt.ToString();

            var items = new UnitOfWork<StockOpnameItem>(dbContext).Repository.GetAll()
                .Where(i => i.StockOpnameId == op.Id).OrderBy(i => i.ProductCode);

            dgvItems.Rows.Clear();
            foreach (var item in items)
            {
                int r = dgvItems.Rows.Add();
                var row = dgvItems.Rows[r];
                row.Cells["colProductId"].Value = item.ProductId;
                row.Cells["colBatchId"].Value = item.BatchId ?? string.Empty;
                row.Cells["colUomId"].Value = item.UomId;
                row.Cells["colProductCode"].Value = item.ProductCode;
                row.Cells["colProductName"].Value = item.ProductName;
                row.Cells["colBatchCode"].Value = item.BatchCode ?? string.Empty;
                row.Cells["colUomCode"].Value = item.UomCode;
                row.Cells["colQtySystem"].Value = item.QtySystem;
                row.Cells["colQtyPhysical"].Value = item.QtyPhysical;
                row.Cells["colDifference"].Value = item.Difference;
                SetDifferenceColor(row, item.Difference);
            }

            SetUIByStatus(op.PostingStatus);
        }

        private void SetDifferenceColor(DataGridViewRow row, decimal difference)
        {
            var cell = row.Cells["colDifference"];
            if (difference > 0) cell.Style.ForeColor = Color.FromArgb(16, 124, 16);
            else if (difference < 0) cell.Style.ForeColor = Color.FromArgb(196, 43, 28);
            else cell.Style.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private Color StatusColor(PostingStatus s)
        {
            switch (s)
            {
                case PostingStatus.Posted: return Color.FromArgb(16, 124, 16);
                default: return Color.FromArgb(64, 64, 64);
            }
        }

        private void SetUIByStatus(PostingStatus status)
        {
            bool isDraft = status == PostingStatus.Draft;

            gbHeader.Enabled = isDraft;
            btnLoadProducts.Enabled = isDraft;
            dgvItems.ReadOnly = !isDraft;
            dgvItems.DefaultCellStyle.BackColor = isDraft ? Color.White : Color.FromArgb(240, 240, 240);

            btnSave.Enabled = isDraft;
            btnDel.Enabled = isDraft;
            btnPost.Enabled = isDraft;

            btnSave.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnPost.BackColor = isDraft ? Color.FromArgb(16, 124, 16) : Color.Gray;
        }

        private void SetUIButtonGroup()
        {
            bool hasRecord = !string.IsNullOrEmpty(lblOpnameNumber.Text);
            btnAdd.Enabled = !hasRecord;
            btnSave.Enabled = hasRecord;
            btnDel.Enabled = hasRecord;
            btnPost.Enabled = hasRecord;
            btnLoadProducts.Enabled = hasRecord;

            btnAdd.BackColor = !hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnSave.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnPost.BackColor = hasRecord ? Color.FromArgb(16, 124, 16) : Color.Gray;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            var all = _uow.Repository.GetAll();
            StockOpname result = null;
            var current = lblOpnameNumber.Text;

            switch (nav)
            {
                case RecordNavigation.First: result = all.OrderBy(p => p.OpnameNumber).FirstOrDefault(); break;
                case RecordNavigation.Last:  result = all.OrderByDescending(p => p.OpnameNumber).FirstOrDefault(); break;
                case RecordNavigation.Previous:
                    result = string.IsNullOrEmpty(current) ? all.OrderBy(p => p.OpnameNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.OpnameNumber, current) < 0).OrderByDescending(p => p.OpnameNumber).FirstOrDefault();
                    break;
                case RecordNavigation.Next:
                    result = string.IsNullOrEmpty(current) ? all.OrderByDescending(p => p.OpnameNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.OpnameNumber, current) > 0).OrderBy(p => p.OpnameNumber).FirstOrDefault();
                    break;
                default: return;
            }

            if (result != null) LoadDataItem(result);
            SetUIButtonGroup();
        }

        private List<StockOpnameItem> GetItemsFromGrid(string opnameId)
        {
            var items = new List<StockOpnameItem>();
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;

                decimal qtyPhysical = 0;
                decimal.TryParse(dgvItems.Rows[i].Cells["colQtyPhysical"].Value?.ToString(), out qtyPhysical);
                decimal qtySystem = 0;
                decimal.TryParse(dgvItems.Rows[i].Cells["colQtySystem"].Value?.ToString(), out qtySystem);

                items.Add(new StockOpnameItem
                {
                    StockOpnameId = opnameId,
                    ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                    ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                    ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                    BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                    BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                    UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                    UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                    QtySystem = qtySystem,
                    QtyPhysical = qtyPhysical,
                    Difference = qtyPhysical - qtySystem,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                });
            }
            return items;
        }

        #endregion

        public FrmStockOpname()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmStockOpname_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<StockOpname>(dbContext);

            var types = new Dictionary<int, string>
            {
                { (int)StockOpnameType.PhysicalCount, "Physical Count" },
                { (int)StockOpnameType.OpeningStock,  "Opening Stock" }
            };
            cbOpnameType.DataSource = new System.Windows.Forms.BindingSource(types, null);
            cbOpnameType.DisplayMember = "Value";
            cbOpnameType.ValueMember = "Key";

            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpnameId.Text))
            { MessageBox.Show("Simpan header opname terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var opnameType = (StockOpnameType)(int)cbOpnameType.SelectedValue;
            var confirmMsg = opnameType == StockOpnameType.OpeningStock
                ? "Load semua produk aktif sebagai Opening Stock?\nQty System akan 0. Isi Qty Fisik sesuai stok awal.\nData item yang sudah ada akan di-reset."
                : "Load semua produk dari Stock Card?\nData item yang sudah ada akan di-reset.";

            if (MessageBox.Show(confirmMsg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var uoms = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetAll().ToList();
            var products = new UnitOfWork<Product>(dbContext).Repository.GetAll()
                .OrderBy(p => p.ProductCode).ToList();

            dgvItems.Rows.Clear();

            var cards = new UnitOfWork<StockCard>(dbContext).Repository.GetAll().ToList();

            foreach (var prod in products)
            {
                var uom = uoms.FirstOrDefault(u => u.Id == prod.UnitId);
                var card = cards.FirstOrDefault(c => c.ProductId == prod.Id && string.IsNullOrEmpty(c.BatchId));
                var qtySystem = opnameType == StockOpnameType.OpeningStock ? 0m : (card?.QtyOnHand ?? 0m);

                int r = dgvItems.Rows.Add();
                var row = dgvItems.Rows[r];
                row.Cells["colProductId"].Value = prod.Id;
                row.Cells["colBatchId"].Value = string.Empty;
                row.Cells["colUomId"].Value = uom?.Id ?? string.Empty;
                row.Cells["colProductCode"].Value = prod.ProductCode;
                row.Cells["colProductName"].Value = prod.ProductName;
                row.Cells["colBatchCode"].Value = string.Empty;
                row.Cells["colUomCode"].Value = uom?.UomCode ?? string.Empty;
                row.Cells["colQtySystem"].Value = qtySystem;
                row.Cells["colQtyPhysical"].Value = 0m;
                row.Cells["colDifference"].Value = -qtySystem;
                SetDifferenceColor(row, -qtySystem);
            }

            lblItemCount.Text = $"{dgvItems.Rows.Count} item dimuat";
        }

        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvItems.Columns[e.ColumnIndex].Name != "colQtyPhysical") return;

            var row = dgvItems.Rows[e.RowIndex];
            decimal qtySystem = 0;
            decimal.TryParse(row.Cells["colQtySystem"].Value?.ToString(), out qtySystem);
            decimal qtyPhysical = 0;
            decimal.TryParse(row.Cells["colQtyPhysical"].Value?.ToString(), out qtyPhysical);

            var diff = qtyPhysical - qtySystem;
            row.Cells["colDifference"].Value = diff;
            SetDifferenceColor(row, diff);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var tx = dbContext.Database.BeginTransaction())
            {
                var op = new StockOpname
                {
                    OpnameNumber = CreateOpnameNumber(),
                    OpnameDate = dtpOpnameDate.Value,
                    OpnameType = (StockOpnameType)(int)cbOpnameType.SelectedValue,
                    Notes = txtNotes.Text.Trim(),
                    PostingStatus = PostingStatus.Draft,
                    UserId = Properties.Settings.Default.CurrentUserId,
                    Username = Properties.Settings.Default.CurrentUser,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };

                _uow.Repository.Add(op);
                var res = _uow.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                tx.Commit();
                lblOpnameNumber.Text = op.OpnameNumber;
                txtOpnameId.Text = op.Id;
                txtModifiedAt.Text = op.ModifiedAt.ToString();
            }

            SetUIButtonGroup();
            SetUIByStatus(PostingStatus.Draft);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Load produk terlebih dahulu sebelum menyimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var repoLastUpdated = _uow.Repository.GetById(txtOpnameId.Text.Trim()).ModifiedAt;
            if (commonHelper.StandardizeDateTime(DateTime.Parse(txtModifiedAt.Text)) != commonHelper.StandardizeDateTime(repoLastUpdated))
            { CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblOpnameNumber.Text); return; }

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var op = _uow.Repository.GetById(txtOpnameId.Text.Trim());
                op.OpnameDate = dtpOpnameDate.Value;
                op.OpnameType = (StockOpnameType)(int)cbOpnameType.SelectedValue;
                op.Notes = txtNotes.Text.Trim();
                op.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                op.ModifiedAt = DateTime.Now;
                _uow.Repository.Update(op);
                _uow.Commit();

                var uwItem = new UnitOfWork<StockOpnameItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockOpnameId == op.Id));
                uwItem.Commit();

                foreach (var item in GetItemsFromGrid(op.Id))
                    uwItem.Repository.Add(item);
                uwItem.Commit();

                tx.Commit();
                txtModifiedAt.Text = op.ModifiedAt.ToString();
            }

            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var op = _uow.Repository.GetById(txtOpnameId.Text.Trim());
            if (op == null) { CommonMessageHelper.DataNotFound(lblOpnameNumber.Text); return; }
            if (op.PostingStatus != PostingStatus.Draft)
            { MessageBox.Show("Hanya Opname dengan status Draft yang dapat dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<StockOpnameItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockOpnameId == op.Id));
                uwItem.Commit();
                _uow.Repository.Delete(op);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Tidak ada item untuk diposting.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            // Save latest physical counts first
            btnSave_Click(sender, e);

            var diffCount = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                decimal diff = 0;
                decimal.TryParse(dgvItems.Rows[i].Cells["colDifference"].Value?.ToString(), out diff);
                if (diff != 0) diffCount++;
            }

            var msg = diffCount > 0
                ? $"Post Stock Opname {lblOpnameNumber.Text}?\n{diffCount} item memiliki selisih dan akan di-adjust otomatis."
                : $"Post Stock Opname {lblOpnameNumber.Text}?\nSemua item sesuai — tidak ada adjustment yang dibuat.";

            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var adjNumber = CreateAdjustmentNumber();
            var svc = new StockService(dbContext);
            var (ok, errMsg) = svc.PostStockOpname(txtOpnameId.Text.Trim(), adjNumber, Properties.Settings.Default.CurrentUserId);

            if (ok)
            {
                NavigateRecord(RecordNavigation.Last);
                var resultMsg = diffCount > 0
                    ? $"Opname berhasil diposting.\nStockAdjustment {adjNumber} telah dibuat otomatis untuk {diffCount} item."
                    : "Opname berhasil diposting. Tidak ada selisih stok.";
                MessageBox.Show(resultMsg, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errMsg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOpnameNumber.Text = string.Empty;
            dtpOpnameDate.Value = DateTime.Today;
            if (cbOpnameType.Items.Count > 0) cbOpnameType.SelectedIndex = 0;
            txtNotes.Text = string.Empty;
            lblStatus.Text = string.Empty;
            lblItemCount.Text = string.Empty;
            txtOpnameId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            dgvItems.Rows.Clear();
            SetUIButtonGroup();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpnameId.Text)) return;
            var op = _uow.Repository.GetById(txtOpnameId.Text.Trim());
            if (op != null) LoadDataItem(op);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var op = _uow.Repository.GetAll().Where(p => p.OpnameNumber == q).FirstOrDefault();
            if (op != null) LoadDataItem(op);
            else CommonMessageHelper.DataNotFound(q);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; btnSearch_Click(sender, e); }
        }
    }
}
