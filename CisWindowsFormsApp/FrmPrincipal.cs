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
    public partial class FrmPrincipal : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Principal> uowPrincipal;
        bool isAdd = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            uowPrincipal = new UnitOfWork<Principal>(dbContext);

            BindPrincipalGridView();
            SetUIGridView();
            BindLocationComboBox(cbProvince, Constant.LocationType.Province);

            isAdd = true;
            SetUIButtonGroup();

            txtPrincipalName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();

            txtPrincipalName.Focus();
            txtPrincipalName.Text = string.Empty;
            txtAddress.Text = string.Empty;

            BindLocationComboBox(cbProvince, Constant.LocationType.Province);
            BindLocationComboBox(cbDistrict, Constant.LocationType.District);
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict);

            txtPostCode.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtPrincipalId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingPrincipal = uowPrincipal.Repository.GetAll().Where(r => r.PrincipalName == txtPrincipalName.Text.Trim()).FirstOrDefault();
            if (existingPrincipal != null)
            {
                CommonHelper.DataAlreadyExistMessage(txtPrincipalName.Text.Trim());
            }
            else
            {
                var PrincipalToAdd = new Principal
                {
                    PrincipalName = txtPrincipalName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    ProvinceId = cbProvince.SelectedValue.ToString(),
                    DistrictId = cbDistrict.SelectedValue.ToString(),
                    SubDistrictId = cbSubDistrict.SelectedValue.ToString(),

                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowPrincipal.Repository.Add(PrincipalToAdd);
                uowPrincipal.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = DateTime.Parse(dgvPrincipal.CurrentRow.Cells[nameof(Principal.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                CommonHelper.DataHasBeenUpdatedMessage(txtPrincipalName.Text.Trim());
            }
            else
            {
                var PrincipalToUpdate = uowPrincipal.Repository.GetById(txtPrincipalId.Text.Trim());
                PrincipalToUpdate.PrincipalName = txtPrincipalName.Text.Trim();
                PrincipalToUpdate.Address = txtAddress.Text.Trim();
                PrincipalToUpdate.PostalCode = txtPostCode.Text.Trim();
                PrincipalToUpdate.Phone = txtPhone.Text.Trim();
                PrincipalToUpdate.Email = txtEmail.Text.Trim();
                PrincipalToUpdate.ProvinceId = cbProvince.SelectedValue.ToString();
                PrincipalToUpdate.DistrictId = cbDistrict.SelectedValue.ToString();
                PrincipalToUpdate.SubDistrictId = cbSubDistrict.SelectedValue.ToString();

                PrincipalToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                PrincipalToUpdate.ModifiedAt = DateTime.Now;

                uowPrincipal.Repository.Update(PrincipalToUpdate);
                uowPrincipal.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowPrincipal.Repository.GetAll().Where(u => u.PrincipalName == txtPrincipalName.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == CommonHelper.ConfirmDeleteMessage())
                {
                    uowPrincipal.Repository.Delete(roleToDel);
                    var res = uowPrincipal.Commit();
                    if (!res.Item1 && res.Item2 == "Expected")
                    {
                        CommonHelper.ReferredDataCannotBeDeletedMessage();
                    }

                    if (!res.Item1 && res.Item2 == "Unexpected")
                    {
                        CommonHelper.ContactAdminErrorMessage();
                    }
                    btnReload.PerformClick();
                }
            }
            else
            {
                CommonHelper.DataNotFoundMessage(txtPrincipalName.Text.Trim());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowPrincipal.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindPrincipalGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindPrincipalGridView();
                    SetUIGridView();
                    dgvPrincipal.CurrentCell = this.dgvPrincipal[1, 0];
                }
                gvSelectedIndex = dgvPrincipal.CurrentRow.Index;
                BindPrincipalGridView();
                SetUIGridView();
                dgvPrincipal.CurrentCell = this.dgvPrincipal[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvPrincipal.CurrentRow.Cells[nameof(Principal.ModifiedAt)].Value.ToString();
            }
            isAdd = dgvPrincipal.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void dgvPrincipal_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());
        }
        

        private void BindPrincipalGridView()
        {
            var salesmen = new UnitOfWork<Principal>(dbContext).Repository.GetAll().OrderBy(s => s.PrincipalName);
            var uomDetail = salesmen.Select(Principal =>
            new
            {
                Principal.Id,
                Principal.PrincipalName,
                Principal.Address,
                Principal.ProvinceId,
                Principal.DistrictId,
                Principal.SubDistrictId,
                Principal.PostalCode,
                Principal.Phone,
                Principal.Email,
                Principal.ModifiedAt
            });

            dgvPrincipal.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvPrincipal.Columns[nameof(Principal.PrincipalName)].HeaderText = "NAMA PRINCIPAL";
            dgvPrincipal.Columns[nameof(Principal.PrincipalName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPrincipal.Columns[nameof(Principal.Address)].HeaderText = "ALAMAT";
            dgvPrincipal.Columns[nameof(Principal.Address)].Width = 300;
            dgvPrincipal.Columns[nameof(Principal.Phone)].HeaderText = "TELEPON";
            dgvPrincipal.Columns[nameof(Principal.Phone)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPrincipal.Columns[nameof(Principal.Email)].HeaderText = "EMAIL";
            dgvPrincipal.Columns[nameof(Principal.Email)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPrincipal.Columns[nameof(Principal.Id)].Visible = false;
            dgvPrincipal.Columns[nameof(Principal.ProvinceId)].Visible = false;
            dgvPrincipal.Columns[nameof(Principal.DistrictId)].Visible = false;
            dgvPrincipal.Columns[nameof(Principal.SubDistrictId)].Visible = false;
            dgvPrincipal.Columns[nameof(Principal.PostalCode)].Visible = false;
            dgvPrincipal.Columns[nameof(Principal.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvPrincipal.CurrentRow;
            txtPrincipalName.Text = currentRow.Cells[nameof(Principal.PrincipalName)].Value.ToString();
            txtAddress.Text = currentRow.Cells[nameof(Principal.Address)].Value.ToString();
            cbProvince.SelectedValue = currentRow.Cells[nameof(Principal.ProvinceId)].Value.ToString();
            cbDistrict.SelectedValue = currentRow.Cells[nameof(Principal.DistrictId)].Value.ToString();
            cbSubDistrict.SelectedValue = currentRow.Cells[nameof(Principal.SubDistrictId)].Value.ToString();
            txtPostCode.Text = currentRow.Cells[nameof(Principal.PostalCode)].Value.ToString();
            txtPhone.Text = currentRow.Cells[nameof(Principal.Phone)].Value.ToString();
            txtEmail.Text = currentRow.Cells[nameof(Principal.Email)].Value.ToString();

            // hidden fields
            txtPrincipalId.Text = currentRow.Cells[nameof(Principal.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Principal.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtPrincipalName.Text))
            {
                CommonHelper.DataCannotBeEmptyMessage("Kode Sales dan Nama Lengkap");
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

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
        }
    }
}
