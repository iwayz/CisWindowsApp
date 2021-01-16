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
    public partial class FrmTermOfPayment : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<TermOfPayment> uowTop;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

        public FrmTermOfPayment()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmTermOfPayment_Load(object sender, EventArgs e)
        {
            uowTop = new UnitOfWork<TermOfPayment>(dbContext);

            BindMedCatGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtTermCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            txtTermCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTermCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var existingTop = uowTop.Repository.GetAll().Where(t => t.TermCode == txtTermCode.Text.Trim()).FirstOrDefault();
            if (existingTop != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtTermCode.Text.Trim());
            }
            else
            {
                var topToAdd = new TermOfPayment
                {
                    TermCode = txtTermCode.Text.Trim(),
                    Description = txtDescription.Text.Trim(),

                    // Audit Fields 
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                uowTop.Repository.Add(topToAdd);
                uowTop.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countMedCat = uowTop.Repository.GetAll().Count();
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
                    dgvTerm.CurrentCell = this.dgvTerm[1, 0];
                }
                gvSelectedIndex = dgvTerm.CurrentRow.Index;
                BindMedCatGridView();
                SetUIGridView();
                
                dgvTerm.CurrentCell = this.dgvTerm[1, isAdd ? dgvTerm.RowCount-1 : (gvSelectedIndex < dgvTerm.RowCount ? gvSelectedIndex : gvSelectedIndex - 1)];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvTerm.CurrentRow.Cells[nameof(TermOfPayment.ModifiedAt)].Value.ToString();
            }

            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var topToDel = uowTop.Repository.GetAll().Where(t => t.TermCode == txtTermCode.Text.Trim()).FirstOrDefault();
            if (topToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowTop.Repository.Delete(topToDel);
                    var res = uowTop.Commit();
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
                CommonMessageHelper.DataNotFound(txtTermCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = uowTop.Repository.GetById(txtTermId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtTermCode.Text.Trim());
            }
            else
            {
                var topToUpdate = uowTop.Repository.GetById(txtTermId.Text.Trim());
                topToUpdate.TermCode = txtTermCode.Text.Trim();
                topToUpdate.Description = txtDescription.Text.Trim();
                topToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                topToUpdate.ModifiedAt = DateTime.Now;

                uowTop.Repository.Update(topToUpdate);
                uowTop.Commit();
                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void dgvTerm_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnReload.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvTerm, ref foundIndices);
            dgvTerm.CurrentCell = dgvTerm[1, idx];
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

        private void BindMedCatGridView()
        {
            var top = new UnitOfWork<TermOfPayment>(dbContext).Repository.GetAll()
                .OrderBy(u => u.TermCode);
            var topDetail = top.Select(mcDet =>
            new
            {
                mcDet.Id,
                mcDet.TermCode,
                mcDet.Description,
                mcDet.ModifiedAt
            });

            dgvTerm.DataSource = topDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvTerm.Columns[nameof(TermOfPayment.TermCode)].HeaderText = "KODE TERM";
            dgvTerm.Columns[nameof(TermOfPayment.TermCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTerm.Columns[nameof(TermOfPayment.Description)].HeaderText = "KETERANGAN";
            dgvTerm.Columns[nameof(TermOfPayment.Description)].Width = 320;

            dgvTerm.Columns[nameof(TermOfPayment.Id)].Visible = false;
            dgvTerm.Columns[nameof(TermOfPayment.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvTerm.CurrentRow;
            txtTermCode.Text = currentRow.Cells[nameof(TermOfPayment.TermCode)].Value.ToString();
            txtDescription.Text = currentRow.Cells[nameof(TermOfPayment.Description)].Value.ToString();

            // hidden fields
            txtTermId.Text = currentRow.Cells[nameof(TermOfPayment.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(TermOfPayment.ModifiedAt)].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtTermCode.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Term dan Keterangan");
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
