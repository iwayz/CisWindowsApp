﻿using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmSalesOrder : Form
    {
        CisDbContext dbContext;
        UnitOfWork<SalesOrder> _uow;
        bool isAdd = false;
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

        private void SetUIButtonGroup()
        {
            var disable = String.IsNullOrEmpty(lblSalesNo.Text);
            btnSave.Enabled = !disable;
            btnDel.Enabled = !disable;
            btnPrint.Enabled = !disable;
            btnReload.Enabled = !disable;
            btnAdd.Enabled = disable;

            btnSave.BackColor = !disable ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !disable ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnPrint.BackColor = !disable ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnReload.BackColor = !disable ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnAdd.BackColor = disable ? Color.FromArgb(36, 141, 193) : Color.Gray;
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
            SalesOrder queryResult;
            var currSalesNo = 1;
            var expectedSalesNo = string.Empty;
            if (string.IsNullOrEmpty(lblSalesNo.Text))
            {
                if (navigation == RecordNavigation.First || navigation == RecordNavigation.Previous || navigation == RecordNavigation.Next)
                    navigation = RecordNavigation.First;
                else
                    navigation = RecordNavigation.Last;
            }
            else
                currSalesNo = Convert.ToInt32(lblSalesNo.Text.Substring(lblSalesNo.Text.Trim().Length - 6));

            switch (navigation)
            {
                case RecordNavigation.First:
                    queryResult = _uow.Repository.GetAll().OrderBy(s => s.SalesNo).FirstOrDefault();
                    break;
                case RecordNavigation.Previous:
                    queryResult = null;
                    if (currSalesNo > 1)
                    {
                        expectedSalesNo = string.Concat("SO-", (currSalesNo - 1).ToString().PadLeft(6, '0'));
                        queryResult = _uow.Repository.GetAll().Where(s => s.SalesNo == expectedSalesNo).FirstOrDefault();
                    }
                    break;
                case RecordNavigation.Next:
                    queryResult = null;
                    var lastRec = _uow.Repository.GetAll().OrderByDescending(s => s.SalesNo).FirstOrDefault();
                    if (lastRec.Id != txtSalesOrderId.Text.Trim())
                    {
                        expectedSalesNo = string.Concat("SO-", (currSalesNo + 1).ToString().PadLeft(6, '0'));
                        queryResult = _uow.Repository.GetAll().Where(s => s.SalesNo == expectedSalesNo).FirstOrDefault();
                    }
                    break;
                case RecordNavigation.Last:
                    queryResult = _uow.Repository.GetAll().OrderByDescending(s => s.SalesNo).FirstOrDefault();
                    break;
                default:
                    CommonMessageHelper.ContactAdminError();
                    return;
            }

            if (queryResult != null)
                LoadDataItem(queryResult);

            SetUIButtonGroup();
        }

        private void LoadSalesOrderData(string salesNo)
        {
            SalesOrder queryResult;
            queryResult = _uow.Repository.GetAll().Where(s => s.SalesNo == salesNo).FirstOrDefault();
            if (queryResult == null)
            {
                CommonMessageHelper.DataNotFound(txtSalesNo.Text.Trim());
                return;
            }
            LoadDataItem(queryResult);
        }

        private void SetUI()
        {
            var isEditable = !lblMark.Visible;

            gbCustomerDetail.Enabled = isEditable;
            gbShippingAddress.Enabled = isEditable;
            gbSalesOrderDetail.Enabled = isEditable;

            btnAdd.Enabled = isEditable;
            btnSave.Enabled = isEditable;
            btnDel.Enabled = isEditable;
            btnReload.Enabled = isEditable;
        }
        private string CreateSalesOrderNo()
        {
            var result = string.Empty;
            var queryResult = _uow.Repository.GetAll().OrderByDescending(s => s.SalesNo).FirstOrDefault();
            if (queryResult == null)
                return "SO-000001";

            var lastSalesNo = Convert.ToInt64(queryResult.SalesNo.Substring(queryResult.SalesNo.Length - 6));
            return string.Concat("SO-", (lastSalesNo + 1).ToString().PadLeft(6,'0'));
        }

        private string GetLocationName(string locationId)
        {
            var loc = new UnitOfWork<Location>(dbContext).Repository.GetById(locationId);
            return loc == null ? string.Empty : loc.Name;
        }

        private void LoadDataItem(SalesOrder parentResult)
        {
            lblMark.Visible = false;
            if (parentResult.Status == Constant.RecordStatus.Inactive)
                lblMark.Visible = true;

            lblSalesNo.Text = parentResult.SalesNo;
            cbCustomer.SelectedValue = parentResult.CustomerId;
            cbSalesman.SelectedValue = parentResult.SalesmanId;
            cbTermOfPayment.SelectedValue = parentResult.TermOfPaymentId;
            dtpSalesOrderDate.Value = parentResult.SalesDate;
            dtpDueDate.Value = parentResult.DueDate;
            txtDeliveryAddress.Text = parentResult.DeliveryAddress;
            cbSalesArea.SelectedValue = parentResult.SalesAreaId;
            cbProvince.SelectedValue = parentResult.DeliveryProvinceId;
            cbDistrict.SelectedValue = parentResult.DeliveryDistrictId;
            txtExtraDiscount.Text = string.Format("{0:n0}", parentResult.ExtraDiscountAmount);

            // hidden fields
            txtSalesOrderId.Text = parentResult.Id;
            txtModifiedAt.Text = parentResult.ModifiedAt.ToString();

            IQueryable<SalesOrderItem> childItems;
            UnitOfWork<SalesOrderItem> uowSalesOrderItem = new UnitOfWork<SalesOrderItem>(dbContext);
            childItems = uowSalesOrderItem.Repository.GetAll().Where(e => e.SalesOrderId == parentResult.Id).OrderBy(e => e.ProductCode);
            dgvSalesOrderItem.Rows.Clear();
            dgvSalesOrderItem.Refresh();

            foreach (var item in childItems)
            {
                int rowId = dgvSalesOrderItem.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dgvSalesOrderItem.Rows[rowId];

                // Add the data
                row.Cells["productId"].Value = item.ProductId;
                row.Cells["productCode"].Value = item.ProductCode;
                row.Cells["productName"].Value = item.ProductName;
                row.Cells["batchId"].Value = item.BatchId;
                row.Cells["batchCode"].Value = item.BatchCode;
                row.Cells["expDate"].Value = item.ExpiredDate.ToString("MM/yyyy");
                row.Cells["qty"].Value = string.Format("{0:n0}", item.Quantity);
                row.Cells["uomId"].Value = item.UomId;
                row.Cells["uomCode"].Value = item.UomCode;
                row.Cells["price"].Value = string.Format("{0:n0}", item.Price);
                row.Cells["discPercent"].Value = item.DiscountPercentage + "%";
                row.Cells["subTotal"].Value = string.Format("{0:n0}", item.TotalAmount);
                
                // hidden
                row.Cells["priceReal"].Value = string.Format("{0:n10}", item.Price); 
            }

            SetTotalSalesOrder();
            SetUI();
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
            decimal subTotalReal = 0;
            for (int i = 0; i < dgvSalesOrderItem.Rows.Count; ++i)
            {
                if (dgvSalesOrderItem.Rows[i].Cells["priceReal"].Value != null)
                {
                    var qty = decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["qty"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                    var price = Math.Round(decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["priceReal"].Value.ToString(), System.Globalization.NumberStyles.Currency), 5, MidpointRounding.AwayFromZero);
                    var discountPercentage = Math.Round(Convert.ToDecimal(ValidateDiscount(dgvSalesOrderItem.Rows[i].Cells["discPercent"].Value.ToString().Replace("%", ""))) / 100, 5, MidpointRounding.AwayFromZero);
                    subTotalReal += (qty * price * ((decimal)1 - discountPercentage));
                }
            }

            decimal extraDisc = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency);
            decimal taxBase = Math.Round(subTotalReal - extraDisc, 5, MidpointRounding.AwayFromZero);
            decimal valueAddedTax = Math.Round(taxBase * (decimal)0.1, 5, MidpointRounding.AwayFromZero); // 10% PPN
            decimal total = Math.Round(taxBase + valueAddedTax, 5, MidpointRounding.AwayFromZero);

            txtSubTotal.Text = string.Format("{0:n0}", subTotalReal);
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

            return true;
        }

        private float ValidateDiscount(string discount)
        {
            var numberDecimalSeparator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            return float.Parse(string.IsNullOrWhiteSpace(discount) ? "0"
                : (numberDecimalSeparator.Equals(',') ? discount.Replace('.', ',') : discount.Replace(',', '.')));
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
            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);

            isAdd = true;
            SetUIButtonGroup();

            cbCustomer.Focus();
            CheckSourceRefData();

            dtpExpiredDate.Format = DateTimePickerFormat.Custom;
            dtpExpiredDate.CustomFormat = "MM/yyyy";
            dtpExpiredDate.ShowUpDown = true;
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            var disc = ValidateDiscount(txtDiscount.Text.Trim());
            if (disc > 100)
            {
                MessageBox.Show("Discount tidak boleh melebihi angka 100.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Text = "0";
                txtDiscount.Focus();
            }
           commonHelper.SetTextBoxToZeroWhenEmpty(sender);
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

            if (string.IsNullOrEmpty(txtQty.Text.Trim()) || txtQty.Text.Trim() == "0")
            {
                CommonMessageHelper.DataCannotBeEmpty("Qty");
                return;
            }

            UnitOfWork<Product> uowProduct = new UnitOfWork<Product>(dbContext);
            var product = uowProduct.Repository.GetById(cbProduct.SelectedValue.ToString());
            UnitOfWork<Batch> uowBatch = new UnitOfWork<Batch>(dbContext);
            var batch = uowBatch.Repository.GetAll().Where(b => b.BatchCode.Equals(txtBatch.Text.Trim())).FirstOrDefault();
            UnitOfWork<UnitOfMeasurement> uowUom = new UnitOfWork<UnitOfMeasurement>(dbContext);
            var uom = uowUom.Repository.GetById(product.UnitId);
            int rowId = dgvSalesOrderItem.Rows.Count;
            bool duplicateItem = false;
            
            // if any existing data, then update
            for (int i = 0; i < dgvSalesOrderItem.Rows.Count; ++i)
            {
                if (dgvSalesOrderItem.Rows[i].Cells["productId"].Value == null) continue;
                
                if (dgvSalesOrderItem.Rows[i].Cells["productId"].Value.ToString() == cbProduct.SelectedValue.ToString()
                    && (dgvSalesOrderItem.Rows[i].Cells["batchCode"].Value.ToString() == txtBatch.Text.Trim() || string.IsNullOrEmpty(dgvSalesOrderItem.Rows[i].Cells["batchId"].Value.ToString()))
                    && commonHelper.GetEndOfMonth(DateTime.Parse(dgvSalesOrderItem.Rows[0].Cells["expDate"].Value.ToString())) == commonHelper.GetEndOfMonth(dtpExpiredDate.Value))
                {
                    rowId = i;
                    duplicateItem = true;
                    break;
                }
            }

            if (!duplicateItem)
                rowId = dgvSalesOrderItem.Rows.Add();

            DataGridViewRow row = dgvSalesOrderItem.Rows[rowId];

            // Add the data
            var qty = Convert.ToDecimal(txtQty.Text.Trim());
            

            var netPrice = Math.Round(Convert.ToDecimal(txtPrice.Text.Trim()) / (decimal)1.1, 5, MidpointRounding.AwayFromZero);
            var discountPercentage = Math.Round(Convert.ToDecimal(ValidateDiscount(txtDiscount.Text.Trim())) / 100, 5, MidpointRounding.AwayFromZero);
            var grossValue = Math.Round(qty * netPrice, 5, MidpointRounding.AwayFromZero); ;
            var taxBaseAmount = Math.Round(grossValue * (1 - Convert.ToDecimal(discountPercentage)), 5, MidpointRounding.AwayFromZero);

            row.Cells["productId"].Value = product.Id;
            row.Cells["productCode"].Value = product.ProductCode;
            row.Cells["productName"].Value = product.ProductName;
            row.Cells["batchId"].Value = batch != null ? batch.Id : string.Empty;
            row.Cells["batchCode"].Value = txtBatch.Text.Trim();
            DateTime expiredDate = commonHelper.GetEndOfMonth(dtpExpiredDate.Value);
            row.Cells["expDate"].Value = expiredDate.ToString("MM/yyyy");
            row.Cells["qty"].Value = string.Format("{0:n0}", Convert.ToDecimal(txtQty.Text.Trim()));
            row.Cells["uomId"].Value = uom.Id;
            row.Cells["uomCode"].Value = uom.UomCode;
            row.Cells["price"].Value = string.Format("{0:n0}", netPrice);
            row.Cells["discPercent"].Value = string.Format("{0:n2}", ValidateDiscount(txtDiscount.Text.Trim())) + "%";
            row.Cells["subTotal"].Value = string.Format("{0:n0}", taxBaseAmount);
            
            // hidden
            row.Cells["priceReal"].Value = string.Format("{0:n10}", netPrice); ;

            SetTotalSalesOrder();

            // reset back the add item 
            cbProduct.SelectedValue = "0";
            txtBatch.Text = string.Empty;
            dtpExpiredDate.Value = DateTime.Today;
            txtQty.Text = "0";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";
            cbProduct.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmRptInvoiceViewer frmPrint = new FrmRptInvoiceViewer();
            frmPrint.SalesOrderId = txtSalesOrderId.Text.Trim();
            frmPrint.ShowDialog();
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
                case "NET-07":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(7);
                    break;
                case "NET-14":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(14);
                    break;
                case "NET-21":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(21);
                    break;
                case "NET-30":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(30);
                    break;
                case "NET-45":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(45);
                    break;
                case "NET-60":
                    dtpDueDate.Value = dtpSalesOrderDate.Value.AddDays(60);
                    break;
                case "EOM":
                    dtpDueDate.Value = commonHelper.GetEndOfMonth(dtpSalesOrderDate.Value);
                    break;

                default:
                    break;
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodId = cbProduct.SelectedValue.ToString();

            var uow = new UnitOfWork<Product>(dbContext);
            var queryResult = uow.Repository.GetById(prodId);
            if (queryResult == null) return;
            
            txtPrice.Text = queryResult.Price.ToString("G29");
            txtDiscount.Text = queryResult.Discount.ToString().Replace('.',',');
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesOrderData(txtSalesNo.Text.Trim());
            SetUIButtonGroup();
        }

        private void dgvSalesOrderItem_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetTotalSalesOrder();
        }

        private void txtExtraDiscount_Leave(object sender, EventArgs e)
        {
            commonHelper.SetTextBoxToZeroWhenEmpty(sender);

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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalesNo.Text = string.Empty;
            lblSalesNo.Text = string.Empty;
            cbCustomer.SelectedValue = "0";
            cbSalesman.SelectedValue = "0";
            cbTermOfPayment.SelectedValue = "0";
            cbSalesArea.SelectedValue = "0";
            dtpSalesOrderDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            txtDeliveryAddress.Text = string.Empty;
            cbProvince.SelectedValue = "0";
            txtSubTotal.Text = "0";
            txtExtraDiscount.Text = "0";
            txtTaxBaseAmount.Text = "0";
            txtValueAddedTaxAmount.Text = "0";
            lblTotal.Text = "0";
            lblMark.Visible = false;

            SetUI();
            isAdd = true;
            SetUIButtonGroup();
            dgvSalesOrderItem.Rows.Clear();
            dgvSalesOrderItem.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            using (var dbContextTransaction = dbContext.Database.BeginTransaction())
            {
                var customer = new UnitOfWork<Customer>(dbContext).Repository.GetById(cbCustomer.SelectedValue.ToString());
                var salesman = new UnitOfWork<Salesman>(dbContext).Repository.GetById(cbSalesman.SelectedValue.ToString());
                var top = new UnitOfWork<TermOfPayment>(dbContext).Repository.GetById(cbTermOfPayment.SelectedValue.ToString());
                var salesArea = new UnitOfWork<SalesArea>(dbContext).Repository.GetById(cbSalesArea.SelectedValue.ToString());
                var district = new UnitOfWork<Location>(dbContext).Repository.GetById(cbDistrict.SelectedValue.ToString());

                #region parent 
                var uwSalesOrder = new UnitOfWork<SalesOrder>(dbContext);
                var soToAdd = new SalesOrder();
                soToAdd.SalesNo = CreateSalesOrderNo();
                soToAdd.CustomerId = cbCustomer.SelectedValue.ToString();
                soToAdd.CustomerName = customer.CustomerName;
                soToAdd.CustomerAddress = customer.Address;
                soToAdd.CustomerProvinceId = customer.ProvinceId;
                soToAdd.CustomerProvince = GetLocationName(customer.ProvinceId);
                soToAdd.CustomerDistrictId = customer.DistrictId;
                soToAdd.CustomerDistrict = GetLocationName(customer.DistrictId);
                soToAdd.CustomerPostalCode = customer.PostalCode;
                soToAdd.CustomerPhone = customer.Phone;
                soToAdd.CustomerEmail = customer.Email;
                soToAdd.CustomerNpwp = customer.Npwp;
                soToAdd.DeliveryAddress = txtDeliveryAddress.Text;
                soToAdd.DeliveryProvinceId = cbProvince.SelectedValue.ToString();
                soToAdd.DeliveryProvince = GetLocationName(cbProvince.SelectedValue.ToString());
                soToAdd.DeliveryDistrictId = cbDistrict.SelectedValue.ToString();
                soToAdd.DeliveryDistrict = GetLocationName(cbDistrict.SelectedValue.ToString());
                soToAdd.SalesAreaId = cbSalesArea.SelectedValue.ToString();
                soToAdd.SalesAreaCode = salesArea.AreaCode;
                soToAdd.SalesDate = dtpSalesOrderDate.Value;
                soToAdd.TermOfPaymentId = cbTermOfPayment.SelectedValue.ToString();
                soToAdd.TermOfPaymentCode = top.TermCode;
                soToAdd.DueDate = dtpDueDate.Value;
                soToAdd.PersonInCharge = Properties.Settings.Default.SalesPicName;
                soToAdd.SipaNo = Properties.Settings.Default.SalesPicSipaNo;
                soToAdd.SalesmanId = cbSalesman.SelectedValue.ToString();
                soToAdd.SalesmanCode = salesman.SalesmanCode;
                soToAdd.SubTotalAmount = decimal.Parse(txtSubTotal.Text.Trim(), System.Globalization.NumberStyles.Currency);
                soToAdd.ExtraDiscountAmount = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                soToAdd.TaxBaseAmount = decimal.Parse(txtTaxBaseAmount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                soToAdd.ValueAddedTaxAmount = decimal.Parse(txtValueAddedTaxAmount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                soToAdd.GrandTotalAmount = decimal.Parse(lblTotal.Text.Trim(), System.Globalization.NumberStyles.Currency);
                soToAdd.UserId = Properties.Settings.Default.CurrentUserId;
                soToAdd.Username = Properties.Settings.Default.CurrentUser;
                soToAdd.Status = Constant.RecordStatus.Active;
                soToAdd.CreatedBy = Properties.Settings.Default.CurrentUserId;
                soToAdd.CreatedAt = DateTime.Now;
                soToAdd.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                soToAdd.ModifiedAt = DateTime.Now;

                uwSalesOrder.Repository.Add(soToAdd);
                uwSalesOrder.Commit();

                #endregion parent 

                #region child 

                var uwSoItem = new UnitOfWork<SalesOrderItem>(dbContext);
                for (int i = 0; i < dgvSalesOrderItem.Rows.Count; ++i)
                {
                    if (dgvSalesOrderItem.Rows[i].Cells["productCode"].Value == null) continue;

                    DateTime expiredDate = DateTime.Parse(dgvSalesOrderItem.Rows[i].Cells["expDate"].Value.ToString());
                    expiredDate = commonHelper.GetEndOfMonth(expiredDate);

                    var qty = Convert.ToInt32(decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["qty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    var priceReal = Math.Round(decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["priceReal"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                        5, MidpointRounding.AwayFromZero);
                    var subTotalReal = Math.Round(qty * priceReal, 5, MidpointRounding.AwayFromZero);

                    var soiToAdd = new SalesOrderItem
                    {
                        SalesOrderId = soToAdd.Id,
                        ProductId = dgvSalesOrderItem.Rows[i].Cells["productId"].Value.ToString(),
                        ProductCode = dgvSalesOrderItem.Rows[i].Cells["productCode"].Value.ToString(),
                        ProductName = dgvSalesOrderItem.Rows[i].Cells["productName"].Value.ToString(),
                        BatchId = dgvSalesOrderItem.Rows[i].Cells["batchId"].Value.ToString(),
                        BatchCode = dgvSalesOrderItem.Rows[i].Cells["batchCode"].Value.ToString(),
                        ExpiredDate = commonHelper.StandardizeDate(expiredDate),
                        Quantity = qty,
                        UomId = dgvSalesOrderItem.Rows[i].Cells["uomId"].Value.ToString(),
                        UomCode = dgvSalesOrderItem.Rows[i].Cells["uomCode"].Value.ToString(),
                        Price = priceReal,
                        DiscountPercentage = float.Parse(dgvSalesOrderItem.Rows[i].Cells["discPercent"].Value.ToString().Replace("%", "")),
                        TotalAmount = subTotalReal,

                        // Audit Fields 
                        CreatedBy = Properties.Settings.Default.CurrentUserId,
                        CreatedAt = DateTime.Now,
                        ModifiedBy = Properties.Settings.Default.CurrentUserId,
                        ModifiedAt = DateTime.Now
                    };
                    uwSoItem.Repository.Add(soiToAdd);
                }
                var res = uwSoItem.Commit();

                #endregion child 

                dbContextTransaction.Commit();

                // when commit succeed, update the key fields
                lblSalesNo.Text = soToAdd.SalesNo;
                txtSalesOrderId.Text = soToAdd.Id;
                txtModifiedAt.Text = soToAdd.ModifiedAt.ToString();

            }

            NavigateRecord(RecordNavigation.Last);
            CommonMessageHelper.DataSavedSuccessfully();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = _uow.Repository.GetById(txtSalesOrderId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(lblSalesNo.Text.Trim());
            }
            else
            {
                using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                {
                    var customerId = cbCustomer.SelectedValue.ToString();
                    var customer = new UnitOfWork<Customer>(dbContext).Repository.GetById(customerId);
                    var salesman = new UnitOfWork<Salesman>(dbContext).Repository.GetById(cbSalesman.SelectedValue.ToString());
                    var top = new UnitOfWork<TermOfPayment>(dbContext).Repository.GetById(cbTermOfPayment.SelectedValue.ToString());
                    var salesArea = new UnitOfWork<SalesArea>(dbContext).Repository.GetById(cbSalesArea.SelectedValue.ToString());
                    var prov = new UnitOfWork<Location>(dbContext).Repository.GetById(cbProvince.SelectedValue.ToString());
                    var district = new UnitOfWork<Location>(dbContext).Repository.GetById(cbDistrict.SelectedValue.ToString());

                    #region parent 
                    var uwSalesOrder = new UnitOfWork<SalesOrder>(dbContext);
                    var soToUpdate = uwSalesOrder.Repository.GetById(txtSalesOrderId.Text.Trim());

                    soToUpdate.CustomerId = customerId ;
                    soToUpdate.CustomerName = customer.CustomerName;
                    soToUpdate.CustomerAddress = customer.Address;
                    soToUpdate.CustomerProvinceId = customer.ProvinceId;
                    soToUpdate.CustomerProvince = GetLocationName(customer.ProvinceId);
                    soToUpdate.CustomerDistrictId = customer.DistrictId;
                    soToUpdate.CustomerDistrict = GetLocationName(customer.DistrictId);
                    soToUpdate.CustomerPostalCode = customer.PostalCode;
                    soToUpdate.CustomerPhone = customer.Phone;
                    soToUpdate.CustomerEmail = customer.Email;
                    soToUpdate.CustomerNpwp = customer.Npwp;
                    soToUpdate.SalesmanId = cbSalesman.SelectedValue.ToString();
                    soToUpdate.SalesmanCode = salesman.SalesmanCode;
                    soToUpdate.TermOfPaymentId = cbTermOfPayment.SelectedValue.ToString();
                    soToUpdate.TermOfPaymentCode = top.TermCode;
                    soToUpdate.SalesDate = dtpSalesOrderDate.Value;
                    soToUpdate.DueDate = dtpDueDate.Value;
                    soToUpdate.DeliveryAddress = txtDeliveryAddress.Text;
                    soToUpdate.DeliveryProvinceId = cbProvince.SelectedValue.ToString();
                    soToUpdate.DeliveryProvince = prov.Name;
                    soToUpdate.DeliveryDistrictId = cbDistrict.SelectedValue.ToString();
                    soToUpdate.DeliveryDistrict = district.Name;
                    soToUpdate.SalesAreaId = cbSalesArea.SelectedValue.ToString();
                    soToUpdate.SalesAreaCode = salesArea.AreaCode;
                    soToUpdate.SubTotalAmount = decimal.Parse(txtSubTotal.Text.Trim(), System.Globalization.NumberStyles.Currency);
                    soToUpdate.ExtraDiscountAmount = decimal.Parse(txtExtraDiscount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                    soToUpdate.TaxBaseAmount = decimal.Parse(txtTaxBaseAmount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                    soToUpdate.ValueAddedTaxAmount = decimal.Parse(txtValueAddedTaxAmount.Text.Trim(), System.Globalization.NumberStyles.Currency);
                    soToUpdate.GrandTotalAmount = decimal.Parse(lblTotal.Text.Trim(), System.Globalization.NumberStyles.Currency);
                    soToUpdate.UserId = Properties.Settings.Default.CurrentUserId;
                    soToUpdate.Username = Properties.Settings.Default.CurrentUser;

                    // Audit fields
                    soToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                    soToUpdate.ModifiedAt = DateTime.Now;

                    uwSalesOrder.Repository.Update(soToUpdate);
                    uwSalesOrder.Commit();

                    #endregion parent 

                    #region child 

                    var uwSoItem = new UnitOfWork<SalesOrderItem>(dbContext);

                    // clear all item for the identified Sales Order
                    var tobeClearedItems = uwSoItem.Repository.GetAll().Where(soi => soi.SalesOrderId == txtSalesOrderId.Text.Trim());
                    uwSoItem.Repository.Delete(tobeClearedItems);
                    uwSoItem.Commit();

                    // add with updated items
                    List<SalesOrderItem> orderItems = new List<SalesOrderItem>();
                    for (int i = 0; i < dgvSalesOrderItem.Rows.Count; ++i)
                    {
                        if (dgvSalesOrderItem.Rows[i].Cells["productCode"].Value == null) continue;

                        var expiredDate = commonHelper.GetEndOfMonth(DateTime.Parse(dgvSalesOrderItem.Rows[i].Cells["expDate"].Value.ToString()));
                        var qty = Convert.ToInt32(decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["qty"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        var priceReal = Math.Round(decimal.Parse(dgvSalesOrderItem.Rows[i].Cells["priceReal"].Value.ToString(), System.Globalization.NumberStyles.Currency),
                            5, MidpointRounding.AwayFromZero);
                        var subTotalReal = Math.Round(qty * priceReal, 5, MidpointRounding.AwayFromZero);

                        var soiToUpdate = new SalesOrderItem
                        {
                            SalesOrderId = txtSalesOrderId.Text.Trim(),
                            ProductId = dgvSalesOrderItem.Rows[i].Cells["productId"].Value.ToString(),
                            ProductCode = dgvSalesOrderItem.Rows[i].Cells["productCode"].Value.ToString(),
                            ProductName = dgvSalesOrderItem.Rows[i].Cells["productName"].Value.ToString(),
                            BatchId = dgvSalesOrderItem.Rows[i].Cells["batchId"].Value.ToString(),
                            BatchCode = dgvSalesOrderItem.Rows[i].Cells["batchCode"].Value.ToString(),
                            ExpiredDate = commonHelper.StandardizeDate(expiredDate),
                            Quantity = qty,
                            UomId = dgvSalesOrderItem.Rows[i].Cells["uomId"].Value.ToString(),
                            UomCode = dgvSalesOrderItem.Rows[i].Cells["uomCode"].Value.ToString(),
                            Price = priceReal,
                            DiscountPercentage = float.Parse(dgvSalesOrderItem.Rows[i].Cells["discPercent"].Value.ToString().Replace("%", "")),
                            TotalAmount = subTotalReal,

                            // Audit Fields 
                            CreatedBy = Properties.Settings.Default.CurrentUserId,
                            CreatedAt = DateTime.Now,
                            ModifiedBy = Properties.Settings.Default.CurrentUserId,
                            ModifiedAt = DateTime.Now
                        };
                        orderItems.Add(soiToUpdate);
                    }
                    uwSoItem.Repository.Add(orderItems);
                    uwSoItem.Commit();

                    #endregion child 

                    dbContextTransaction.Commit();
                }

                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var soToDel = _uow.Repository.GetById(txtSalesOrderId.Text.Trim());

            if (soToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {

                    // delete the sales order
                    soToDel.Status = Constant.RecordStatus.Inactive;
                    _uow.Repository.Update(soToDel);
                    var res = _uow.Commit();

                    if (!res.Item1 && res.Item2 == "Expected")
                    {
                        CommonMessageHelper.ReferredDataCannotBeDeleted();
                    }

                    if (!res.Item1 && res.Item2 == "Unexpected")
                    {
                        CommonMessageHelper.ContactAdminError();
                    }

                    LoadSalesOrderData(soToDel.SalesNo);
                }
            }
            else
            {
                CommonMessageHelper.DataNotFound(lblSalesNo.Text.Trim());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSalesNo.Text))
            {
                btnClear.PerformClick();
                return;
            }

            SalesOrder queryResult;
            queryResult = _uow.Repository.GetById(txtSalesOrderId.Text.Trim());
            if (queryResult == null)
            {
                CommonMessageHelper.DataNotFound(lblSalesNo.Text.Trim());
                return;
            }
            LoadDataItem(queryResult);

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            commonHelper.SetTextBoxToZeroWhenEmpty(sender);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            commonHelper.SetTextBoxToZeroWhenEmpty(sender);
        }

        private void txtBatch_Leave(object sender, EventArgs e)
        {
            var uow = new UnitOfWork<Batch>(dbContext);
            var queryResult = uow.Repository.GetAll().Where(b => b.BatchCode.Equals(txtBatch.Text.Trim())).FirstOrDefault();
            if (queryResult == null) return;
            dtpExpiredDate.Value = queryResult.ExpiredDate;

            txtQty.Focus();
        }
    }
}
