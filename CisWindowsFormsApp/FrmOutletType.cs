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
    public partial class FrmOutletType : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<OutletType> uowOutlet;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmOutletType()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmOutletType_Load(object sender, EventArgs e)
        {
            uowOutlet = new UnitOfWork<OutletType>(dbContext);

            BindOutletTypeGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtOutletCode.Focus();
        }

        private void dgvOutlet_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup(); 
            txtOutletCode.Text = string.Empty;
            txtOutlet.Text = string.Empty;
            txtOutletCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var existingOutlet = uowOutlet.Repository.GetAll().Where(u => u.OutletTypeCode == txtOutletCode.Text.Trim()).FirstOrDefault();
            if (existingOutlet != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtOutletCode.Text.Trim());
            }
            else
            {
                var outletToAdd = new OutletType
                {
                    OutletTypeCode = txtOutletCode.Text.Trim(),
                    Description = txtOutlet.Text.Trim(),
                     					 // Audit Fields 					CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowOutlet.Repository.Add(outletToAdd);
                uowOutlet.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countOutlet = uowOutlet.Repository.GetAll().Count();
            if (countOutlet <= 0)
            {
                gvSelectedIndex = 0;
                BindOutletTypeGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else 
            {
                if (countOutlet == 1)
                {
                    BindOutletTypeGridView();
                    SetUIGridView();
                    dgvOutlet.CurrentCell = this.dgvOutlet[1, 0];
                }
                gvSelectedIndex = dgvOutlet.CurrentRow.Index;
                BindOutletTypeGridView();
                SetUIGridView();
                dgvOutlet.CurrentCell = this.dgvOutlet[1, gvSelectedIndex < dgvOutlet.RowCount ? gvSelectedIndex : gvSelectedIndex - 1];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvOutlet.CurrentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvOutlet.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var outletToDel = uowOutlet.Repository.GetAll().Where(u => u.OutletTypeCode == txtOutletCode.Text.Trim()).FirstOrDefault();
            if (outletToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowOutlet.Repository.Delete(outletToDel);
                    var res = uowOutlet.Commit();
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
                CommonMessageHelper.DataNotFound(txtOutletCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowOutlet.Repository.GetById(txtOutletId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtOutletCode.Text.Trim());
            }
            else
            {
                var outletToUpdate = uowOutlet.Repository.GetById(txtOutletId.Text.Trim());
                outletToUpdate.OutletTypeCode = txtOutletCode.Text.Trim();
                outletToUpdate.Description = txtOutlet.Text.Trim();
                outletToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                outletToUpdate.ModifiedAt = DateTime.Now;

                uowOutlet.Repository.Update(outletToUpdate);
                uowOutlet.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void BindOutletTypeGridView()
        {
            var ot = new UnitOfWork<OutletType>(dbContext).Repository.GetAll()
                .OrderBy(u => u.OutletTypeCode);
            var otDetail = ot.Select(outlet =>
            new
            {
                outlet.Id,
                outlet.OutletTypeCode,
                outlet.Description,
                outlet.ModifiedAt
            });

            dgvOutlet.DataSource = otDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvOutlet.Columns[nameof(OutletType.OutletTypeCode)].HeaderText = "KODE OUTLET";
            dgvOutlet.Columns[nameof(OutletType.Description)].HeaderText = "JENIS OUTLET";
            dgvOutlet.Columns[nameof(OutletType.Description)].Width = 320;

            dgvOutlet.Columns[nameof(OutletType.Id)].Visible = false;
            dgvOutlet.Columns[nameof(OutletType.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvOutlet.CurrentRow;
            txtOutletCode.Text = currentRow.Cells[nameof(OutletType.OutletTypeCode)].Value.ToString();
            txtOutlet.Text = currentRow.Cells[nameof(OutletType.Description)].Value.ToString();

            // hidden fields
            txtOutletId.Text = currentRow.Cells[nameof(OutletType.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();
        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtOutletCode.Text) || string.IsNullOrEmpty(txtOutlet.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Outlet dan Jenis Outlet");
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
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvOutlet, ref foundIndices);
            dgvOutlet.CurrentCell = dgvOutlet[1, idx];
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
