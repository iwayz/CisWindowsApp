﻿using Cis.Data;
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
    public partial class FrmSalesman : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Salesman> uowSalesman;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();

        public FrmSalesman()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesman_Load(object sender, EventArgs e)
        {
            uowSalesman = new UnitOfWork<Salesman>(dbContext);

            BindRoleGridView();
            SetUIGridView();
            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);

            isAdd = true;
            SetUIButtonGroup();

            txtSalesmanCode.Focus();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            
            txtSalesmanCode.Focus();
            txtSalesmanCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            rbFemale.Checked = true;
            txtAddress.Text = string.Empty;

            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.Province);

            txtPostCode.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtSalesmanId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingSalesman = uowSalesman.Repository.GetAll().Where(r => r.SalesmanCode == txtSalesmanCode.Text.Trim()).FirstOrDefault();
            if (existingSalesman != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtSalesmanCode.Text.Trim());
            }
            else
            {
                var salesmanToAdd = new Salesman
                {
                    SalesmanCode = txtSalesmanCode.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Gender = rbFemale.Checked ? Constant.Gender.Female : Constant.Gender.Male,
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    ProvinceId = cbProvince.SelectedValue.ToString(),
                    DistrictId = cbDistrict.SelectedValue.ToString(),
                     					 // Audit Fields 					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowSalesman.Repository.Add(salesmanToAdd);
                uowSalesman.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowSalesman.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindRoleGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindRoleGridView();
                    SetUIGridView();
                    dgvSalesman.CurrentCell = this.dgvSalesman[1, 0];
                }
                gvSelectedIndex = dgvSalesman.CurrentRow.Index;
                BindRoleGridView();
                SetUIGridView();
                dgvSalesman.CurrentCell = this.dgvSalesman[1, isAdd ? dgvSalesman.RowCount-1 : (gvSelectedIndex < dgvSalesman.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvSalesman.CurrentRow.Cells[nameof(Salesman.ModifiedAt)].Value.ToString();
            }
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowSalesman.Repository.GetAll().Where(u => u.SalesmanCode == txtSalesmanCode.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        bool expectedError = false;
                        bool unexpectedError = false;
                        uowSalesman.Repository.Delete(roleToDel);
                        var res = uowSalesman.Commit();
                        if (!res.Item1 && res.Item2 == "Expected")
                        {
                            expectedError = true;
                            CommonMessageHelper.ReferredDataCannotBeDeleted();
                        }

                        if (!res.Item1 && res.Item2 == "Unexpected")
                        {
                            unexpectedError = true;
                            CommonMessageHelper.ContactAdminError();
                        }

                        if (expectedError || unexpectedError)
                        {
                            dbContextTransaction.Rollback();
                        }
                        else
                        {
                            dbContextTransaction.Commit();
                        }
                    }
                    btnReload.PerformClick();
                }
            }
            else
            {
                CommonMessageHelper.DataNotFound(txtSalesmanCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowSalesman.Repository.GetById(txtSalesmanId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtSalesmanCode.Text.Trim());
            }
            else
            {
                var salesmanToUpdate = uowSalesman.Repository.GetById(txtSalesmanId.Text.Trim());
                salesmanToUpdate.SalesmanCode = txtSalesmanCode.Text.Trim();
                salesmanToUpdate.FullName = txtFullName.Text.Trim();
                salesmanToUpdate.Gender = rbFemale.Checked ? Constant.Gender.Female : Constant.Gender.Male;
                salesmanToUpdate.Address = txtAddress.Text.Trim();
                salesmanToUpdate.PostalCode = txtPostCode.Text.Trim();
                salesmanToUpdate.Phone = txtPhone.Text.Trim();
                salesmanToUpdate.Email = txtEmail.Text.Trim();
                salesmanToUpdate.ProvinceId = cbProvince.SelectedValue.ToString();
                salesmanToUpdate.DistrictId = cbDistrict.SelectedValue.ToString();

                salesmanToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                salesmanToUpdate.ModifiedAt = DateTime.Now;

                uowSalesman.Repository.Update(salesmanToUpdate);
                uowSalesman.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void dgvSalesman_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BindRoleGridView()
        {
            var salesmen = new UnitOfWork<Salesman>(dbContext).Repository.GetAll().OrderBy(s => s.SalesmanCode);
            var uomDetail = salesmen.Select(salesman =>
            new
            {
                salesman.Id,
                salesman.SalesmanCode,
                salesman.FullName,
                salesman.Gender,
                salesman.Address,
                salesman.ProvinceId,
                salesman.DistrictId,
                salesman.PostalCode,
                salesman.Phone,
                salesman.Email,
                salesman.ModifiedAt
            });

            dgvSalesman.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvSalesman.Columns[nameof(Salesman.SalesmanCode)].HeaderText = "KODE SALESMAN";
            dgvSalesman.Columns[nameof(Salesman.SalesmanCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSalesman.Columns[nameof(Salesman.FullName)].HeaderText = "NAMA LENGKAP";
            dgvSalesman.Columns[nameof(Salesman.FullName)].Width = 200;
            dgvSalesman.Columns[nameof(Salesman.Gender)].HeaderText = "GENDER";
            dgvSalesman.Columns[nameof(Salesman.Gender)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSalesman.Columns[nameof(Salesman.Address)].HeaderText = "ALAMAT";
            dgvSalesman.Columns[nameof(Salesman.Address)].Width = 300;
            dgvSalesman.Columns[nameof(Salesman.Phone)].HeaderText = "TELEPON";
            dgvSalesman.Columns[nameof(Salesman.Phone)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSalesman.Columns[nameof(Salesman.Email)].HeaderText = "EMAIL";
            dgvSalesman.Columns[nameof(Salesman.Email)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSalesman.Columns[nameof(Salesman.Id)].Visible = false;
            dgvSalesman.Columns[nameof(Salesman.ProvinceId)].Visible = false;
            dgvSalesman.Columns[nameof(Salesman.DistrictId)].Visible = false;
            dgvSalesman.Columns[nameof(Salesman.PostalCode)].Visible = false;
            dgvSalesman.Columns[nameof(Salesman.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvSalesman.CurrentRow;
            txtSalesmanCode.Text = currentRow.Cells[nameof(Salesman.SalesmanCode)].Value.ToString();
            txtFullName.Text = currentRow.Cells[nameof(Salesman.FullName)].Value.ToString();
            rbFemale.Checked = currentRow.Cells[nameof(Salesman.Gender)].Value.ToString() == Constant.Gender.Female.ToString() ? true : false;
            rbMale.Checked = currentRow.Cells[nameof(Salesman.Gender)].Value.ToString() == Constant.Gender.Male.ToString() ? true : false;
            txtAddress.Text = currentRow.Cells[nameof(Salesman.Address)].Value.ToString();
            cbProvince.SelectedValue = currentRow.Cells[nameof(Salesman.ProvinceId)].Value.ToString();
            cbDistrict.SelectedValue = currentRow.Cells[nameof(Salesman.DistrictId)].Value.ToString();
            txtPostCode.Text = currentRow.Cells[nameof(Salesman.PostalCode)].Value.ToString();
            txtPhone.Text = currentRow.Cells[nameof(Salesman.Phone)].Value.ToString();
            txtEmail.Text = currentRow.Cells[nameof(Salesman.Email)].Value.ToString();

            // hidden fields
            txtSalesmanId.Text = currentRow.Cells[nameof(Salesman.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Salesman.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtSalesmanCode.Text) || string.IsNullOrEmpty(txtFullName.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Sales dan Nama Lengkap");
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
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvSalesman, ref foundIndices);
            dgvSalesman.CurrentCell = dgvSalesman[1, idx];
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
