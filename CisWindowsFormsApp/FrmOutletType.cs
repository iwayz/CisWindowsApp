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

            txtOutlet.Focus();
        }

        private void dgvOutlet_Click(object sender, EventArgs e)
        {
            SetUIbySelectedGridItem();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutlet.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;

            var existingOutlet = uowOutlet.Repository.GetAll().Where(u => u.Description == txtOutlet.Text.Trim()).FirstOrDefault();
            if (existingOutlet != null)
            {
                MessageBox.Show("Data '" + txtOutlet.Text.Trim() + "' sudah ada. Silakan gunakan Jenis Outlet yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var outletToAdd = new OutletType
                {
                    Description = txtOutlet.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowOutlet.Repository.Add(outletToAdd);
                uowOutlet.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            // TODO: apply this logic to all other forms
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
                dgvOutlet.CurrentCell = this.dgvOutlet[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvOutlet.CurrentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var outletToDel = uowOutlet.Repository.GetAll().Where(u => u.Description == txtOutlet.Text.Trim()).FirstOrDefault();
            if (outletToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowOutlet.Repository.Delete(outletToDel);
                    uowOutlet.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data '" + txtOutlet.Text.Trim() + "' tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var repoLastUpdated = DateTime.Parse(dgvOutlet.CurrentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data '" + txtOutlet.Text.Trim() + "' telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var outletToUpdate = uowOutlet.Repository.GetById(txtOutletId.Text.Trim());
                outletToUpdate.Description = txtOutlet.Text.Trim();
                outletToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                outletToUpdate.ModifiedAt = DateTime.Now;

                uowOutlet.Repository.Update(outletToUpdate);
                uowOutlet.Commit();
                btnReload.PerformClick();
            }
        }

        private void BindOutletTypeGridView()
        {
            var ot = new UnitOfWork<OutletType>(dbContext).Repository.GetAll()
                .OrderBy(u => u.Description);
            var otDetail = ot.Select(outlet =>
            new
            {
                outlet.Id,
                outlet.Description,
                outlet.ModifiedAt
            });

            dgvOutlet.DataSource = otDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvOutlet.Columns[nameof(OutletType.Description)].HeaderText = "JENIS OUTLET";
            dgvOutlet.Columns[nameof(OutletType.Description)].Width = 320;

            dgvOutlet.Columns[nameof(OutletType.Id)].Visible = false;
            dgvOutlet.Columns[nameof(OutletType.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvOutlet.CurrentRow;
            txtOutlet.Text = currentRow.Cells[nameof(OutletType.Description)].Value.ToString();

            // hidden fields
            txtOutletId.Text = currentRow.Cells[nameof(OutletType.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtOutlet.Text))
            {
                MessageBox.Show("Data tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }
    }
}
