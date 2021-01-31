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
    public partial class FrmRepresentative : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Representative> uow;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmRepresentative()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmRepresentative_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork<Representative>(dbContext);

            BindRepresentativeGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtRepresentativeCode.Focus();
        }

        private void dgvRepresentative_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            txtRepresentativeCode.Text = string.Empty;
            txtRepresentative.Text = string.Empty;
            txtRepresentativeCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var existingRepresentative = uow.Repository.GetAll().Where(u => u.RepresentativeCode == txtRepresentativeCode.Text.Trim()).FirstOrDefault();
            if (existingRepresentative != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtRepresentativeCode.Text.Trim());
            }
            else
            {
                var representativeToAdd = new Representative
                {
                    RepresentativeCode = txtRepresentativeCode.Text.Trim(),
                    Description = txtRepresentative.Text.Trim(),

                    // Audit Fields 
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uow.Repository.Add(representativeToAdd);
                uow.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRepresentative = uow.Repository.GetAll().Count();
            if (countRepresentative <= 0)
            {
                gvSelectedIndex = 0;
                BindRepresentativeGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRepresentative == 1)
                {
                    BindRepresentativeGridView();
                    SetUIGridView();
                    dgvRepresentative.CurrentCell = this.dgvRepresentative[1, 0];
                }
                gvSelectedIndex = dgvRepresentative.CurrentRow.Index;
                BindRepresentativeGridView();
                SetUIGridView();
                dgvRepresentative.CurrentCell = this.dgvRepresentative[1, isAdd ? dgvRepresentative.RowCount - 1 : (gvSelectedIndex < dgvRepresentative.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvRepresentative.CurrentRow.Cells[nameof(Representative.ModifiedAt)].Value.ToString();
            }

            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var representativeToDel = uow.Repository.GetAll().Where(u => u.RepresentativeCode == txtRepresentativeCode.Text.Trim()).FirstOrDefault();
            if (representativeToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uow.Repository.Delete(representativeToDel);
                    var res = uow.Commit();
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
                CommonMessageHelper.DataNotFound(txtRepresentativeCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uow.Repository.GetById(txtRepresentativeId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtRepresentativeCode.Text.Trim());
            }
            else
            {
                var representativeToUpdate = uow.Repository.GetById(txtRepresentativeId.Text.Trim());
                representativeToUpdate.RepresentativeCode = txtRepresentativeCode.Text.Trim();
                representativeToUpdate.Description = txtRepresentative.Text.Trim();
                representativeToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                representativeToUpdate.ModifiedAt = DateTime.Now;

                uow.Repository.Update(representativeToUpdate);
                uow.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvRepresentative, ref foundIndices);
            dgvRepresentative.CurrentCell = dgvRepresentative[1, idx];
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

        private void BindRepresentativeGridView()
        {
            var ot = new UnitOfWork<Representative>(dbContext).Repository.GetAll()
                .OrderBy(u => u.RepresentativeCode);
            var otDetail = ot.Select(representative =>
            new
            {
                representative.Id,
                representative.RepresentativeCode,
                representative.Description,
                representative.ModifiedAt
            });

            dgvRepresentative.DataSource = otDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvRepresentative.Columns[nameof(Representative.RepresentativeCode)].HeaderText = "KODE PERWAKILAN";
            dgvRepresentative.Columns[nameof(Representative.Description)].HeaderText = "NAMA PERWAKILAN";
            dgvRepresentative.Columns[nameof(Representative.Description)].Width = 320;

            dgvRepresentative.Columns[nameof(Representative.Id)].Visible = false;
            dgvRepresentative.Columns[nameof(Representative.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvRepresentative.CurrentRow;
            txtRepresentativeCode.Text = currentRow.Cells[nameof(Representative.RepresentativeCode)].Value.ToString();
            txtRepresentative.Text = currentRow.Cells[nameof(Representative.Description)].Value.ToString();

            // hidden fields
            txtRepresentativeId.Text = currentRow.Cells[nameof(Representative.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Representative.ModifiedAt)].Value.ToString();
        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtRepresentativeCode.Text) || string.IsNullOrEmpty(txtRepresentative.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Representative dan Nama Representative");
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
