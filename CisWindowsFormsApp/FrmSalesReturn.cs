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
    public partial class FrmSalesReturn : Form
    {
        CisDbContext dbContext;
        UnitOfWork<SalesReturn> _uow;
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation { First, Previous, Next, Last }

        #region helpers

        private void BindComboBoxCustomer()
        {
            var list = new UnitOfWork<Customer>(dbContext).Repository.GetAll().OrderBy(e => e.CustomerName);
            var ds = new Dictionary<string, string> { { "0", "--Pilih--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var c in list) { ds.Add(c.Id, c.CustomerName); ac.Add(c.CustomerName); }
            cbCustomer.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbCustomer.DisplayMember = "Value";
            cbCustomer.ValueMember = "Key";
            cbCustomer.AutoCompleteCustomSource = ac;
        }

        private void BindComboBoxSO(string customerId)
        {
            var list = new UnitOfWork<SalesOrder>(dbContext).Repository.GetAll()
                .Where(s => s.CustomerId == customerId && s.PostingStatus == SalesOrderStatus.Posted)
                .OrderByDescending(s => s.SalesNo)
                .ToList();
            var ds = new Dictionary<string, string> { { "0", "--Pilih SO--" } };
            var ac = new AutoCompleteStringCollection();
            foreach (var s in list) { ds.Add(s.Id, s.SalesNo); ac.Add(s.SalesNo); }
            cbSO.DataSource = new System.Windows.Forms.BindingSource(ds, null);
            cbSO.DisplayMember = "Value";
            cbSO.ValueMember = "Key";
            cbSO.AutoCompleteCustomSource = ac;
        }

        private void BindComboBoxProduct(string soId)
        {
            var items = new UnitOfWork<SalesOrderItem>(dbContext).Repository.GetAll()
                .Where(i => i.SalesOrderId == soId)
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
                .OrderByDescending(s => s.ReturnNumber).FirstOrDefault();

            var prefix = new UnitOfWork<CompanyInfo>(dbContext).Repository.GetAll()
                .FirstOrDefault(e => e.Key == "SalesReturnPrefix")?.Value ?? "SR";

            var yy = dtpReturnDate.Value.Year.ToString().Substring(2);
            var mm = dtpReturnDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null) return $"{yy}{prefix}-{mm}0001";
            var seq = Convert.ToInt64(last.ReturnNumber.Substring(last.ReturnNumber.Length - 4));
            return $"{yy}{prefix}-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private void LoadDataItem(SalesReturn sr)
        {
            lblReturnNumber.Text = sr.ReturnNumber;
            cbCustomer.SelectedValue = sr.CustomerId;
            BindComboBoxSO(sr.CustomerId);
            cbSO.SelectedValue = sr.SalesOrderId ?? "0";
            if (sr.SalesOrderId != null) BindComboBoxProduct(sr.SalesOrderId);
            dtpReturnDate.Value = sr.ReturnDate;
            txtReason.Text = sr.Reason ?? string.Empty;
            lblStatus.Text = sr.PostingStatus.ToString().ToUpper();
            lblStatus.ForeColor = StatusColor(sr.PostingStatus);

            txtReturnId.Text = sr.Id;
            txtModifiedAt.Text = sr.ModifiedAt.ToString();

            var items = new UnitOfWork<SalesReturnItem>(dbContext).Repository.GetAll()
                .Where(i => i.SalesReturnId == sr.Id).OrderBy(i => i.ProductCode);

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
            SetUIByStatus(sr.PostingStatus);
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
            if (cbCustomer.SelectedValue.ToString() == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Pelanggan"); return false; }
            if (dgvItems.Rows.Count == 0)
            { MessageBox.Show("Tambahkan minimal 1 item.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
            return true;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            var all = _uow.Repository.GetAll();
            SalesReturn result = null;
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

        public FrmSalesReturn()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesReturn_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<SalesReturn>(dbContext);
            BindComboBoxCustomer();
            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbCustomer.SelectedValue?.ToString();
            cbSO.DataSource = null;
            cbProduct.DataSource = null;
            if (string.IsNullOrEmpty(id) || id == "0") return;
            BindComboBoxSO(id);
        }

        private void cbSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var soId = cbSO.SelectedValue?.ToString();
            cbProduct.DataSource = null;
            if (string.IsNullOrEmpty(soId) || soId == "0") return;
            BindComboBoxProduct(soId);
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(key) || key == "0") return;
            var parts = key.Split('|');
            if (parts.Length < 2) return;

            var soId = cbSO.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(soId) || soId == "0") return;

            var productId = parts[0];
            var batchId = parts[1];
            var item = new UnitOfWork<SalesOrderItem>(dbContext).Repository.GetAll()
                .Where(i => i.SalesOrderId == soId && i.ProductId == productId && i.BatchId == batchId)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var customer = new UnitOfWork<Customer>(dbContext).Repository.GetById(cbCustomer.SelectedValue.ToString());
                var soId = cbSO.SelectedValue?.ToString();

                var sr = new SalesReturn
                {
                    ReturnNumber = CreateReturnNumber(),
                    SalesOrderId = soId == "0" ? null : soId,
                    SalesNo = soId == "0" ? string.Empty : new UnitOfWork<SalesOrder>(dbContext).Repository.GetById(soId)?.SalesNo ?? string.Empty,
                    CustomerId = customer.Id,
                    CustomerName = customer.CustomerName,
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

                var uwSR = new UnitOfWork<SalesReturn>(dbContext);
                uwSR.Repository.Add(sr);
                var res = uwSR.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                var uwItem = new UnitOfWork<SalesReturnItem>(dbContext);
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var subAmt = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    uwItem.Repository.Add(new SalesReturnItem
                    {
                        SalesReturnId = sr.Id,
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
                lblReturnNumber.Text = sr.ReturnNumber;
                txtReturnId.Text = sr.Id;
                txtModifiedAt.Text = sr.ModifiedAt.ToString();
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
                var customer = new UnitOfWork<Customer>(dbContext).Repository.GetById(cbCustomer.SelectedValue.ToString());
                var soId = cbSO.SelectedValue?.ToString();
                var sr = _uow.Repository.GetById(txtReturnId.Text.Trim());

                sr.SalesOrderId = soId == "0" ? null : soId;
                sr.SalesNo = soId == "0" ? string.Empty : new UnitOfWork<SalesOrder>(dbContext).Repository.GetById(soId)?.SalesNo ?? string.Empty;
                sr.CustomerId = customer.Id;
                sr.CustomerName = customer.CustomerName;
                sr.ReturnDate = dtpReturnDate.Value;
                sr.Reason = txtReason.Text.Trim();
                sr.TotalAmount = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency);
                sr.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                sr.ModifiedAt = DateTime.Now;

                _uow.Repository.Update(sr);
                _uow.Commit();

                var uwItem = new UnitOfWork<SalesReturnItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.SalesReturnId == sr.Id));
                uwItem.Commit();

                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var subAmt = Math.Round(qty * price, 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    uwItem.Repository.Add(new SalesReturnItem
                    {
                        SalesReturnId = sr.Id,
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
            var sr = _uow.Repository.GetById(txtReturnId.Text.Trim());
            if (sr == null) { CommonMessageHelper.DataNotFound(lblReturnNumber.Text); return; }
            if (sr.PostingStatus != PostingStatus.Draft)
            { MessageBox.Show("Hanya Return dengan status Draft yang dapat dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<SalesReturnItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.SalesReturnId == sr.Id));
                uwItem.Commit();
                _uow.Repository.Delete(sr);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Post Sales Return {lblReturnNumber.Text}?\nStok akan ditambah.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.PostSalesReturn(txtReturnId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Sales Return berhasil diposting. Stok telah ditambah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Batalkan Sales Return {lblReturnNumber.Text}?\nStok akan dikurangi kembali.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new StockService(dbContext);
            var (ok, msg) = svc.CancelSalesReturn(txtReturnId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("Sales Return dibatalkan. Stok telah dikurangi kembali.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblReturnNumber.Text = string.Empty;
            cbCustomer.SelectedValue = "0";
            cbSO.DataSource = null;
            dtpReturnDate.Value = DateTime.Today;
            txtReason.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtReturnId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            lblTotal.Text = "0";
            dgvItems.Rows.Clear();
            SetUIButtonGroup();
            pnlHeader.Enabled = true;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0) return;
            dgvItems.Rows.Remove(dgvItems.SelectedRows[0]);
            RecalcTotal();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnId.Text)) return;
            var sr = _uow.Repository.GetById(txtReturnId.Text.Trim());
            if (sr != null) LoadDataItem(sr);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var sr = _uow.Repository.GetAll().Where(p => p.ReturnNumber == q).FirstOrDefault();
            if (sr != null)
            {
                LoadDataItem(sr);
                SetUIButtonGroup();
                SetUIByStatus(sr.PostingStatus);
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
