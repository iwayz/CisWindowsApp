using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmSalesOrder : Form
    {
        CisDbContext dbContext;
        UnitOfWork<SalesOrder> _uow;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        enum RecordNavigation
        {
            First,
            Previous,
            Next,
            Last
        }

        #region helper methods
        private void BindComboBoxCustomer()
        {
            var uow = new UnitOfWork<Customer>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.CustomerName);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.CustomerName);
                autoCompleteCollection.Add(res.CustomerName);
            }

            cbCustomer.DataSource = new BindingSource(dataSource, null);
            cbCustomer.DisplayMember = "Value";
            cbCustomer.ValueMember = "Key";
            cbCustomer.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxSalesman()
        {
            var uow = new UnitOfWork<Salesman>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.SalesmanCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.SalesmanCode);
                autoCompleteCollection.Add(res.SalesmanCode);
            }

            cbSalesman.DataSource = new BindingSource(dataSource, null);
            cbSalesman.DisplayMember = "Value";
            cbSalesman.ValueMember = "Key";
            cbSalesman.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxTermOfPayment()
        {
            var uow = new UnitOfWork<TermOfPayment>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.TermCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.TermCode);
                autoCompleteCollection.Add(res.TermCode);
            }

            cbTermOfPayment.DataSource = new BindingSource(dataSource, null);
            cbTermOfPayment.DisplayMember = "Value";
            cbTermOfPayment.ValueMember = "Key";
            cbTermOfPayment.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxSalesArea()
        {
            var uow = new UnitOfWork<SalesArea>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.AreaCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.AreaCode + " - " + res.Description);
                autoCompleteCollection.Add(res.AreaCode + " - " + res.Description);
            }

            cbSalesArea.DataSource = new BindingSource(dataSource, null);
            cbSalesArea.DisplayMember = "Value";
            cbSalesArea.ValueMember = "Key";
            cbSalesArea.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxProduct()
        {
            var uow = new UnitOfWork<Product>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.ProductCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.ProductCode + " - " + res.ProductName);
                autoCompleteCollection.Add(res.ProductCode + " - " + res.ProductName);
            }

            cbProduct.DataSource = new BindingSource(dataSource, null);
            cbProduct.DisplayMember = "Value";
            cbProduct.ValueMember = "Key";
            cbProduct.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxBatch(string productId)
        {
            var uow = new UnitOfWork<Batch>(dbContext);
            var queryResult = uow.Repository.GetAll().Where(e => e.ProductId == productId)
                .OrderBy(e => e.ExpiredDate);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.BatchCode);
                autoCompleteCollection.Add(res.BatchCode);
            }

            cbBatch.DataSource = new BindingSource(dataSource, null);
            cbBatch.DisplayMember = "Value";
            cbBatch.ValueMember = "Key";
            cbBatch.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
        }

        private void CheckSourceRefData()
        {
            List<string> refData = new List<string>();
            if (cbCustomer.Items.Count <= 1) refData.Add("Pelanggan");
            if (cbSalesman.Items.Count <= 1) refData.Add("Salesman");
            if (cbTermOfPayment.Items.Count <= 1) refData.Add("Term of Payment");
            if (cbSalesArea.Items.Count <= 1) refData.Add("Sales Area");
            if (cbProduct.Items.Count <= 1) refData.Add("Barang");

            lblNoteDetail.Text = "Data referensi (" + string.Join(", ", refData) + ") belum tersedia. ";
            if (refData.Count > 0) pnlNote.Visible = true;
        }

        private void NavigateRecord(RecordNavigation navigation)
        {
            if (txtSalesNo.Text.Trim().Length < 12)
                return;

            SalesOrder queryResult;
            var currSalesNo = Convert.ToInt32(txtSalesNo.Text.Trim().Substring(txtSalesNo.Text.Trim().Length - 6));
            switch (navigation)
            {
                case RecordNavigation.First:
                    queryResult = _uow.Repository.GetAll().OrderBy(s => s.SalesNo).FirstOrDefault();
                    break;
                case RecordNavigation.Previous:
                    queryResult = _uow.Repository.GetById(string.Concat("SO-", (currSalesNo - 1)));
                    break;
                case RecordNavigation.Next:
                    queryResult = _uow.Repository.GetById(string.Concat("SO-", (currSalesNo + 1)));
                    break;
                case RecordNavigation.Last:
                    queryResult = _uow.Repository.GetAll().OrderByDescending(s => s.SalesNo).FirstOrDefault();
                    break;
                default:
                    CommonMessageHelper.ContactAdminError();
                    return;
            }

            LoadDataBySelectedItem(queryResult);
        }

        private void LoadDataBySelectedItem(SalesOrder parentResult)
        {
            txtSalesNo.Text = parentResult.SalesNo;
            cbCustomer.SelectedValue = parentResult.CustomerId;
            cbSalesman.SelectedValue = parentResult.SalesmanId;
            cbTermOfPayment.SelectedValue = parentResult.TermOfPaymentId;
            dtpSalesOrderDate.Value = parentResult.SalesDate;
            dtpDueDate.Value = parentResult.DueDate;
            txtDeliveryAddress.Text = parentResult.DeliveryAddress;
            cbSalesArea.SelectedValue = parentResult.SalesAreaId;
            cbProvince.SelectedValue = parentResult.DeliveryProvinceId;
            cbDistrict.SelectedValue = parentResult.DeliveryDistrictId;
            cbSubDistrict.SelectedValue = parentResult.DeliverySubDistrictId;
            txtExtraDiscount.Text = parentResult.ExtraDiscountAmount.ToString();
            lblTotal.Text = parentResult.GrandTotalAmount.ToString();

            // hidden fields
            txtSalesOrderId.Text = parentResult.Id;
            txtModifiedAt.Text = parentResult.ModifiedAt.ToString();

            IQueryable<SalesOrderItem> childItems;
            UnitOfWork<SalesOrderItem> uowSalesOrderItem = new UnitOfWork<SalesOrderItem>(dbContext);
            childItems = uowSalesOrderItem.Repository.GetAll().Where(e => e.SalesOrderId == parentResult.Id);

            foreach (var item in childItems)
            {
                int rowId = dgvSalesOrderItem.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dgvSalesOrderItem.Rows[rowId];

                // Add the data
                row.Cells["productCode"].Value = item.ProductCode;
                row.Cells["productName"].Value = item.ProductName;
                row.Cells["expDate"].Value = item.ExpiredDate;
                row.Cells["qty"].Value = item.Quantity;
                row.Cells["uomCode"].Value = item.UomCode;
                row.Cells["price"].Value = item.Price;
                row.Cells["discPercent"].Value = item.DiscountPercentage;
                row.Cells["subTotal"].Value = item.TotalAmount;
            }
        }

        private void SetDataGridViewUI()
        {
            dgvSalesOrderItem.Columns["batchCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["batchCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSalesOrderItem.Columns["expDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["expDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSalesOrderItem.Columns["qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSalesOrderItem.Columns["uomCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["uomCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSalesOrderItem.Columns["price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSalesOrderItem.Columns["discPercent"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["discPercent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSalesOrderItem.Columns["subTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalesOrderItem.Columns["subTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void SetTotalSalesOrder()
        {
            decimal subTotal = 0;
            for (int i = 0; i < dgvSalesOrderItem.Rows.Count; ++i)
            {
                if (dgvSalesOrderItem.Rows[i].Cells["subTotal"].Value != null)
                    subTotal += decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["subTotal"].Value.ToString(), System.Globalization.NumberStyles.Currency);
            }

            decimal extraDisc = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency);
            decimal taxBase = subTotal - extraDisc;
            decimal valueAddedTax = (subTotal - extraDisc) * (decimal)0.01;
            decimal total = taxBase + valueAddedTax;

            txtSubTotal.Text = string.Format("{0:n0}", subTotal);
            txtTaxBaseAmount.Text = string.Format("{0:n0}", taxBase);
            txtValueAddedTaxAmount.Text = string.Format("{0:n0}", valueAddedTax);
            lblTotal.Text = string.Format("{0:n0}", total);
        }

        private bool ValidateMandatoryFields()
        {
            if (cbCustomer.SelectedValue.ToString() == "0" 
                || cbSalesman.SelectedValue.ToString() == "0"
                || cbTermOfPayment.SelectedValue.ToString() == "0")
            {
                CommonMessageHelper.DataCannotBeEmpty("Pelanggan, Salesman, dan Term of Payment");
                return false;
            }

            if (string.IsNullOrEmpty(txtDeliveryAddress.Text)
               || cbSalesArea.SelectedValue.ToString() == "0"
               || cbProvince.SelectedValue.ToString() == "0")
            {
                CommonMessageHelper.DataCannotBeEmpty("Alamat, Sales Area, dan Provinsi");
                return false;
            }

            if (dgvSalesOrderItem.Rows.Count <=0 
                || dgvSalesOrderItem.Rows[0].Cells[0].Value == null)
            {
                CommonMessageHelper.DataCannotBeEmpty("Detail order");
                return false;
            }

            return true;
        }

        #endregion helper methods


        public FrmSalesOrder()
        {
            InitializeComponent();
            dbContext = new CisDbContext();

            isAdd = true;
            SetDataGridViewUI();
        }

        private void FrmSalesOrder_Load(object sender, EventArgs e)
        {
            _uow = new UnitOfWork<SalesOrder>(dbContext);

            BindComboBoxCustomer();
            BindComboBoxSalesman();
            BindComboBoxTermOfPayment();
            BindComboBoxSalesArea();
            BindComboBoxProduct();
            BindComboBoxBatch("0");
            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);

            CheckSourceRefData();

        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            var disc = Convert.ToInt32(string.IsNullOrWhiteSpace(txtDiscount.Text) ? "0" : txtDiscount.Text);
            if (disc > 100)
            {
                MessageBox.Show("Discount tidak boleh melebihi angka 100.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Text = "0";
                txtDiscount.Focus();
            }
        }

        private void txtExtraDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedValue.ToString() == "0")
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Barang");
                return;
            }

            UnitOfWork<Product> uowProduct = new UnitOfWork<Product>(dbContext);
            var product = uowProduct.Repository.GetById(cbProduct.SelectedValue.ToString());
            UnitOfWork<UnitOfMeasurement> uowUom = new UnitOfWork<UnitOfMeasurement>(dbContext);
            var uom = uowUom.Repository.GetById(product.UnitId);

            int rowId = dgvSalesOrderItem.Rows.Add();
            DataGridViewRow row = dgvSalesOrderItem.Rows[rowId];

            // Add the data
            row.Cells["productCode"].Value = product.ProductCode;
            row.Cells["productName"].Value = product.ProductName;
            row.Cells["expDate"].Value = dtpExpiredDate.Value.ToShortDateString();
            row.Cells["qty"].Value = string.Format("{0:n0}", Convert.ToDecimal(txtQty.Text.Trim()));
            row.Cells["uomCode"].Value = uom.UomCode;
            row.Cells["price"].Value = string.Format("{0:n0}", Convert.ToDecimal(txtPrice.Text.Trim()));
            row.Cells["discPercent"].Value = txtDiscount.Text.Trim() + "%";

            // TODO: convert to decimal
            var qtyTotalAmount = Convert.ToInt32(txtQty.Text.Trim()) * Convert.ToDecimal(txtPrice.Text.Trim());
            var discount = 1 - (Convert.ToInt32(txtDiscount.Text.Trim()) / 100);
            row.Cells["subTotal"].Value = string.Format("{0:n0}", qtyTotalAmount - (qtyTotalAmount * discount));

            SetTotalSalesOrder();

            // reset back the add item 
            cbProduct.SelectedValue = "0";
            cbBatch.SelectedValue = "0";
            dtpExpiredDate.Value = DateTime.Today;
            txtQty.Text = "0";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var num = Convert.ToInt32(txtPrice.Text);
            //MessageBox.Show(SpellNumber.Spell(num));
            var c = dgvSalesOrderItem.Rows.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            NavigateRecord(RecordNavigation.First);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            NavigateRecord(RecordNavigation.Previous);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NavigateRecord(RecordNavigation.Next);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            NavigateRecord(RecordNavigation.Last);
        }

        private void cbTermOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var top = cbTermOfPayment.Text.Trim();
            switch (top)
            {
                case "NET-7":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(7);
                    break;
                case "NET-10":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(10);
                    break;
                case "NET-30":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(30);
                    break;
                case "NET-60":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(60);
                    break;
                case "NET-90":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(90);
                    break;
                case "EOM":
                    var year = dtpSalesOrderDate.Value.Year;
                    var month = dtpSalesOrderDate.Value.Month;
                    DateTime endOfMonth = new DateTime(year, month,
                                    DateTime.DaysInMonth(year, month));
                    dtpDueDate.Value = endOfMonth;
                    break;

                default:
                    break;
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodId = cbProduct.SelectedValue.ToString();
            BindComboBoxBatch(prodId);

            var uow = new UnitOfWork<Product>(dbContext);
            var queryResult = uow.Repository.GetById(prodId);
            if (queryResult == null) return;
            
            txtPrice.Text = queryResult.Price.ToString("G29");
            txtDiscount.Text = queryResult.Discount.ToString();
        }

        private void cbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var uow = new UnitOfWork<Batch>(dbContext);
            var queryResult = uow.Repository.GetById(cbBatch.SelectedValue.ToString());
            if (queryResult == null) return;
            dtpExpiredDate.Value = queryResult.ExpiredDate;

            txtQty.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SalesOrder queryResult;
            queryResult = _uow.Repository.GetAll().Where(s => s.SalesNo == txtSalesNo.Text.Trim()).FirstOrDefault();
            if (queryResult == null)
            {
                CommonMessageHelper.DataNotFound(txtSalesNo.Text.Trim());
                return;
            }
            LoadDataBySelectedItem(queryResult);

        }

        private void dgvSalesOrderItem_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetTotalSalesOrder();
        }

        private void txtExtraDiscount_Leave(object sender, EventArgs e)
        {
            txtExtraDiscount.Text = string.Format("{0:n0}", Convert.ToDecimal(txtExtraDiscount.Text));
            SetTotalSalesOrder();
        }

        private void txtExtraDiscount_Enter(object sender, EventArgs e)
        {
            txtExtraDiscount.Text = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency).ToString();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var uow = new UnitOfWork<Customer>(dbContext);
            var queryResult = uow.Repository.GetById(cbCustomer.SelectedValue.ToString());
            if (queryResult == null) return;

            txtDeliveryAddress.Text = queryResult.Address;
            cbSalesArea.SelectedValue = queryResult.SalesAreaId;
            cbProvince.SelectedValue = queryResult.ProvinceId;
            cbDistrict.SelectedValue = queryResult.DistrictId;
            cbSubDistrict.SelectedValue = queryResult.SubDistrictId;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalesNo.Text = string.Empty;
            cbCustomer.SelectedValue = "0";
            cbSalesman.SelectedValue = "0";
            cbTermOfPayment.SelectedValue = "0";
            cbSalesArea.SelectedValue = "0";
            dtpSalesOrderDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            txtDeliveryAddress.Text = string.Empty;
            cbProvince.SelectedValue = "0";
            txtExtraDiscount.Text = "0";
            lblTotal.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtSalesOrderId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtSalesNo.Text.Trim());
            }
            else
            {
                using (var context = new CisDbContext())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        var uwSalesOrder = new UnitOfWork<SalesOrder>(context);
                        var soToUpdate = uwSalesOrder.Repository.GetById(txtSalesOrderId.Text.Trim());
                        soToUpdate.CustomerId = cbCustomer.SelectedValue.ToString();
                        soToUpdate.SalesmanId= cbSalesman.SelectedValue.ToString();
                        soToUpdate.TermOfPaymentId = cbTermOfPayment.SelectedValue.ToString();
                        soToUpdate.SalesDate = dtpSalesOrderDate.Value;
                        soToUpdate.DueDate = dtpDueDate.Value;
                        soToUpdate.DeliveryAddress = txtDeliveryAddress.Text;
                        soToUpdate.DeliveryProvinceId = cbProvince.SelectedValue.ToString();
                        soToUpdate.DeliveryDistrictId= cbDistrict.SelectedValue.ToString();
                        soToUpdate.DeliverySubDistrictId= cbSubDistrict.SelectedValue.ToString();
                        soToUpdate.SalesAreaId = cbSalesArea.SelectedValue.ToString();
                        soToUpdate.ExtraDiscountAmount = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                        //soToUpdate.GrandTotalAmount


                        soToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                        soToUpdate.ModifiedAt = DateTime.Now;

                        var uwRole = new UnitOfWork<SalesOrder>(context);
                        uwRole.Repository.Update(soToUpdate);
                        uwRole.Commit();




                        dbContextTransaction.Commit();
                    }
                }

                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalesNo.Text))
            {
                btnClear.PerformClick();
                return;
            }

            SalesOrder queryResult;
            queryResult = _uow.Repository.GetById(txtSalesOrderId.Text.Trim());
            if (queryResult == null)
            {
                CommonMessageHelper.DataNotFound(txtSalesNo.Text.Trim());
                return;
            }
            LoadDataBySelectedItem(queryResult);

        }
    }
}
