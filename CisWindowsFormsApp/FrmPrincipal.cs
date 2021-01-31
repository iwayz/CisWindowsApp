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
        List<int> foundIndices = new List<int>();
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

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
            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);

            isAdd = true;
            SetUIButtonGroup();

            txtPrincipalCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();

            txtPrincipalCode.Focus();
            txtPrincipalCode.Text = string.Empty;
            txtPrincipalName.Text = string.Empty;
            txtAddress.Text = string.Empty;

            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.Province);
            commonHelper.BindLocationComboBox(dbContext, cbSubDistrict, Constant.LocationType.Province);

            txtPostCode.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtPrincipalId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingPrincipal = uowPrincipal.Repository.GetAll().Where(r => r.PrincipalCode == txtPrincipalCode.Text.Trim()).FirstOrDefault();
            if (existingPrincipal != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtPrincipalCode.Text.Trim());
            }
            else
            {
                var PrincipalToAdd = new Principal
                {
                    PrincipalCode = txtPrincipalCode.Text.Trim(),
                    PrincipalName = txtPrincipalName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    ProvinceId = cbProvince.SelectedValue.ToString(),
                    DistrictId = cbDistrict.SelectedValue.ToString(),
                    SubDistrictId = cbSubDistrict.SelectedValue.ToString(),

                     					 // Audit Fields 					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowPrincipal.Repository.Add(PrincipalToAdd);
                uowPrincipal.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowPrincipal.Repository.GetById(txtPrincipalId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtPrincipalCode.Text.Trim());
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

                PrincipalToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                PrincipalToUpdate.ModifiedAt = DateTime.Now;

                uowPrincipal.Repository.Update(PrincipalToUpdate);
                uowPrincipal.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowPrincipal.Repository.GetAll().Where(u => u.PrincipalCode== txtPrincipalCode.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowPrincipal.Repository.Delete(roleToDel);
                    var res = uowPrincipal.Commit();
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
                CommonMessageHelper.DataNotFound(txtPrincipalCode.Text.Trim());
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
                dgvPrincipal.CurrentCell = this.dgvPrincipal[1, isAdd ? dgvPrincipal.RowCount-1 : (gvSelectedIndex < dgvPrincipal.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvPrincipal.CurrentRow.Cells[nameof(Principal.ModifiedAt)].Value.ToString();
            }
            SetUIButtonGroup();
        }

        private void dgvPrincipal_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());
        }
        

        private void BindPrincipalGridView()
        {
            var principal = new UnitOfWork<Principal>(dbContext).Repository.GetAll().OrderBy(s => s.PrincipalCode);
            var principalDetail = principal.Select(Principal =>
            new
            {
                Principal.Id,
                Principal.PrincipalCode,
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

            dgvPrincipal.DataSource = principalDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvPrincipal.Columns[nameof(Principal.PrincipalCode)].HeaderText = "KODE PRINCIPAL";
            dgvPrincipal.Columns[nameof(Principal.PrincipalCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
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
            txtPrincipalCode.Text = currentRow.Cells[nameof(Principal.PrincipalCode)].Value.ToString();
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
            if (string.IsNullOrEmpty(txtPrincipalCode.Text) || string.IsNullOrEmpty(txtPrincipalName.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Principal dan Nama Principal");
                return false;

            }
            return true;
        }

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvPrincipal, ref foundIndices);
            dgvPrincipal.CurrentCell = dgvPrincipal[1, idx];
            SetUIbySelectedGridItem();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                && e.KeyChar != '/' && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ' ';
        }
    }
}
