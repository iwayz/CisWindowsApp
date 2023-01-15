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
    public partial class FrmUsageType : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<UsageType> uowUsage;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmUsageType()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmUsageType_Load(object sender, EventArgs e)
        {
            uowUsage = new UnitOfWork<UsageType>(dbContext);

            BindUsageTyperidView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtUsageTypeCode.Focus();
        }

        private void BindUsageTyperidView()
        {
            var ut = new UnitOfWork<UsageType>(dbContext).Repository.GetAll()
                .OrderBy(u => u.UsageTypeCode);
            var utDetail = ut.Select(usage =>
            new
            {
                usage.Id,
                usage.UsageTypeCode,
                usage.Description,
                usage.ModifiedAt
            });

            dgvUsageType.DataSource = utDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvUsageType.Columns[nameof(UsageType.UsageTypeCode)].HeaderText = "KODE PEMAKAIAN";
            dgvUsageType.Columns[nameof(UsageType.Description)].HeaderText = "JENIS PEMAKAIAN";
            dgvUsageType.Columns[nameof(UsageType.Description)].Width = 320;
            
            dgvUsageType.Columns[nameof(UsageType.Id)].Visible = false;
            dgvUsageType.Columns[nameof(UsageType.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvUsageType.CurrentRow;
            txtUsageTypeCode.Text = currentRow.Cells[nameof(UsageType.UsageTypeCode)].Value.ToString();
            txtUsageDesc.Text = currentRow.Cells[nameof(UsageType.Description)].Value.ToString();

            // hidden fields
            txtUsageId.Text = currentRow.Cells[nameof(UsageType.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(UsageType.ModifiedAt)].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            txtUsageTypeCode.Text = string.Empty;
            txtUsageDesc.Text = string.Empty;
            txtUsageTypeCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return; 
            var existingUsage = uowUsage.Repository.GetAll().Where(u => u.UsageTypeCode == txtUsageTypeCode.Text.Trim()).FirstOrDefault();
            if (existingUsage != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtUsageDesc.Text.Trim());
            }
            else
            {
                var usageToAdd = new UsageType
                {
                    UsageTypeCode = txtUsageTypeCode.Text.Trim(),
                    Description = txtUsageDesc.Text.Trim(),
                     					 // Audit Fields 					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowUsage.Repository.Add(usageToAdd);
                uowUsage.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countUsage = uowUsage.Repository.GetAll().Count();
            if (countUsage <= 0)
            {
                gvSelectedIndex = 0;
                BindUsageTyperidView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countUsage == 1)
                {
                    BindUsageTyperidView();
                    SetUIGridView();
                    dgvUsageType.CurrentCell = this.dgvUsageType[1, 0];
                }
                gvSelectedIndex = dgvUsageType.CurrentRow.Index;
                BindUsageTyperidView();
                SetUIGridView();
                dgvUsageType.CurrentCell = this.dgvUsageType[1, isAdd ? dgvUsageType.RowCount-1 : (gvSelectedIndex < dgvUsageType.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvUsageType.CurrentRow.Cells[nameof(UsageType.ModifiedAt)].Value.ToString();
            }

            SetUIButtonGroup();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var usageToDel = uowUsage.Repository.GetAll().Where(u => u.UsageTypeCode == txtUsageTypeCode.Text.Trim()).FirstOrDefault();
            if (usageToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        bool expectedError = false;
                        bool unexpectedError = false;
                        uowUsage.Repository.Delete(usageToDel);
                        var res = uowUsage.Commit();
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
                CommonMessageHelper.DataNotFound(txtUsageTypeCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            
            var repoLastUpdated = uowUsage.Repository.GetById(txtUsageId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtUsageTypeCode.Text.Trim());
            }
            else
            {
                var usageToUpdate = uowUsage.Repository.GetById(txtUsageId.Text.Trim());
                usageToUpdate.UsageTypeCode = txtUsageTypeCode.Text.Trim();
                usageToUpdate.Description = txtUsageDesc.Text.Trim();
                usageToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                usageToUpdate.ModifiedAt = DateTime.Now;

                uowUsage.Repository.Update(usageToUpdate);
                uowUsage.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void dgvUsageType_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtUsageTypeCode.Text) || string.IsNullOrEmpty(txtUsageDesc.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Pemakaian dan Jenis Pemakaian");
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
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvUsageType, ref foundIndices);
            dgvUsageType.CurrentCell = dgvUsageType[1, idx];
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
