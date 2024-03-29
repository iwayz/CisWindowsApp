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
    public partial class FrmSalesArea : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<SalesArea> uowArea;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmSalesArea()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesArea_Load(object sender, EventArgs e)
        {
            uowArea = new UnitOfWork<SalesArea>(dbContext);

            BindAreaGridView();
            BindComboBoxSalesArea();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();
            CheckSourceRefData();

            txtAreaCode.Focus();
        }

        private void dgvSalesArea_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            BindComboBoxSalesArea();
            txtAreaCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtAreaCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingRole = uowArea.Repository.GetAll().Where(r => r.AreaCode == txtAreaCode.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtAreaCode.Text.Trim());
            }
            else
            {
                var areaToAdd = new SalesArea
                {
                    AreaCode = txtAreaCode.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    RepresentativeId = cbRepresentative.SelectedValue.ToString(),

                    // Audit Fields 
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowArea.Repository.Add(areaToAdd);
                uowArea.Commit();
                isAdd = true;
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowArea.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindAreaGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindAreaGridView();
                    SetUIGridView();
                    dgvSalesArea.CurrentCell = this.dgvSalesArea[1, 0];
                }
                gvSelectedIndex = dgvSalesArea.CurrentRow.Index;
                BindAreaGridView();
                SetUIGridView();
                dgvSalesArea.CurrentCell = this.dgvSalesArea[1, isAdd ? dgvSalesArea.RowCount-1 : (gvSelectedIndex < dgvSalesArea.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvSalesArea.CurrentRow.Cells[nameof(SalesArea.ModifiedAt)].Value.ToString();
            }

            SetUIButtonGroup();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var uomToDel = uowArea.Repository.GetAll().Where(u => u.AreaCode == txtAreaCode.Text.Trim()).FirstOrDefault();
            if (uomToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        bool expectedError = false;
                        bool unexpectedError = false;
                        uowArea.Repository.Delete(uomToDel);
                        var res = uowArea.Commit();
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
                CommonMessageHelper.DataNotFound(txtAreaCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
           
            var repoLastUpdated = uowArea.Repository.GetById(txtAreaId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtAreaCode.Text.Trim());
            }
            else
            {
                var areaToUpdate = uowArea.Repository.GetById(txtAreaId.Text.Trim());
                areaToUpdate.AreaCode = txtAreaCode.Text.Trim();
                areaToUpdate.Description = txtDescription.Text.Trim();
                areaToUpdate.RepresentativeId = cbRepresentative.SelectedValue.ToString();
                areaToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                areaToUpdate.ModifiedAt = DateTime.Now;

                uowArea.Repository.Update(areaToUpdate);
                uowArea.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void BindComboBoxSalesArea()
        {
            var uow = new UnitOfWork<Representative>(dbContext);
            var representative = uow.Repository.GetAll().OrderBy(m => m.RepresentativeCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsRepresentative = new Dictionary<string, string>();
            dsRepresentative.Add("0", "--Pilih--");
            foreach (var repre in representative)
            {
                dsRepresentative.Add(repre.Id, repre.RepresentativeCode + " - " + repre.Description);
                autoCompleteCollection.Add(repre.RepresentativeCode + " - " + repre.Description);
            }

            cbRepresentative.DataSource = new BindingSource(dsRepresentative, null);
            cbRepresentative.DisplayMember = "Value";
            cbRepresentative.ValueMember = "Key";
            cbRepresentative.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindAreaGridView()
        {
            var areas = new UnitOfWork<SalesArea>(dbContext).Repository.GetAll().OrderBy(u => u.AreaCode);
            var areaDetail = areas.Select(area =>
            new
            {
                area.Id,
                area.AreaCode,
                area.Description,
                area.RepresentativeId,
                area.ModifiedAt
            });

            dgvSalesArea.DataSource = areaDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvSalesArea.Columns[nameof(SalesArea.AreaCode)].HeaderText = "KODE AREA";
            dgvSalesArea.Columns[nameof(SalesArea.Description)].HeaderText = "KETERANGAN";
            dgvSalesArea.Columns[nameof(SalesArea.Description)].Width = 250;

            dgvSalesArea.Columns[nameof(SalesArea.Id)].Visible = false;
            dgvSalesArea.Columns[nameof(SalesArea.ModifiedAt)].Visible = false;
            dgvSalesArea.Columns[nameof(SalesArea.RepresentativeId)].Visible = false;

        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvSalesArea.CurrentRow;
            txtAreaCode.Text = currentRow.Cells[nameof(SalesArea.AreaCode)].Value.ToString();
            txtDescription.Text = currentRow.Cells[nameof(SalesArea.Description)].Value.ToString();
            cbRepresentative.SelectedValue = currentRow.Cells[nameof(SalesArea.RepresentativeId)].Value.ToString();

            // hidden fields
            txtAreaId.Text = currentRow.Cells[nameof(SalesArea.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(SalesArea.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtAreaCode.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Area dan Keterangan");
                return false;

            }

            if (cbRepresentative.Items.Count <= 1)
            {
                CommonMessageHelper.ReferredDataNotSet("Perwakilan");
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
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvSalesArea, ref foundIndices);
            dgvSalesArea.CurrentCell = dgvSalesArea[1, idx];
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

        private void CheckSourceRefData()
        {
            List<string> refData = new List<string>();
            if (cbRepresentative.Items.Count <= 1) refData.Add("Perwakilan");

            lblNoteDetail.Text = "Data referensi (" + string.Join(", ", refData) + ") belum tersedia. ";
            if (refData.Count > 0) pnlNote.Visible = true;
        }
    }
}
