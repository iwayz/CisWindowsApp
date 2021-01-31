using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmCustomer : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Customer> uowCust;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmCustomer()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            uowCust = new UnitOfWork<Customer>(dbContext);

            BindCustomerGridView();
            SetUIGridView();
            BindLocationComboBox(cbProvince, Constant.LocationType.Province);
            BindOutletTypeComboBox();
            BindComboBoxSalesArea();

            isAdd = true;
            SetUIButtonGroup();

            txtCustomerCode.Focus();
            if (string.IsNullOrEmpty(txtSipaNo.Text))
                dtpSipaExpiredDate.Value = DateTime.Parse("1900-01-01");
            CheckSourceRefData();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();

            txtCustomerCode.Focus();
            txtCustomerCode.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;

            BindLocationComboBox(cbProvince, Constant.LocationType.Province);
            BindLocationComboBox(cbDistrict, Constant.LocationType.District);
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict);

            txtPostCode.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNpwp.Text = string.Empty;
            txtPharmacistName.Text = string.Empty;
            txtSipaNo.Text = string.Empty;
            dtpSipaExpiredDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            txtSiaNo.Text = string.Empty;

            BindOutletTypeComboBox();
            BindComboBoxSalesArea();

            txtCustomerId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingCust = uowCust.Repository.GetAll()
                .Where(r => r.CustomerCode == txtCustomerCode.Text.Trim()
                && r.Address == txtAddress.Text.Trim())
                .FirstOrDefault();

            if (existingCust != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtCustomerCode.Text.Trim() + " dengan alamat " + txtAddress.Text.Trim());
            }
            else
            {
                var custToAdd = new Customer
                {
                    CustomerCode = txtCustomerCode.Text.Trim(),
                    CustomerName = txtCustomerName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    ProvinceId = cbProvince.SelectedValue.ToString(),
                    DistrictId = cbDistrict.SelectedValue.ToString(),
                    SubDistrictId = cbSubDistrict.SelectedValue.ToString(),
                    PostalCode = txtPostCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Npwp = txtNpwp.Text.Trim(),
                    PharmacistName = txtPharmacistName.Text.Trim(),
                    SipaNo = txtSipaNo.Text.Trim(),
                    SipaExpiredDate = DateTime.Parse(dtpSipaExpiredDate.Value.ToString("yyyy-MM-dd")),
                    SiaNo = txtSiaNo.Text.Trim(),
                    OutletTypeId = cbOutletType.SelectedValue.ToString(),
                    SalesAreaId = cbSalesArea.SelectedValue.ToString(),

                    
 					 // Audit Fields 
					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowCust.Repository.Add(custToAdd);
                uowCust.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowCust.Repository.GetById(txtCustomerId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtCustomerCode.Text.Trim());
            }
            else
            {
                var custToUpdate = uowCust.Repository.GetById(txtCustomerId.Text.Trim());
                custToUpdate.CustomerCode= txtCustomerCode.Text.Trim();
                custToUpdate.CustomerName = txtCustomerName.Text.Trim();
                custToUpdate.Address = txtAddress.Text.Trim();
                custToUpdate.ProvinceId = cbProvince.SelectedValue.ToString();
                custToUpdate.DistrictId = cbDistrict.SelectedValue.ToString();
                custToUpdate.SubDistrictId = cbSubDistrict.SelectedValue.ToString();
                custToUpdate.PostalCode = txtPostCode.Text.Trim();
                custToUpdate.Phone = txtPhone.Text.Trim();
                custToUpdate.Email = txtEmail.Text.Trim();
                custToUpdate.Npwp = txtNpwp.Text.Trim();
                custToUpdate.PharmacistName = txtPharmacistName.Text.Trim();
                custToUpdate.SipaNo = txtSipaNo.Text.Trim();
                custToUpdate.SipaExpiredDate = DateTime.Parse(dtpSipaExpiredDate.Value.ToString("yyyy-MM-dd"));
                custToUpdate.SiaNo = txtSiaNo.Text.Trim();
                custToUpdate.OutletTypeId = cbOutletType.SelectedValue.ToString();
                custToUpdate.SalesAreaId = cbSalesArea.SelectedValue.ToString();

                custToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                custToUpdate.ModifiedAt = DateTime.Now;

                uowCust.Repository.Update(custToUpdate);
                uowCust.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowCust.Repository.GetAll()
                .Where(r => r.CustomerCode== txtCustomerCode.Text.Trim()
                && r.Address == txtAddress.Text.Trim())
                .FirstOrDefault();

            if (roleToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowCust.Repository.Delete(roleToDel);
                    var res = uowCust.Commit();
                    if (!res.Item1 && res.Item2 == "Expected")
                    {
                        CommonMessageHelper.ReferredDataCannotBeDeleted();
                    }

                    if (!res.Item1 && res.Item2 == "Unexpected")
                    {
                        CommonMessageHelper.ContactAdminError();
                    }
                    btnReload.PerformClick();
                }
            }
            else
            {
                CommonMessageHelper.DataNotFound(txtCustomerCode.Text.Trim());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowCust.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindCustomerGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindCustomerGridView();
                    SetUIGridView();
                    dgvCustomer.CurrentCell = this.dgvCustomer[1, 0];
                }
                gvSelectedIndex = dgvCustomer.CurrentRow.Index;
                BindCustomerGridView();
                SetUIGridView();
                dgvCustomer.CurrentCell = this.dgvCustomer[1, isAdd ? dgvCustomer.RowCount-1 : (gvSelectedIndex < dgvCustomer.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvCustomer.CurrentRow.Cells[nameof(Customer.ModifiedAt)].Value.ToString();
            }
            SetUIButtonGroup();
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());

        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());

        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BindCustomerGridView()
        {
            var salesmen = new UnitOfWork<Customer>(dbContext).Repository.GetAll().OrderBy(s => s.CustomerName);
            var uomDetail = salesmen.Select(salesman =>
            new
            {
                salesman.Id,
                salesman.CustomerCode,
                salesman.CustomerName,
                salesman.Address,
                salesman.ProvinceId,
                salesman.DistrictId,
                salesman.SubDistrictId,
                salesman.PostalCode,
                salesman.Phone,
                salesman.Email,
                salesman.Npwp,
                salesman.PharmacistName,
                salesman.SipaNo,
                salesman.SipaExpiredDate,
                salesman.SiaNo,
                salesman.OutletTypeId,
                salesman.SalesAreaId,
                salesman.ModifiedAt
            });

            dgvCustomer.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvCustomer.Columns[nameof(Customer.CustomerCode)].HeaderText = "KODE PELANGGAN";
            dgvCustomer.Columns[nameof(Customer.CustomerCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            dgvCustomer.Columns[nameof(Customer.CustomerName)].HeaderText = "NAMA PELANGGAN";
            dgvCustomer.Columns[nameof(Customer.CustomerName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[nameof(Customer.Address)].HeaderText = "ALAMAT";
            dgvCustomer.Columns[nameof(Customer.Address)].Width = 300;
            dgvCustomer.Columns[nameof(Customer.Phone)].HeaderText = "TELEPON";
            dgvCustomer.Columns[nameof(Customer.Phone)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[nameof(Customer.Email)].HeaderText = "EMAIL";
            dgvCustomer.Columns[nameof(Customer.Email)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvCustomer.Columns[nameof(Customer.Id)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.ModifiedAt)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.ProvinceId)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.DistrictId)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.SubDistrictId)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.PostalCode)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.Npwp)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.PharmacistName)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.SipaNo)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.SipaExpiredDate)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.SiaNo)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.OutletTypeId)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.SalesAreaId)].Visible = false;
            dgvCustomer.Columns[nameof(Customer.ModifiedAt)].Visible = false;

        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvCustomer.CurrentRow;
            txtCustomerCode.Text = currentRow.Cells[nameof(Customer.CustomerCode)].Value.ToString();
            txtCustomerName.Text = currentRow.Cells[nameof(Customer.CustomerName)].Value.ToString();
            txtAddress.Text = currentRow.Cells[nameof(Customer.Address)].Value.ToString();
            cbProvince.SelectedValue = currentRow.Cells[nameof(Customer.ProvinceId)].Value.ToString();
            cbDistrict.SelectedValue = currentRow.Cells[nameof(Customer.DistrictId)].Value.ToString();
            cbSubDistrict.SelectedValue = currentRow.Cells[nameof(Customer.SubDistrictId)].Value.ToString();
            txtPostCode.Text = currentRow.Cells[nameof(Customer.PostalCode)].Value.ToString();
            txtPhone.Text = currentRow.Cells[nameof(Customer.Phone)].Value.ToString();
            txtEmail.Text = currentRow.Cells[nameof(Customer.Email)].Value.ToString();
            txtNpwp.Text = currentRow.Cells[nameof(Customer.Npwp)].Value.ToString();
            txtPharmacistName.Text = currentRow.Cells[nameof(Customer.PharmacistName)].Value.ToString();
            txtSipaNo.Text = currentRow.Cells[nameof(Customer.SipaNo)].Value.ToString();
            dtpSipaExpiredDate.Value = DateTime.Parse(currentRow.Cells[nameof(Customer.SipaExpiredDate)].Value.ToString());
            txtSiaNo.Text = currentRow.Cells[nameof(Customer.SiaNo)].Value.ToString();
            cbOutletType.SelectedValue = currentRow.Cells[nameof(Customer.OutletTypeId)].Value.ToString();
            cbSalesArea.SelectedValue = currentRow.Cells[nameof(Customer.SalesAreaId)].Value.ToString();

            // hidden fields
            txtCustomerId.Text = currentRow.Cells[nameof(Customer.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Customer.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtCustomerCode.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode, Nama Pelanggan dan Alamat");
                return false;

            }

            if (cbOutletType.Items.Count <= 1 || cbSalesArea.Items.Count <= 1)
            {
                var emptyRefData = cbOutletType.Items.Count <= 1 ? "Jenis Outlet" : "Sales Area";
                CommonMessageHelper.ReferredDataNotSet(emptyRefData);
                return false;
            }

            return true;
        }

        private void BindLocationComboBox(ComboBox cbLocation, Constant.LocationType locationType, string parentId = "")
        {
            var uow = new UnitOfWork<Location>(dbContext);
            var locations = uow.Repository.GetAll();
            if (string.IsNullOrEmpty(parentId))
            {
                locations = locations
                    .Where(l => l.LocationType == locationType)
                    .OrderBy(l => l.Name);
            }
            else
            {
                locations = locations
                    .Where(l => l.LocationType == locationType && l.ParentId == parentId)
                    .OrderBy(l => l.Name);
            }
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsLocations = new Dictionary<string, string>();
            dsLocations.Add("0", "--Pilih--");
            foreach (var loc in locations)
            {
                dsLocations.Add(loc.Id, loc.Name);
                autoCompleteCollection.Add(loc.Name);
            }
            cbLocation.DataSource = new BindingSource(dsLocations, null);
            cbLocation.DisplayMember = "Value";
            cbLocation.ValueMember = "Key";
            cbLocation.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindOutletTypeComboBox()
        {
            var uow = new UnitOfWork<OutletType>(dbContext);
            var outletTypes = uow.Repository.GetAll().OrderBy(m => m.OutletTypeCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsOutlet = new Dictionary<string, string>();
            dsOutlet.Add("0", "--Pilih--");
            foreach (var outlet in outletTypes)
            {
                dsOutlet.Add(outlet.Id, outlet.OutletTypeCode + " - " + outlet.Description);
                autoCompleteCollection.Add(outlet.OutletTypeCode + " - " + outlet.Description);
            }

            cbOutletType.DataSource = new BindingSource(dsOutlet, null);
            cbOutletType.DisplayMember = "Value";
            cbOutletType.ValueMember = "Key";
            cbOutletType.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxSalesArea()
        {
            var uow = new UnitOfWork<SalesArea>(dbContext);
            var salesAreas = uow.Repository.GetAll().OrderBy(m => m.AreaCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsArea = new Dictionary<string, string>();
            dsArea.Add("0", "--Pilih--");
            foreach (var area in salesAreas)
            {
                dsArea.Add(area.Id, area.AreaCode +" - " + area.Description);
                autoCompleteCollection.Add(area.AreaCode + " - " + area.Description);
            }

            cbSalesArea.DataSource = new BindingSource(dsArea, null);
            cbSalesArea.DisplayMember = "Value";
            cbSalesArea.ValueMember = "Key";
            cbSalesArea.AutoCompleteCustomSource = autoCompleteCollection;
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
            if (cbOutletType.Items.Count <= 1) refData.Add("Jenit Outlet");
            if (cbSalesArea.Items.Count <= 1) refData.Add("Sales Area");

            lblNoteDetail.Text = "Data referensi (" + string.Join(", ", refData) + ") belum tersedia. ";
            if (refData.Count > 0) pnlNote.Visible = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvCustomer, ref foundIndices);
            dgvCustomer.CurrentCell = dgvCustomer[1, idx];
            SetUIbySelectedGridItem();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                && e.KeyChar != '/' && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ' ';
        }
    }
}
