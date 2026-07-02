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
    public partial class FrmPurchaseReturn : Form
    {
        CisDbContext dbContext;
        UnitOfWork<PurchaseReturn> _uow;
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation { First, Previous, Next, Last }

        #region helpers

        private void BindComboBoxSupplier()
        {
            var list = new UnitOfWork<Principal>(dbContext).Repository.GetAll().OrderBy(e => e.PrincipalCode);
            var ds = new Dictionary<string, string> { { "0", "--Pilih--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var p in list)
            {
                ds.Add(p.Id, p.PrincipalCode + " - " + p.PrincipalName);
                ac.Add(p.PrincipalCode + " - " + p.PrincipalName);
            }
            cbSupplier.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbSupplier.DisplayMember = "Value";
            cbSupplier.ValueMember = "Key";
            cbSupplier.AutoCompleteCustomSource = ac;
        }

        private void BindComboBoxPO(string supplierId)
        {
            var list = new UnitOfWork<PurchaseOrder>(dbContext).Repository.GetAll()
                .Where(p => p.SupplierId == supplierId && p.PostingStatus == PurchaseOrderStatus.Received)
                .OrderByDescending(p => p.PONumber);

            var ds = new Dictionary<string, string> { { "0", "--Pilih PO--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var p in list)
            {
                ds.Add(p.Id, p.PONumber);
                ac.Add(p.PONumber);
            }
            cbPO.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbPO.DisplayMember = "Value";
            cbPO.ValueMember = "Key";
            cbPO.AutoCompleteCustomSource = ac;
        }

        private void BindComboBoxProduct(string poId)
        {
            var items = new UnitOfWork<PurchaseOrderItem>(dbContext).Repository.GetAll()
                .Where(i => i.PurchaseOrderId == poId)
                .OrderBy(i => i.ProductCode);

            var ds = new Dictionary<string, string> { { "0", "--Pilih Barang--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var i in items)
            {
                var key = i.ProductId + "|" + i.BatchId;
                var val = i.ProductCode + " - " + i.ProductName + (string.IsNullOrEmpty(i.BatchCode) ? "" : " [" + i.BatchCode + "]");
                if (!ds.ContainsKey(key)) { ds.Add(key, val); ac.Add(val); }
            }
            cbProduct.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbProduct.DisplayMember = "Value";
            cbProduct.ValueMember = "Key";
            cbProduct.AutoCompleteCustomSource = ac;
        }

        private string CreateReturnNumber()
        {
            var last = _uow.Repository.GetAll()
                .Where(e => e.ReturnDate.Month == dtpReturnDate.Value.Month
                         && e.ReturnDate.Year == dtpReturnDate.Value.Year)
                .OrderByDescending(s => s.ReturnNumber)
                .FirstOrDefault();

            var prefix = new UnitOfWork<CompanyInfo>(dbContext).Repository.GetAll()
                .FirstOrDefault(e => e.Key == "PurchaseReturnPrefix")?.Value ?? "PR";

            var yy = dtpReturnDate.Value.Year.ToString().Substring(2);
            var mm = dtpReturnDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}{prefix}-{mm}0001";
            var seq = Convert.ToInt64(last.ReturnNumber.Substring(last.ReturnNumber.Length - 4));
            return $"{yy}{prefix}-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private void LoadDataItem(PurchaseReturn pr)
        {
            lblReturnNumber.Text = pr.ReturnNumber;
            cbSupplier.SelectedValue = pr.SupplierId;
            BindComboBoxPO(pr.SupplierId);
            cbPO.SelectedValue = pr.PurchaseOrderId ?? "0";
            var loadPoId = cbPO.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(loadPoId) && loadPoId != "0")
                BindComboBoxProduct(loadPoId);
            dtpReturnDate.Value = pr.ReturnDate;
            txtReason.Text = pr.Reason ?? string.Empty;
            lblStatus.Text = pr.PostingStatus.ToString().ToUpper();
            lblStatus.ForeColor = StatusColor(pr.PostingStatus);

            txtReturnId.Text = pr.Id;
            txtModifiedAt.Text = pr.ModifiedAt.ToString();

            var items = new UnitOfWork<PurchaseReturnItem>(dbContext).Repository.GetAll()
                .Where(i => i.PurchaseReturnId == pr.Id)
                .OrderBy(i => i.ProductCode);

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
                row.Cells["colExpDate"].Value = item.ExpiredDate.ToString("MM/yyyy");
                row.Cells["colQty"].Value = string.Format("{0:n0}", item.Quantity);
                row.Cells["colUomCode"].Value = item.UomCode;
                row.Cells["colPrice"].Value = string.Format("{0:n0}", item.Price);
                row.Cells["colSubTotal"].Value = string.Format("{0:n0}", item.TotalAmount);
            }

            RecalcTotal();
            SetUIByStatus(pr.PostingStatus);
        }

        private void RecalcTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colSubTotal"].Value == null) continue;
                total += decimal.Parse(dgvItems.Rows[i].Cells["colSubTotal"].Value.ToString(),
                    System.Globalization.NumberStyles.Currency);
            }
            lblTotal.Text = string.Format("{0:n0}", total);
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
            btnSave.ForeColor = Color.White;
            btnDel.BackColor = isDraft ? Color.FromArgb(196, 43, 28) : Color.Gray;
            btnDel.ForeColor = Color.White;
            btnPost.BackColor = isDraft ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnPost.ForeColor = Color.White;
            btnVoid.BackColor = status == PostingStatus.Posted ? Color.FromArgb(100, 20, 20) : Color.Gray;
            btnVoid.ForeColor = Color.White;
        }

        private void SetUIButtonGroup()
        {
            bool hasRecord = !string.IsNullOrEmpty(lblReturnNumber.Text);
            btnSave.Enabled = hasRecord;
            btnDel.Enabled = hasRecord;
            btnAdd.Enabled = !hasRecord;
            btnPost.Enabled = hasRecord;
            btnVoid.Enabled = false;

            btnAdd.BackColor = !hasRecord ? Color.FromArgb(0, 120, 215) : Color.Gray;
            btnAdd.ForeColor = Color.White;
            btnSave.BackColor = hasRecord ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnSave.ForeColor = Color.White;
            btnDel.BackColor = hasRecord ? Color.FromArgb(196, 43, 28) : Color.Gray;
            btnDel.ForeColor = Color.White;
            btnPost.BackColor = hasRecord ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnPost.ForeColor = Color.White;
            btnVoid.BackColor = Color.Gray;
            btnVoid.ForeColor = Color.White;
            btnReload.BackColor = Color.FromArgb(100, 100, 100);
            btnReload.ForeColor = Color.White;
        }

        private bool ValidateMandatoryFields()
        {
            if (cbSupplier.SelectedValue.ToString() == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Principal / Supplier"); return false; }
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Tambahkan minimal 1 item.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
            return true;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            var all = _uow.Repository.GetAll();
            PurchaseReturn result;
            var current = lblReturnNumber.Text;

            switch (nav)
            {
                case RecordNavigation.First: result = all.OrderBy(p => p.ReturnNumber).FirstOrDefault(); break;
                case RecordNavigation.Last: result = all.OrderByDescending(p => p.ReturnNumber).FirstOrDefault(); break;
                case RecordNavigation.Previous:
                    result = string.IsNullOrEmpty(current) ? all.OrderBy(p => p.ReturnNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.ReturnNumber, current) < 0).OrderByDescending(p => p.ReturnNumber).FirstOrDefault();
                    break;
                case RecordNavigation.Next:
                    result = string.IsNullOrEmpty(current) ? all.OrderByDescending(p => p.ReturnNumber).FirstOrDefault() :
                        all.Where(p => string.Compare(p.ReturnNumber, current) > 0).OrderBy(p => p.ReturnNumber).FirstOrDefault();
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

        public FrmPurchaseReturn()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmPurchaseReturn_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<PurchaseReturn>(dbContext);
            BindComboBoxSupplier();

            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbSupplier.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id) || id == "0") { cbPO.DataSource = null; return; }
            BindComboBoxPO(id);
        }

        private void cbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var poId = cbPO.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(poId) || poId == "0") { cbProduct.DataSource = null; return; }
            BindComboBoxProduct(poId);
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(key) || key == "0") return;
            var parts = key.Split('|');
            if (parts.Length < 2) return;

            var productId = parts[0];
            var batchId = parts[1];

            var poId = cbPO.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(poId) || poId == "0") return;

            var item = new UnitOfWork<PurchaseOrderItem>(dbContext).Repository.GetAll()
                .Where(i => i.PurchaseOrderId == poId && i.ProductId == productId && i.BatchId == batchId)
                .FirstOrDefault();
            if (item == null) return;

            txtPrice.Text = string.Format("{0:n0}", item.Price);
            txtBatch.Text = item.BatchCode ?? string.Empty;
            dtpExpiredDate.Value = item.ExpiredDate;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var key = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(key) || key == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Barang"); return; }
            if (string.IsNullOrEmpty(txtQty.Text) || txtQty.Text == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Qty"); return; }

            var parts = key.Split('|');
            var productId = parts[0];
            var batchId = parts.Length > 1 ? parts[1] : string.Empty;

            var prod = new UnitOfWork<Product>(dbContext).Repository.GetById(productId);
            var uom = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetById(prod.UnitId);

            var qty = Convert.ToInt32(txtQty.Text.Trim());
            var price = Math.Round(decimal.Parse(txtPrice.Text.Trim(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
            var sub = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
            var expEnd = commonHelper.GetEndOfMonth(dtpExpiredDate.Value);

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
            row.Cells["colBatchCode"].Value = txtBatch.Text.Trim();
            row.Cells["colExpDate"].Value = expEnd.ToString("MM/yyyy");
            row.Cells["colQty"].Value = string.Format("{0:n0}", qty);
            row.Cells["colUomCode"].Value = uom.UomCode;
            row.Cells["colPrice"].Value = string.Format("{0:n0}", price);
            row.Cells["colSubTotal"].Value = string.Format("{0:n0}", sub);

            RecalcTotal();

            cbProduct.SelectedValue = "0";
            txtBatch.Text = string.Empty;
            txtQty.Text = "0";
            txtPrice.Text = "0";
            cbProduct.Focus();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0) return;
            dgvItems.Rows.Remove(dgvItems.SelectedRows[0]);
            RecalcTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var supplier = new UnitOfWork<Principal>(dbContext).Repository.GetById(cbSupplier.SelectedValue.ToString());
                var poId = cbPO.SelectedValue?.ToString();

                var poNumber = poId == "0" ? string.Empty : new UnitOfWork<PurchaseOrder>(dbContext).Repository.GetById(poId)?.PONumber ?? string.Empty;
                var pr = new PurchaseReturn
                {
                    ReturnNumber = CreateReturnNumber(),
                    PurchaseOrderId = poId == "0" ? null : poId,
                    PONumber = poNumber,
                    SupplierId = supplier.Id,
                    SupplierName = supplier.PrincipalName,
                    ReturnDate = dtpReturnDate.Value,
                    Reason = txtReason.Text.Trim(),
                    TotalAmount = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency),
                    PostingStatus = PostingStatus.Draft,
                    UserId = Properties.Settings.Default.CurrentUserId,
                    Username = Properties.Settings.Default.CurrentUser,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };

                var uwPR = new UnitOfWork<PurchaseReturn>(dbContext);
                uwPR.Repository.Add(pr);
                var res = uwPR.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                var uwItem = new UnitOfWork<PurchaseReturnItem>(dbContext);
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var subAmt = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    uwItem.Repository.Add(new PurchaseReturnItem
                    {
                        PurchaseReturnId = pr.Id,
                        ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                        ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                        ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                        BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                        BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                        ExpiredDate = commonHelper.StandardizeDate(expDate),
                        Quantity = qty,
                        UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                        UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                        Price = price,
                        TotalAmount = subAmt,
                        CreatedBy = Properties.Settings.Default.CurrentUserId,
                        CreatedAt = DateTime.Now,
                        ModifiedBy = Properties.Settings.Default.CurrentUserId,
                        ModifiedAt = DateTime.Now
                    });
                }
                res = uwItem.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                tx.Commit();
                lblReturnNumber.Text = pr.ReturnNumber;
                txtReturnId.Text = pr.Id;
                txtModifiedAt.Text = pr.ModifiedAt.ToString();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtReturnId.Text.Trim()).ModifiedAt;
            if (commonHelper.StandardizeDateTime(DateTime.Parse(txtModifiedAt.Text)) != commonHelper.StandardizeDateTime(repoLastUpdated))
            { CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblReturnNumber.Text); return; }

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var supplier = new UnitOfWork<Principal>(dbContext).Repository.GetById(cbSupplier.SelectedValue.ToString());
                var poId = cbPO.SelectedValue?.ToString();
                var pr = _uow.Repository.GetById(txtReturnId.Text.Trim());

                pr.PurchaseOrderId = poId == "0" ? null : poId;
                pr.PONumber = poId == "0" ? string.Empty : new UnitOfWork<PurchaseOrder>(dbContext).Repository.GetById(poId)?.PONumber ?? string.Empty;
                pr.SupplierId = supplier.Id;
                pr.SupplierName = supplier.PrincipalName;
                pr.ReturnDate = dtpReturnDate.Value;
                pr.Reason = txtReason.Text.Trim();
                pr.TotalAmount = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency);
                pr.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                pr.ModifiedAt = DateTime.Now;

                _uow.Repository.Update(pr);
                _uow.Commit();

                var uwItem = new UnitOfWork<PurchaseReturnItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.PurchaseReturnId == pr.Id));
                uwItem.Commit();

                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var subAmt = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    uwItem.Repository.Add(new PurchaseReturnItem
                    {
                        PurchaseReturnId = pr.Id,
                        ProductId = dgvItems.Rows[i].Cells["colProductId"].Value.ToString(),
                        ProductCode = dgvItems.Rows[i].Cells["colProductCode"].Value.ToString(),
                        ProductName = dgvItems.Rows[i].Cells["colProductName"].Value.ToString(),
                        BatchId = dgvItems.Rows[i].Cells["colBatchId"].Value?.ToString() ?? string.Empty,
                        BatchCode = dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() ?? string.Empty,
                        ExpiredDate = commonHelper.StandardizeDate(expDate),
                        Quantity = qty,
                        UomId = dgvItems.Rows[i].Cells["colUomId"].Value.ToString(),
                        UomCode = dgvItems.Rows[i].Cells["colUomCode"].Value.ToString(),
                        Price = price,
                        TotalAmount = subAmt,
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
            var pr = _uow.Repository.GetById(txtReturnId.Text.Trim());
            if (pr == null) { CommonMessageHelper.DataNotFound(lblReturnNumber.Text); return; }
            if (pr.PostingStatus != PostingStatus.Draft)
            { MessageBox.Show("Hanya Return dengan status Draft yang dapat dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<PurchaseReturnItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.PurchaseReturnId == pr.Id));
                uwItem.Commit();
                _uow.Repository.Delete(pr);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Post Purchase Return {lblReturnNumber.Text}?\nStok akan dikurangi.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.PostPurchaseReturn(txtReturnId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Purchase Return berhasil diposting. Stok telah dikurangi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Batalkan Purchase Return {lblReturnNumber.Text}?\nStok akan dikembalikan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.CancelPurchaseReturn(txtReturnId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Purchase Return dibatalkan. Stok telah dikembalikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblReturnNumber.Text = string.Empty;
            cbSupplier.SelectedValue = "0";
            cbPO.DataSource = null;
            dtpReturnDate.Value = DateTime.Today;
            txtReason.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtReturnId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            lblTotal.Text = "0";
            dgvItems.Rows.Clear();
            pnlHeader.Enabled = true;
            SetUIButtonGroup();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnId.Text)) return;
            var pr = _uow.Repository.GetById(txtReturnId.Text.Trim());
            if (pr != null) LoadDataItem(pr);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var pr = _uow.Repository.GetAll().Where(p => p.ReturnNumber == q).FirstOrDefault();
            if (pr != null)
            {
                LoadDataItem(pr);
                SetUIButtonGroup();
                SetUIByStatus(pr.PostingStatus);
            }
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
