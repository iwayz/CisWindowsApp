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
    public partial class FrmUOM : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<UnitOfMeasurement> uowUom;
        bool isAdd = true;
        List<int> foundIndices = new List<int>();

        public FrmUOM()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup(); 
            txtUomCode.Text = string.Empty;
            txtUomDesc.Text = string.Empty;
            txtUomCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return; 
            var existingUom = uowUom.Repository.GetAll().Where(u => u.UomCode == txtUomCode.Text.Trim()).FirstOrDefault();
            if (existingUom != null)
            {
               CommonMessageHelper.DataAlreadyExist(txtUomCode.Text.Trim());
            }
            else
            {
                var uomToAdd = new UnitOfMeasurement
                {
                    UomCode = txtUomCode.Text.Trim(),
                    Description = txtUomDesc.Text.Trim(),
                     					 // Audit Fields 					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowUom.Repository.Add(uomToAdd);
                uowUom.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countUom = uowUom.Repository.GetAll().Count();
            if (countUom <= 0)
            {
                gvSelectedIndex = 0;
                BindUomGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countUom == 1)
                {
                    BindUomGridView();
                    SetUIGridView();
                    dgvUom.CurrentCell = this.dgvUom[1, 0];
                }
                gvSelectedIndex = dgvUom.CurrentRow.Index;
                BindUomGridView();
                SetUIGridView();
                dgvUom.CurrentCell = this.dgvUom[1, isAdd ? dgvUom.RowCount-1 : (gvSelectedIndex < dgvUom.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvUom.CurrentRow.Cells[nameof(UnitOfMeasurement.ModifiedAt)].Value.ToString();
            }

            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var uomToDel = uowUom.Repository.GetAll().Where(u => u.UomCode == txtUomCode.Text.Trim()).FirstOrDefault();
            if (uomToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowUom.Repository.Delete(uomToDel);
                    var res = uowUom.Commit();
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
                CommonMessageHelper.DataNotFound(txtUomCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowUom.Repository.GetById(txtUomId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtUomCode.Text.Trim());
            }
            else
            {
                var uomToUpdate = uowUom.Repository.GetById(txtUomId.Text.Trim());
                uomToUpdate.UomCode = txtUomCode.Text.Trim();
                uomToUpdate.Description = txtUomDesc.Text.Trim();
                uomToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                uomToUpdate.ModifiedAt = DateTime.Now;

                uowUom.Repository.Update(uomToUpdate);
                uowUom.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void dgvUom_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void FrmUOM_Load(object sender, EventArgs e)
        {
            uowUom = new UnitOfWork<UnitOfMeasurement>(dbContext);

            BindUomGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtUomCode.Focus();
        }

        private void BindUomGridView()
        {
            var uoms = new UnitOfWork<UnitOfMeasurement>(dbContext).Repository.GetAll().OrderBy(u => u.UomCode);
            var uomDetail = uoms.Select(uom =>
            new
            {
                uom.Id,
                uom.UomCode,
                uom.Description,
                uom.ModifiedAt
            });

            dgvUom.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvUom.Columns[nameof(UnitOfMeasurement.UomCode)].HeaderText = "KODE";
            dgvUom.Columns[nameof(UnitOfMeasurement.Description)].HeaderText = "NAMA UNIT";
            dgvUom.Columns[nameof(UnitOfMeasurement.Description)].Width = 220;

            dgvUom.Columns[nameof(UnitOfMeasurement.Id)].Visible = false;
            dgvUom.Columns[nameof(UnitOfMeasurement.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvUom.CurrentRow;
            txtUomCode.Text = currentRow.Cells[nameof(UnitOfMeasurement.UomCode)].Value.ToString();
            txtUomDesc.Text = currentRow.Cells[nameof(UnitOfMeasurement.Description)].Value.ToString();
            
            // hidden fields
            txtUomId.Text = currentRow.Cells[nameof(UnitOfMeasurement.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(UnitOfMeasurement.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtUomCode.Text) || string.IsNullOrEmpty(txtUomDesc.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Unit dan Keterangan");
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
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvUom, ref foundIndices);
            dgvUom.CurrentCell = dgvUom[1, idx];
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
    }
}
