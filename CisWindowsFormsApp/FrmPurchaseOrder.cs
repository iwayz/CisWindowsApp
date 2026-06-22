using Cis.Business;
using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmPurchaseOrder : Form
    {
        CisDbContext dbContext;
        UnitOfWork<PurchaseOrder> _uow;
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation { First, Previous, Next, Last }

        #region helpers

        private void BindComboBoxSupplier()
        {
            var uow = new UnitOfWork<Principal>(dbContext);
            var list = uow.Repository.GetAll().OrderBy(e => e.PrincipalCode);

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

        private void BindComboBoxProduct()
        {
            var uow = new UnitOfWork<Product>(dbContext);
            var list = uow.Repository.GetAll().OrderBy(e => e.ProductCode);

            var ds = new Dictionary<string, string> { { "0", "--Pilih--" } };
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

        private string CreatePONumber()
        {
            var last = _uow.Repository.GetAll()
                .Where(e => e.OrderDate.Month == dtpOrderDate.Value.Month
                         && e.OrderDate.Year == dtpOrderDate.Value.Year)
                .OrderByDescending(s => s.PONumber)
                .FirstOrDefault();

            var prefix = new UnitOfWork<CompanyInfo>(dbContext)
                .Repository.GetAll()
                .FirstOrDefault(e => e.Key == "PurchaseOrderPrefix")?.Value ?? "PO";

            var yy = dtpOrderDate.Value.Year.ToString().Substring(2);
            var mm = dtpOrderDate.Value.Month.ToString().PadLeft(2, '0');

            if (last == null)
                return $"{yy}{prefix}-{mm}0001";

            var seq = Convert.ToInt64(last.PONumber.Substring(last.PONumber.Length - 4));
            return $"{yy}{prefix}-{mm}{(seq + 1).ToString().PadLeft(4, '0')}";
        }

        private void LoadDataItem(PurchaseOrder po)
        {
            lblPONumber.Text = po.PONumber;
            cbSupplier.SelectedValue = po.SupplierId;
            txtSupplierAddress.Text = po.SupplierAddress;
            txtSupplierPhone.Text = po.SupplierPhone;
            dtpOrderDate.Value = po.OrderDate;
            dtpExpectedDate.Value = po.ExpectedDate;
            if (po.ReceivedDate.HasValue) dtpReceivedDate.Value = po.ReceivedDate.Value;
            txtNotes.Text = po.Notes ?? string.Empty;
            lblStatus.Text = po.PostingStatus.ToString();
            lblStatus.ForeColor = StatusColor(po.PostingStatus);

            txtPOId.Text = po.Id;
            txtModifiedAt.Text = po.ModifiedAt.ToString();

            var items = new UnitOfWork<PurchaseOrderItem>(dbContext)
                .Repository.GetAll()
                .Where(i => i.PurchaseOrderId == po.Id)
                .OrderBy(i => i.ProductCode);

            dgvItems.Rows.Clear();
            foreach (var item in items)
            {
                int r = dgvItems.Rows.Add();
                var row = dgvItems.Rows[r];
                row.Cells["colProductId"].Value = item.ProductId;
                row.Cells["colProductCode"].Value = item.ProductCode;
                row.Cells["colProductName"].Value = item.ProductName;
                row.Cells["colBatchId"].Value = item.BatchId ?? string.Empty;
                row.Cells["colBatchCode"].Value = item.BatchCode ?? string.Empty;
                row.Cells["colExpDate"].Value = item.ExpiredDate.ToString("MM/yyyy");
                row.Cells["colQty"].Value = string.Format("{0:n0}", item.Quantity);
                row.Cells["colUomId"].Value = item.UomId;
                row.Cells["colUomCode"].Value = item.UomCode;
                row.Cells["colPrice"].Value = string.Format("{0:n0}", item.Price);
                row.Cells["colDisc"].Value = string.Format("{0:n2}", item.DiscountPercentage) + "%";
                row.Cells["colSubTotal"].Value = string.Format("{0:n0}", item.TotalAmount);
            }

            RecalcTotals();
            SetUIByStatus(po.PostingStatus);
        }

        private void RecalcTotals()
        {
            decimal sub = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colSubTotal"].Value == null) continue;
                sub += decimal.Parse(dgvItems.Rows[i].Cells["colSubTotal"].Value.ToString(),
                    System.Globalization.NumberStyles.Currency);
            }
            var taxPct = dtpOrderDate.Value >= new DateTime(2022, 4, 1) ? 0.11m : 0.10m;
            var vat = Math.Round(sub * taxPct, 0, MidpointRounding.AwayFromZero);
            var total = sub + vat;

            txtSubTotal.Text = string.Format("{0:n0}", sub);
            txtVAT.Text = string.Format("{0:n0}", vat);
            lblTotal.Text = string.Format("{0:n0}", total);
        }

        private Color StatusColor(PurchaseOrderStatus s)
        {
            switch (s)
            {
                case PurchaseOrderStatus.Confirmed: return Color.FromArgb(0, 120, 215);
                case PurchaseOrderStatus.Received: return Color.FromArgb(16, 124, 16);
                case PurchaseOrderStatus.Cancelled: return Color.Gray;
                default: return Color.FromArgb(64, 64, 64);
            }
        }

        private void SetUIByStatus(PurchaseOrderStatus status)
        {
            bool isDraft = status == PurchaseOrderStatus.Draft;
            bool isConfirmed = status == PurchaseOrderStatus.Confirmed;
            bool isEditable = isDraft;

            gbHeader.Enabled = isEditable;
            gbItems.Enabled = isEditable;

            btnSave.Enabled = isEditable;
            btnDel.Enabled = isDraft;
            btnConfirm.Enabled = isDraft;
            btnReceive.Enabled = isConfirmed;
            btnCancel.Enabled = isDraft || isConfirmed;

            btnSave.BackColor = isEditable ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnConfirm.BackColor = isDraft ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnReceive.BackColor = isConfirmed ? Color.FromArgb(16, 124, 16) : Color.Gray;
            btnCancel.BackColor = (isDraft || isConfirmed) ? Color.FromArgb(196, 43, 28) : Color.Gray;
        }

        private void SetUIButtonGroup()
        {
            bool hasRecord = !string.IsNullOrEmpty(lblPONumber.Text);
            btnSave.Enabled = hasRecord;
            btnDel.Enabled = hasRecord;
            btnAdd.Enabled = !hasRecord;
            btnConfirm.Enabled = hasRecord;
            btnReceive.Enabled = hasRecord;
            btnCancel.Enabled = hasRecord;

            btnAdd.BackColor = !hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnSave.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = hasRecord ? Color.FromArgb(36, 141, 193) : Color.Gray;
        }

        private bool ValidateMandatoryFields()
        {
            if (cbSupplier.SelectedValue.ToString() == "0")
            {
                CommonMessageHelper.DataCannotBeEmpty("Principal / Supplier");
                return false;
            }
            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Tambahkan minimal 1 item.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void NavigateRecord(RecordNavigation nav)
        {
            PurchaseOrder result;
            var first = _uow.Repository.GetAll().OrderBy(p => p.PONumber).FirstOrDefault();
            var last = _uow.Repository.GetAll().OrderByDescending(p => p.PONumber).FirstOrDefault();
            var current = lblPONumber.Text;

            switch (nav)
            {
                case RecordNavigation.First: result = first; break;
                case RecordNavigation.Last: result = last; break;
                case RecordNavigation.Previous:
                    result = string.IsNullOrEmpty(current) ? first :
                        _uow.Repository.GetAll()
                            .Where(p => string.Compare(p.PONumber, current) < 0)
                            .OrderByDescending(p => p.PONumber).FirstOrDefault();
                    break;
                case RecordNavigation.Next:
                    result = string.IsNullOrEmpty(current) ? last :
                        _uow.Repository.GetAll()
                            .Where(p => string.Compare(p.PONumber, current) > 0)
                            .OrderBy(p => p.PONumber).FirstOrDefault();
                    break;
                default: return;
            }

            if (result != null) LoadDataItem(result);
            SetUIButtonGroup();
        }

        private float ParseDiscount(string s)
        {
            s = s.Replace("%", "").Trim();
            var sep = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            return float.Parse(string.IsNullOrWhiteSpace(s) ? "0"
                : (sep == ',' ? s.Replace('.', ',') : s.Replace(',', '.')));
        }

        #endregion

        public FrmPurchaseOrder()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<PurchaseOrder>(dbContext);
            BindComboBoxSupplier();
            BindComboBoxProduct();

            dtpExpiredDate.Format = DateTimePickerFormat.Custom;
            dtpExpiredDate.CustomFormat = "MM/yyyy";
            dtpExpiredDate.ShowUpDown = true;

            SetUIButtonGroup();
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbSupplier.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id) || id == "0") return;
            var p = new UnitOfWork<Principal>(dbContext).Repository.GetById(id);
            if (p == null) return;
            txtSupplierAddress.Text = p.Address;
            txtSupplierPhone.Text = p.Phone ?? string.Empty;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbProduct.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id) || id == "0") return;
            var p = new UnitOfWork<Product>(dbContext).Repository.GetById(id);
            if (p == null) return;
            txtPrice.Text = p.Price.ToString("G29");
            txtDiscount.Text = p.Discount.ToString().Replace('.', ',');
        }

        private void txtBatch_Leave(object sender, EventArgs e)
        {
            var b = new UnitOfWork<Batch>(dbContext).Repository.GetAll()
                .Where(x => x.BatchCode == txtBatch.Text.Trim()).FirstOrDefault();
            if (b != null) dtpExpiredDate.Value = b.ExpiredDate;
            txtQty.Focus();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedValue.ToString() == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Kode Barang"); return; }
            if (string.IsNullOrEmpty(txtQty.Text) || txtQty.Text == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Qty"); return; }

            var prod = new UnitOfWork<Product>(dbContext).Repository.GetById(cbProduct.SelectedValue.ToString());
            var batch = new UnitOfWork<Batch>(dbContext).Repository.GetAll()
                .Where(b => b.BatchCode == txtBatch.Text.Trim()).FirstOrDefault();
            var uom = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetById(prod.UnitId);

            var qty = Convert.ToInt32(txtQty.Text.Trim());
            var price = Math.Round(decimal.Parse(txtPrice.Text.Trim()), 5, MidpointRounding.AwayFromZero);
            var discPct = Math.Round(Convert.ToDecimal(ParseDiscount(txtDiscount.Text)) / 100, 5, MidpointRounding.AwayFromZero);
            var sub = Math.Round(qty * price * (1 - discPct), 0, MidpointRounding.AwayFromZero);
            var expEnd = commonHelper.GetEndOfMonth(dtpExpiredDate.Value);

            // update if same product+batch+month
            int rowId = -1;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells["colProductId"].Value?.ToString() == prod.Id
                    && dgvItems.Rows[i].Cells["colBatchCode"].Value?.ToString() == txtBatch.Text.Trim()
                    && commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString())) == expEnd)
                { rowId = i; break; }
            }
            if (rowId < 0) rowId = dgvItems.Rows.Add();

            var row = dgvItems.Rows[rowId];
            row.Cells["colProductId"].Value = prod.Id;
            row.Cells["colProductCode"].Value = prod.ProductCode;
            row.Cells["colProductName"].Value = prod.ProductName;
            row.Cells["colBatchId"].Value = batch?.Id ?? string.Empty;
            row.Cells["colBatchCode"].Value = txtBatch.Text.Trim();
            row.Cells["colExpDate"].Value = expEnd.ToString("MM/yyyy");
            row.Cells["colQty"].Value = string.Format("{0:n0}", qty);
            row.Cells["colUomId"].Value = uom.Id;
            row.Cells["colUomCode"].Value = uom.UomCode;
            row.Cells["colPrice"].Value = string.Format("{0:n0}", price);
            row.Cells["colDisc"].Value = string.Format("{0:n2}", ParseDiscount(txtDiscount.Text)) + "%";
            row.Cells["colSubTotal"].Value = string.Format("{0:n0}", sub);

            RecalcTotals();

            cbProduct.SelectedValue = "0";
            txtBatch.Text = string.Empty;
            dtpExpiredDate.Value = DateTime.Today;
            txtQty.Text = "0";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";
            cbProduct.Focus();
        }

        private void dgvItems_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RecalcTotals();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var supplier = new UnitOfWork<Principal>(dbContext).Repository.GetById(cbSupplier.SelectedValue.ToString());

                var po = new PurchaseOrder
                {
                    PONumber = CreatePONumber(),
                    SupplierId = supplier.Id,
                    SupplierName = supplier.PrincipalName,
                    SupplierAddress = supplier.Address,
                    SupplierPhone = supplier.Phone ?? string.Empty,
                    OrderDate = dtpOrderDate.Value,
                    ExpectedDate = dtpExpectedDate.Value,
                    SubTotalAmount = decimal.Parse(txtSubTotal.Text, System.Globalization.NumberStyles.Currency),
                    ValueAddedTaxAmount = decimal.Parse(txtVAT.Text, System.Globalization.NumberStyles.Currency),
                    GrandTotalAmount = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency),
                    Notes = txtNotes.Text.Trim(),
                    PostingStatus = PurchaseOrderStatus.Draft,
                    UserId = Properties.Settings.Default.CurrentUserId,
                    Username = Properties.Settings.Default.CurrentUser,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };

                var uwPO = new UnitOfWork<PurchaseOrder>(dbContext);
                uwPO.Repository.Add(po);
                var res = uwPO.Commit();
                if (!res.Item1) { tx.Rollback(); CommonMessageHelper.ContactAdminError(); return; }

                var uwItem = new UnitOfWork<PurchaseOrderItem>(dbContext);
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var discPct = ParseDiscount(dgvItems.Rows[i].Cells["colDisc"].Value.ToString());
                    var subAmt = Math.Round(qty * price * (1 - (decimal)discPct / 100), 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    uwItem.Repository.Add(new PurchaseOrderItem
                    {
                        PurchaseOrderId = po.Id,
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
                        DiscountPercentage = discPct,
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
                lblPONumber.Text = po.PONumber;
                txtPOId.Text = po.Id;
                txtModifiedAt.Text = po.ModifiedAt.ToString();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtPOId.Text.Trim()).ModifiedAt;
            if (commonHelper.StandardizeDateTime(DateTime.Parse(txtModifiedAt.Text)) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblPONumber.Text);
                return;
            }

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var supplier = new UnitOfWork<Principal>(dbContext).Repository.GetById(cbSupplier.SelectedValue.ToString());
                var po = _uow.Repository.GetById(txtPOId.Text.Trim());

                po.SupplierId = supplier.Id;
                po.SupplierName = supplier.PrincipalName;
                po.SupplierAddress = supplier.Address;
                po.SupplierPhone = supplier.Phone ?? string.Empty;
                po.OrderDate = dtpOrderDate.Value;
                po.ExpectedDate = dtpExpectedDate.Value;
                po.SubTotalAmount = decimal.Parse(txtSubTotal.Text, System.Globalization.NumberStyles.Currency);
                po.ValueAddedTaxAmount = decimal.Parse(txtVAT.Text, System.Globalization.NumberStyles.Currency);
                po.GrandTotalAmount = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency);
                po.Notes = txtNotes.Text.Trim();
                po.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                po.ModifiedAt = DateTime.Now;

                _uow.Repository.Update(po);
                _uow.Commit();

                var uwItem = new UnitOfWork<PurchaseOrderItem>(dbContext);
                var existing = uwItem.Repository.GetAll().Where(i => i.PurchaseOrderId == po.Id);
                uwItem.Repository.Delete(existing);
                uwItem.Commit();

                var newItems = new List<PurchaseOrderItem>();
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    if (dgvItems.Rows[i].Cells["colProductCode"].Value == null) continue;
                    var qty = Convert.ToInt32(decimal.Parse(dgvItems.Rows[i].Cells["colQty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var price = Math.Round(decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var discPct = ParseDiscount(dgvItems.Rows[i].Cells["colDisc"].Value.ToString());
                    var subAmt = Math.Round(qty * price * (1 - (decimal)discPct / 100), 0, MidpointRounding.AwayFromZero);
                    var expDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvItems.Rows[i].Cells["colExpDate"].Value.ToString()));

                    newItems.Add(new PurchaseOrderItem
                    {
                        PurchaseOrderId = po.Id,
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
                        DiscountPercentage = discPct,
                        TotalAmount = subAmt,
                        CreatedBy = Properties.Settings.Default.CurrentUserId,
                        CreatedAt = DateTime.Now,
                        ModifiedBy = Properties.Settings.Default.CurrentUserId,
                        ModifiedAt = DateTime.Now
                    });
                }
                uwItem.Repository.Add(newItems);
                uwItem.Commit();

                tx.Commit();
            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var po = _uow.Repository.GetById(txtPOId.Text.Trim());
            if (po == null) { CommonMessageHelper.DataNotFound(lblPONumber.Text); return; }
            if (po.PostingStatus != PurchaseOrderStatus.Draft)
            {
                MessageBox.Show("Hanya PO dengan status Draft yang dapat dihapus.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            using (var tx = dbContext.Database.BeginTransaction())
            {
                var uwItem = new UnitOfWork<PurchaseOrderItem>(dbContext);
                uwItem.Repository.Delete(uwItem.Repository.GetAll().Where(i => i.PurchaseOrderId == po.Id));
                uwItem.Commit();
                _uow.Repository.Delete(po);
                _uow.Commit();
                tx.Commit();
            }
            btnClear_Click(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var svc = new PurchaseOrderService(dbContext);
            var (ok, msg) = svc.Confirm(txtPOId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("PO berhasil dikonfirmasi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            dtpReceivedDate.Value = DateTime.Today;
            var confirm = MessageBox.Show($"Tandai PO {lblPONumber.Text} sebagai DITERIMA?\nTanggal: {dtpReceivedDate.Value:dd/MM/yyyy}",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new PurchaseOrderService(dbContext);
            var (ok, msg) = svc.Receive(txtPOId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("PO berhasil diterima. Stok telah diperbarui.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Batalkan PO {lblPONumber.Text}?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var svc = new PurchaseOrderService(dbContext);
            var (ok, msg) = svc.Cancel(txtPOId.Text.Trim(), Properties.Settings.Default.CurrentUserId);
            if (ok) { NavigateRecord(RecordNavigation.Last); MessageBox.Show("PO dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPONumber.Text = string.Empty;
            cbSupplier.SelectedValue = "0";
            txtSupplierAddress.Text = string.Empty;
            txtSupplierPhone.Text = string.Empty;
            dtpOrderDate.Value = DateTime.Today;
            dtpExpectedDate.Value = DateTime.Today.AddDays(7);
            txtNotes.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtPOId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
            txtSubTotal.Text = "0";
            txtVAT.Text = "0";
            lblTotal.Text = "0";
            dgvItems.Rows.Clear();
            SetUIButtonGroup();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPOId.Text)) return;
            var po = _uow.Repository.GetById(txtPOId.Text.Trim());
            if (po != null) LoadDataItem(po);
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.First);
        private void btnPrev_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Previous);
        private void btnNext_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Next);
        private void btnLast_Click(object sender, EventArgs e) => NavigateRecord(RecordNavigation.Last);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            var po = _uow.Repository.GetAll().Where(p => p.PONumber == q).FirstOrDefault();
            if (po != null) LoadDataItem(po);
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

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') { e.Handled = true; return; }
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(',')) e.Handled = true;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            var disc = ParseDiscount(txtDiscount.Text);
            if (disc > 100) { MessageBox.Show("Discount tidak boleh lebih dari 100.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); txtDiscount.Text = "0"; }
            commonHelper.SetTextBoxToZeroWhenEmpty(sender);
        }
    }
}
