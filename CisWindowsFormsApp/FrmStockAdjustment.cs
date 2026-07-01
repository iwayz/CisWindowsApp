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
    public partial class FrmStockAdjustment : Form
    {
        CisDbContext dbContext;
        UnitOfWork<StockAdjustment> _uow;
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation { First, Previous, Next, Last }

        #region helpers

        private void BindComboBoxProduct()
        {
            var list = new UnitOfWork<Product>(dbContext).Repository.GetAll().OrderBy(e => e.ProductCode);
            var ds = new Dictionary<string, string> { { "0", "--Pilih Barang--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var p in list)
            {
                ds.Add(p.Id, p.ProductCode + " - " + p.ProductName);
                ac.Add(p.ProductCode + " - " + p.ProductName);
            }
            cbProduct.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbProduct.DisplayMember = "Value";
            cbProduct.ValueMember = "Key";
            cbProduct.AutoCompleteCustomSource = ac;
        }

        private void BindComboBoxBatch(string productId)
        {
            var list = new UnitOfWork<StockCard>(dbContext).Repository.GetAll()
                .Where(s => s.ProductId == productId && s.QtyOnHand > 0)
                .OrderBy(s => s.BatchCode);
            var ds = new Dictionary<string, string> { { "0", "--Pilih Batch--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var s in list)
            {
                var key = s.BatchId ?? string.Empty;
                var val = string.IsNullOrEmpty(s.BatchCode) ? "(no batch)" : s.BatchCode;
                if (!ds.ContainsKey(key)) { ds.Add(key, val); ac.Add(val); }
            }
            cbBatch.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbBatch.DisplayMember = "Value";
            cbBatch.ValueMember = "Key";
            cbBatch.AutoCompleteCustomSource = ac;
        }

        private string CreateAdjustmentNumber()
        {
            var last = _uow.Repository.GetAll()
                .Where(e => e.AdjustmentDate.Month == dtpAdjDate.Value.Month
                         && e.AdjustmentDate.Year == dtpAdjDate.Value.Year)
                .OrderByDescending(s => s.AdjustmentNumber).FirstOrDefault();

            var prefix = new UnitOfWork<CompanyInfo>(dbContext).Repository.GetAll()
                .FirstOrDefault(e => e.Key == "StockAdjustmentPrefix")?.Value ?? "ADJ";

            var yy = dtpAdjDate.Value.Year.ToString().Substring(2);
            var mm = dtpAdjDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}{prefix}-{mm}0001";
            var seq = Convert.ToInt64(last.AdjustmentNumber.Substring(last.AdjustmentNumber.Length - 4));
            return $"{yy}{prefix}-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private int GetCurrentStock(string productId, string batchId)
        {
            var card = new UnitOfWork<StockCard>(dbContext).Repository.GetAll()
                .Where(s => s.ProductId == productId && s.BatchId == batchId)
                .FirstOrDefault();
            return card?.QtyOnHand ?? 0;
        }

        private void LoadDataItem(StockAdjustment adj)
        {
            lblAdjNumber.Text = adj.AdjustmentNumber;
            dtpAdjDate.Value = adj.AdjustmentDate;
            cbReason.SelectedValue = (int)adj.Reason;
            txtNotes.Text = adj.Notes ?? string.Empty;
            lblStatus.Text = adj.PostingStatus.ToString().ToUpper();
            lblStatus.ForeColor = StatusColor(adj.PostingStatus);

            txtAdjId.Text = adj.Id;
            txtModifiedAt.Text = adj.ModifiedAt.ToString();

            var items = new UnitOfWork<StockAdjustmentItem>(dbContext).Repository.GetAll()
                .Where(i => i.StockAdjustmentId == adj.Id).OrderBy(i => i.ProductCode);

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
                row.Cells["colQtyBefore"].Value = string.Format("{0:n0}", item.QtyBefore);
                row.Cells["colDirection"].Value = item.Direction.ToString();
                row.Cells["colQtyAdj"].Value = string.Format("{0:n0}", item.QtyAdjustment);
                row.Cells["colQtyAfter"].Value = string.Format("{0:n0}", item.QtyAfter);
            }

            SetUIByStatus(adj.PostingStatus);
        }

        private Color StatusColor(PostingStatus s)
        {
            switch (s)
            {
                case PostingStatus.Posted: return Color.FromArgb(16, 124, 16);
                case PostingStatus.Cancelled: return Color.Gray;
                default: return Color.FromArgb(64, 64, 64);
            }
        }

        private void SetUIByStatus(PostingStatus status)
        {
            bool isDraft = status == PostingStatus.Draft;

            pnlHeader.Enabled = isDraft;
            pnlItems.Enabled = isDraft;

            btnSave.Enabled = isDraft;
            btnDel.Enabled = isDraft;
            btnPost.Enabled = isDraft;
            btnVoid.Enabled = status == PostingStatus.Posted;

            btnSave.BackColor = isDraft ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnDel.BackColor = isDraft ? Color.FromArgb(196, 43, 28) : Color.Gray;
            btnPost.BackColor = isDraft ? Color.FromArgb(202, 80, 16) : Color.Gray;
            btnVoid.BackColor = status == PostingStatus.Posted ? Color.FromArgb(100, 20, 20) : Color.Gray;
        }

        private void SetUIButtonGroup()
        {
            bool hasRecord = !string.IsNullOrEmpty(lblAdjNumber.Text);
            btnSave.Enabled = hasRecord;
            btnDel.Enabled = hasRecord;
            btnAdd.Enabled = !hasRecord;
            btnPost.Enabled = hasRecord;
            btnVoid.Enabled = false;

            btnAdd.BackColor = !hasRecord ? Color.FromArgb(0, 120, 215) : Color.Gray;
            btnSave.BackColor = hasRecord ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnDel.BackColor = hasRecord ? Color.FromArgb(196, 43, 28) : Color.Gray;
            btnPost.BackColor = hasRecord ? Color.FromArgb(202, 80, 16) : Color.Gray;
            btnVoid.BackColor = Color.Gray;
        }

        private bool ValidateMandatoryFields()
        {
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Tambahkan minimal 1 item.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
            return true;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            var all = _uow.Repository.GetAll();
            StockAdjustment result = null;
            var current = lblAdjNumber.Text;

            switch (nav)
            {
                case RecordNavigation.First: result = all.OrderBy(p => p.AdjustmentNumber).FirstOrDefault(); break;
                case RecordNavigation.Last:  result = all.OrderByDescending(p => p.AdjustmentNumber).FirstOrDefault(); break;
                case RecordNavigation.Previous:
                    result = string.IsNullOrEmpty(current) ? all.OrderBy(p => p.AdjustmentNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.AdjustmentNumber, current) < 0).OrderByDescending(p => p.AdjustmentNumber).FirstOrDefault();
                    break;
                case RecordNavigation.Next:
                    result = string.IsNullOrEmpty(current) ? all.OrderByDescending(p => p.AdjustmentNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.AdjustmentNumber, current) > 0).OrderBy(p => p.AdjustmentNumber).FirstOrDefault();
                    break;
                default: return;
            }

            if (result != null)
            {
                LoadDataItem(result);
                SetUIButtonGroup();
                SetUIByStatus(result.PostingStatus);
            }
        }

        #endregion

        public FrmStockAdjustment()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmStockAdjustment_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<StockAdjustment>(dbContext);
            BindComboBoxProduct();

            // bind reason combo
            var reasons = new Dictionary<int, string>
            {
                { (int)AdjustmentReason.Damage,     "Kerusakan" },
                { (int)AdjustmentReason.Loss,       "Kehilangan" },
                { (int)AdjustmentReason.Expired,    "Kadaluarsa" },
                { (int)AdjustmentReason.Correction, "Koreksi" },
                { (int)AdjustmentReason.Other,      "Lainnya" }
            };
            cbReason.DataSource = new System.Windows.Forms.BindingSource(reasons, null);
            cbReason.DisplayMember = "Value";
            cbReason.ValueMember = "Key";

            // bind direction combo
            cbDirection.Items.Clear();
            cbDirection.Items.Add("In");
            cbDirection.Items.Add("Out");
            cbDirection.SelectedIndex = 1; // default Out

            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id) || id == "0") { cbBatch.DataSource = null; txtQtyBefore.Text = "0"; return; }
            BindComboBoxBatch(id);
        }

        private void cbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productId = cbProduct.SelectedValue?.ToString();
            var batchId = cbBatch.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(productId) || productId == "0") return;
            if (string.IsNullOrEmpty(batchId) || batchId == "0") { txtQtyBefore.Text = "0"; return; }
            txtQtyBefore.Text = string.Format("{0:n0}", GetCurrentStock(productId, batchId));
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var productId = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(productId) || productId == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Barang"); return; }

            var batchId = cbBatch.SelectedValue?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(txtQtyAdj.Text) || txtQtyAdj.Text == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Qty Adjustment"); return; }

            var prod = new UnitOfWork<Product>(dbContext).Repository.GetById(productId);
            var uom = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetById(prod.UnitId);
            var batch = new UnitOfWork<Batch>(dbContext).Repository.GetAll()
                .Where(b => b.Id == batchId).FirstOrDefault();

            var qtyBefore = int.Parse(txtQtyBefore.Text, System.Globalization.NumberStyles.Currency);
            var qtyAdj = int.Parse(txtQtyAdj.Text, System.Globalization.NumberStyles.Currency);
            var direction = cbDirection.SelectedItem.ToString() == "In" ? MovementDirection.In : MovementDirection.Out;
            var qtyAfter = direction == MovementDirection.In ? qtyBefore + qtyAdj : qtyBefore - qtyAdj;

            // update if same product+batch
            int rowId = -1;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colProductId"].Value?.ToString() == productId
                    && dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() == batchId)
                { rowId = i; break; }
            }
            if (rowId < 0) rowId = dgvItems.Rows.Add();

            var row = dgvItems.Rows[rowId];
            row.Cells["colProductId"].Value = productId;
            row.Cells["colBatchId"].Value = batchId;
            row.Cells["colUomId"].Value = uom.Id;
            row.Cells["colProductCode"].Value = prod.ProductCode;
            row.Cells["colProductName"].Value = prod.ProductName;
            row.Cells["colBatchCode"].Value = batch?.BatchCode ?? string.Empty;
            row.Cells["colUomCode"].Value = uom.UomCode;
            row.Cells["colQtyBefore"].Value = string.Format("{0:n0}", qtyBefore);
            row.Cells["colDirection"].Value = direction.ToString();
            row.Cells["colQtyAdj"].Value = string.Format("{0:n0}", qtyAdj);
            row.Cells["colQtyAfter"].Value = string.Format("{0:n0}", qtyAfter);

            cbProduct.SelectedValue = "0";
            cbBatch.DataSource = null;
            txtQtyBefore.Text = "0";
            txtQtyAdj.Text = "0";
            cbDirection.SelectedIndex = 1;
            cbProduct.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var adj = new StockAdjustment
                {
                    AdjustmentNumber = CreateAdjustmentNumber(),
                    AdjustmentDate = dtpAdjDate.Value,
                    Reason = (AdjustmentReason)(int)cbReason.SelectedValue,
                    Notes = txtNotes.Text.Trim(),
                    PostingStatus = PostingStatus.Draft,
                    UserId = Properties.Settings.Default.CurrentUserId,
                    Username = Properties.Settings.Default.CurrentUser,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };

                var uwAdj = new UnitOfWork<StockAdjustment>(dbContext);
                uwAdj.Repository.Add(adj);
                var res = uwAdj.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                var uwItem = new UnitOfWork<StockAdjustmentItem>(dbContext);
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var dir = dgvItems.Rows[i].Cells["colDirection"].Value.ToString() == "In"
                        ? MovementDirection.In : MovementDirection.Out;

                    uwItem.Repository.Add(new StockAdjustmentItem
                    {
                        StockAdjustmentId = adj.Id,
                        ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                        ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                        ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                        BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                        BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                        UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                        UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                        QtyBefore = int.Parse(dgvItems.Rows[i].Cells["colQtyBefore"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        QtyAdjustment = int.Parse(dgvItems.Rows[i].Cells["colQtyAdj"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        QtyAfter = int.Parse(dgvItems.Rows[i].Cells["colQtyAfter"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        Direction = dir,
                        CreatedBy = Properties.Settings.Default.CurrentUserId,
                        CreatedAt = DateTime.Now,
                        ModifiedBy = Properties.Settings.Default.CurrentUserId,
                        ModifiedAt = DateTime.Now
                    });
                }
                res = uwItem.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                tx.Commit();
                lblAdjNumber.Text = adj.AdjustmentNumber;
                txtAdjId.Text = adj.Id;
                txtModifiedAt.Text = adj.ModifiedAt.ToString();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtAdjId.Text.Trim()).ModifiedAt;
            if (commonHelper.StandardizeDateTime(DateTime.Parse(txtModifiedAt.Text)) != commonHelper.StandardizeDateTime(repoLastUpdated))
            { CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblAdjNumber.Text); return; }

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var adj = _uow.Repository.GetById(txtAdjId.Text.Trim());
                adj.AdjustmentDate = dtpAdjDate.Value;
                adj.Reason = (AdjustmentReason)(int)cbReason.SelectedValue;
                adj.Notes = txtNotes.Text.Trim();
                adj.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                adj.ModifiedAt = DateTime.Now;

                _uow.Repository.Update(adj);
                _uow.Commit();

                var uwItem = new UnitOfWork<StockAdjustmentItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockAdjustmentId == adj.Id));
                uwItem.Commit();

                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var dir = dgvItems.Rows[i].Cells["colDirection"].Value.ToString() == "In"
                        ? MovementDirection.In : MovementDirection.Out;

                    uwItem.Repository.Add(new StockAdjustmentItem
                    {
                        StockAdjustmentId = adj.Id,
                        ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                        ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                        ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                        BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                        BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                        UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                        UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                        QtyBefore = int.Parse(dgvItems.Rows[i].Cells["colQtyBefore"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        QtyAdjustment = int.Parse(dgvItems.Rows[i].Cells["colQtyAdj"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        QtyAfter = int.Parse(dgvItems.Rows[i].Cells["colQtyAfter"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        Direction = dir,
                        CreatedBy = Properties.Settings.Default.CurrentUserId,
                        CreatedAt = DateTime.Now,
                        ModifiedBy = Properties.Settings.Default.CurrentUserId,
                        ModifiedAt = DateTime.Now
                    });
                }
                uwItem.Commit();
                tx.Commit();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var adj = _uow.Repository.GetById(txtAdjId.Text.Trim());
            if (adj == null) { CommonMessageHelper.DataNotFound(lblAdjNumber.Text); return; }
            if (adj.PostingStatus != PostingStatus.Draft)
            { MessageBox.Show("Hanya Adjustment dengan status Draft yang dapat dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<StockAdjustmentItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockAdjustmentId == adj.Id));
                uwItem.Commit();
                _uow.Repository.Delete(adj);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Post Stock Adjustment {lblAdjNumber.Text}?\nStok akan diubah sesuai adjustment.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.PostStockAdjustment(txtAdjId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Stock Adjustment berhasil diposting.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Batalkan Stock Adjustment {lblAdjNumber.Text}?\nStok akan dikembalikan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.CancelStockAdjustment(txtAdjId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Stock Adjustment dibatalkan. Stok telah dikembalikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAdjNumber.Text = string.Empty;
            dtpAdjDate.Value = DateTime.Today;
            if (cbReason.Items.Count > 0) cbReason.SelectedIndex = 0;
            txtNotes.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtAdjId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            cbProduct.SelectedValue = "0";
            cbBatch.DataSource = null;
            txtQtyBefore.Text = "0";
            txtQtyAdj.Text = "0";
            cbDirection.SelectedIndex = 1;
            dgvItems.Rows.Clear();
            SetUIButtonGroup();
            pnlHeader.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdjId.Text)) return;
            var adj = _uow.Repository.GetById(txtAdjId.Text.Trim());
            if (adj != null) LoadDataItem(adj);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var adj = _uow.Repository.GetAll().Where(p => p.AdjustmentNumber == q).FirstOrDefault();
            if (adj != null) LoadDataItem(adj);
            else CommonMessageHelper.DataNotFound(q);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; btnSearch_Click(sender, e); }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0) return;
            dgvItems.Rows.RemoveAt(dgvItems.SelectedRows[0].Index);
        }

        private void txtQtyAdj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
