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
    public partial class FrmMedicineCategoy : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<MedicineCat> uowMedCat;
        bool isAdd = false;

        public FrmMedicineCategoy()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmMedicineCategoy_Load(object sender, EventArgs e)
        {
            uowMedCat = new UnitOfWork<MedicineCat>(dbContext);

            BindMedCatGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtMedCatCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup(); 
            txtMedCatCode.Text = string.Empty;
            txtMedCat.Text = string.Empty;
            txtMedCatCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var existingMedCat = uowMedCat.Repository.GetAll().Where(u => u.Description == txtMedCat.Text.Trim()).FirstOrDefault();
            if (existingMedCat != null)
            {
                CommonHelper.DataAlreadyExistMessage(txtMedCatCode.Text.Trim());
            }
            else
            {
                var medCatToAdd = new MedicineCat
                {
                    Description = txtMedCat.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowMedCat.Repository.Add(medCatToAdd);
                uowMedCat.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countMedCat = uowMedCat.Repository.GetAll().Count();
            if (countMedCat <= 0)
            {
                gvSelectedIndex = 0;
                BindMedCatGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countMedCat == 1)
                {
                    BindMedCatGridView();
                    SetUIGridView();
                    dgvMedCat.CurrentCell = this.dgvMedCat[1, 0];
                }
                gvSelectedIndex = dgvMedCat.CurrentRow.Index;
                BindMedCatGridView();
                SetUIGridView();
                dgvMedCat.CurrentCell = this.dgvMedCat[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvMedCat.CurrentRow.Cells[nameof(MedicineCat.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvMedCat.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var medCatToDel = uowMedCat.Repository.GetAll().Where(u => u.Description == txtMedCat.Text.Trim()).FirstOrDefault();
            if (medCatToDel != null)
            {
                if (DialogResult.Yes == CommonHelper.ConfirmDeleteMessage())
                {
                    uowMedCat.Repository.Delete(medCatToDel);
                    var res = uowMedCat.Commit();
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
                CommonHelper.DataNotFoundMessage(txtMedCatCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            
            var repoLastUpdated = DateTime.Parse(dgvMedCat.CurrentRow.Cells[nameof(MedicineCat.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                CommonHelper.DataHasBeenUpdatedMessage(txtMedCatCode.Text.Trim());
            }
            else
            {
                var medCatToUpdate = uowMedCat.Repository.GetById(txtMedCatId.Text.Trim());
                medCatToUpdate.MedicineCatCode= txtMedCatCode.Text.Trim();
                medCatToUpdate.Description = txtMedCat.Text.Trim();
                medCatToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                medCatToUpdate.ModifiedAt = DateTime.Now;

                uowMedCat.Repository.Update(medCatToUpdate);
                uowMedCat.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvMedCat_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private void BindMedCatGridView()
        {
            var mc = new UnitOfWork<MedicineCat>(dbContext).Repository.GetAll()
                .OrderBy(u => u.Description);
            var mcDetail = mc.Select(mcDet =>
            new
            {
                mcDet.Id,
                mcDet.MedicineCatCode,
                mcDet.Description,
                mcDet.ModifiedAt
            });

            dgvMedCat.DataSource = mcDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvMedCat.Columns[nameof(MedicineCat.MedicineCatCode)].HeaderText = "KODE KATEGORI";
            dgvMedCat.Columns[nameof(MedicineCat.Description)].HeaderText = "KATEGORI OBAT";
            dgvMedCat.Columns[nameof(MedicineCat.Description)].Width = 320;
            
            dgvMedCat.Columns[nameof(MedicineCat.Id)].Visible = false;
            dgvMedCat.Columns[nameof(MedicineCat.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvMedCat.CurrentRow;
            txtMedCatCode.Text = currentRow.Cells[nameof(MedicineCat.MedicineCatCode)].Value.ToString();
            txtMedCat.Text = currentRow.Cells[nameof(MedicineCat.Description)].Value.ToString();

            // hidden fields
            txtMedCatId.Text = currentRow.Cells[nameof(MedicineCat.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(MedicineCat.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtMedCatCode.Text) || string.IsNullOrEmpty(txtMedCat.Text))
            {
                CommonHelper.DataCannotBeEmptyMessage("Kode Kategori dan Kategori Obat");
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
    }
}
