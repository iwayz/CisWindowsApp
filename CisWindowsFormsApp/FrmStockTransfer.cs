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
    public partial class FrmStockTransfer : Form
    {
        CisDbContext dbContext;
        UnitOfWork<StockTransfer> _uow;
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

        private string CreateTransferNumber()
        {
            var last = _uow.Repository.GetAll()
                .Where(e => e.TransferDate.Month == dtpTransferDate.Value.Month
                         && e.TransferDate.Year == dtpTransferDate.Value.Year)
                .OrderByDescending(s => s.TransferNumber).FirstOrDefault();

            var yy = dtpTransferDate.Value.Year.ToString().Substring(2);
            var mm = dtpTransferDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}TRF-{mm}0001";
            var seq = Convert.ToInt64(last.TransferNumber.Substring(last.TransferNumber.Length - 4));
            return $"{yy}TRF-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private void LoadDataItem(StockTransfer st)
        {
            lblTransferNumber.Text = st.TransferNumber;
            dtpTransferDate.Value = st.TransferDate;
            cbTransferType.SelectedValue = (int)st.TransferType;
            txtBranchName.Text = st.BranchName ?? string.Empty;
            txtNotes.Text = st.Notes ?? string.Empty;
            lblStatus.Text = st.PostingStatus.ToString();
            lblStatus.ForeColor = StatusColor(st.PostingStatus);

            txtTransferId.Text = st.Id;
            txtModifiedAt.Text = st.ModifiedAt.ToString();

            var items = new UnitOfWork<StockTransferItem>(dbContext).Repository.GetAll()
                .Where(i => i.StockTransferId == st.Id).OrderBy(i => i.ProductCode);

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
                row.Cells["colQty"].Value = string.Format("{0:n0}", item.Quantity);
            }

            SetUIByStatus(st.PostingStatus);
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

            gbHeader.Enabled = isDraft;
            gbItems.Enabled = isDraft;

            btnSave.Enabled = isDraft;
            btnDel.Enabled = isDraft;
            btnPost.Enabled = isDraft;
            btnVoid.Enabled = status == PostingStatus.Posted;

            btnSave.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnPost.BackColor = isDraft ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnVoid.BackColor = status == PostingStatus.Posted ? Color.FromArgb(196, 43, 28) : Color.Gray;
        }

        private void SetUIButtonGroup()
        {
            bool hasRecord = !string.IsNullOrEmpty(lblTransferNumber.Text);
            btnSave.Enabled = hasRecord;
            btnDel.Enabled = hasRecord;
            btnAdd.Enabled = !hasRecord;
            btnPost.Enabled = hasRecord;
            btnVoid.Enabled = false;

            btnAdd.BackColor = !hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnSave.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnPost.BackColor = hasRecord ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnVoid.BackColor = Color.Gray;
        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrWhiteSpace(txtBranchName.Text))
            { CommonMessageHelper.DataCannotBeEmpty("Nama Cabang"); return false; }
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Tambahkan minimal 1 item.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
            return true;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            var all = _uow.Repository.GetAll();
            StockTransfer result = null;
            var current = lblTransferNumber.Text;

            switch (nav)
            {
                case RecordNavigation.First: result = all.OrderBy(p => p.TransferNumber).FirstOrDefault(); break;
                case RecordNavigation.Last:  result = all.OrderByDescending(p => p.TransferNumber).FirstOrDefault(); break;
                case RecordNavigation.Previous:
                    result = string.IsNullOrEmpty(current) ? all.OrderBy(p => p.TransferNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.TransferNumber, current) < 0).OrderByDescending(p => p.TransferNumber).FirstOrDefault();
                    break;
                case RecordNavigation.Next:
                    result = string.IsNullOrEmpty(current) ? all.OrderByDescending(p => p.TransferNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.TransferNumber, current) > 0).OrderBy(p => p.TransferNumber).FirstOrDefault();
                    break;
                default: return;
            }

            if (result != null) LoadDataItem(result);
            SetUIButtonGroup();
        }

        private List<StockTransferItem> GetItemsFromGrid()
        {
            var items = new List<StockTransferItem>();
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                items.Add(new StockTransferItem
                {
                    ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                    ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                    ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                    BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                    BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                    UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                    UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                    Quantity = decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                });
            }
            return items;
        }

        #endregion

        public FrmStockTransfer()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmStockTransfer_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<StockTransfer>(dbContext);
            BindComboBoxProduct();

            var types = new Dictionary<int, string>
            {
                { (int)StockTransferType.Out, "Transfer Keluar (Out)" },
                { (int)StockTransferType.In,  "Transfer Masuk (In)" }
            };
            cbTransferType.DataSource = new System.Windows.Forms.BindingSource(types, null);
            cbTransferType.DisplayMember = "Value";
            cbTransferType.ValueMember = "Key";

            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id) || id == "0") { cbBatch.DataSource = null; return; }
            BindComboBoxBatch(id);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var productId = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(productId) || productId == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Barang"); return; }

            var batchId = cbBatch.SelectedValue?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(txtQty.Text) || txtQty.Text == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Qty"); return; }

            var prod = new UnitOfWork<Product>(dbContext).Repository.GetById(productId);
            var uom = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetById(prod.UnitId);
            var batch = new UnitOfWork<Batch>(dbContext).Repository.GetAll()
                .Where(b => b.Id == batchId).FirstOrDefault();

            var qty = decimal.Parse(txtQty.Text, System.Globalization.NumberStyles.Currency);

            // update row if same product+batch already in grid
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
            row.Cells["colQty"].Value = string.Format("{0:n0}", qty);

            cbProduct.SelectedValue = "0";
            cbBatch.DataSource = null;
            txtQty.Text = "0";
            cbProduct.Focus();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0) return;
            dgvItems.Rows.RemoveAt(dgvItems.SelectedRows[0].Index);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var st = new StockTransfer
                {
                    TransferNumber = CreateTransferNumber(),
                    TransferDate = dtpTransferDate.Value,
                    TransferType = (StockTransferType)(int)cbTransferType.SelectedValue,
                    BranchName = txtBranchName.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                    PostingStatus = PostingStatus.Draft,
                    UserId = Properties.Settings.Default.CurrentUserId,
                    Username = Properties.Settings.Default.CurrentUser,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };

                var uwSt = new UnitOfWork<StockTransfer>(dbContext);
                uwSt.Repository.Add(st);
                var res = uwSt.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                var uwItem = new UnitOfWork<StockTransferItem>(dbContext);
                foreach (var item in GetItemsFromGrid())
                {
                    item.StockTransferId = st.Id;
                    uwItem.Repository.Add(item);
                }
                res = uwItem.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                tx.Commit();
                lblTransferNumber.Text = st.TransferNumber;
                txtTransferId.Text = st.Id;
                txtModifiedAt.Text = st.ModifiedAt.ToString();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtTransferId.Text.Trim()).ModifiedAt;
            if (commonHelper.StandardizeDateTime(DateTime.Parse(txtModifiedAt.Text)) != commonHelper.StandardizeDateTime(repoLastUpdated))
            { CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblTransferNumber.Text); return; }

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var st = _uow.Repository.GetById(txtTransferId.Text.Trim());
                st.TransferDate = dtpTransferDate.Value;
                st.TransferType = (StockTransferType)(int)cbTransferType.SelectedValue;
                st.BranchName = txtBranchName.Text.Trim();
                st.Notes = txtNotes.Text.Trim();
                st.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                st.ModifiedAt = DateTime.Now;

                _uow.Repository.Update(st);
                _uow.Commit();

                var uwItem = new UnitOfWork<StockTransferItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockTransferId == st.Id));
                uwItem.Commit();

                foreach (var item in GetItemsFromGrid())
                {
                    item.StockTransferId = st.Id;
                    uwItem.Repository.Add(item);
                }
                uwItem.Commit();
                tx.Commit();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var st = _uow.Repository.GetById(txtTransferId.Text.Trim());
            if (st == null) { CommonMessageHelper.DataNotFound(lblTransferNumber.Text); return; }
            if (st.PostingStatus != PostingStatus.Draft)
            { MessageBox.Show("Hanya Transfer dengan status Draft yang dapat dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<StockTransferItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.StockTransferId == st.Id));
                uwItem.Commit();
                _uow.Repository.Delete(st);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Post Stock Transfer {lblTransferNumber.Text}?\nStok akan diubah sesuai transfer.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.PostStockTransfer(txtTransferId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Stock Transfer berhasil diposting.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Batalkan Stock Transfer {lblTransferNumber.Text}?\nStok akan dikembalikan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.CancelStockTransfer(txtTransferId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Stock Transfer dibatalkan. Stok telah dikembalikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTransferNumber.Text = string.Empty;
            dtpTransferDate.Value = DateTime.Today;
            if (cbTransferType.Items.Count > 0) cbTransferType.SelectedIndex = 0;
            txtBranchName.Text = string.Empty;
            txtNotes.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtTransferId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            cbProduct.SelectedValue = "0";
            cbBatch.DataSource = null;
            txtQty.Text = "0";
            dgvItems.Rows.Clear();
            SetUIButtonGroup();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTransferId.Text)) return;
            var st = _uow.Repository.GetById(txtTransferId.Text.Trim());
            if (st != null) LoadDataItem(st);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var st = _uow.Repository.GetAll().Where(p => p.TransferNumber == q).FirstOrDefault();
            if (st != null) LoadDataItem(st);
            else CommonMessageHelper.DataNotFound(q);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; btnSearch_Click(sender, e); }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
