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
    public partial class FrmMedicineCategoy : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<MedicineCat> uowMedCat; 
        
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

            txtMedCat.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedCat.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;

            var existingMedCat = uowMedCat.Repository.GetAll().Where(u => u.Description == txtMedCat.Text.Trim()).FirstOrDefault();
            if (existingMedCat != null)
            {
                MessageBox.Show("Data '" + txtMedCat.Text.Trim() + "' sudah ada. Silakan gunakan Jenis Outlet yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtModifiedAt.Text = dgvMedCat.CurrentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var medCatToDel = uowMedCat.Repository.GetAll().Where(u => u.Description == txtMedCat.Text.Trim()).FirstOrDefault();
            if (medCatToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowMedCat.Repository.Delete(medCatToDel);
                    uowMedCat.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data '" + txtMedCat.Text.Trim() + "' tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var repoLastUpdated = DateTime.Parse(dgvMedCat.CurrentRow.Cells[nameof(MedicineCat.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data '" + txtMedCat.Text.Trim() + "' telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var medCatToUpdate = uowMedCat.Repository.GetById(txtMedCat.Text.Trim());
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
            SetUIbySelectedGridItem();
        }

        private void BindMedCatGridView()
        {
            var mc = new UnitOfWork<MedicineCat>(dbContext).Repository.GetAll()
                .OrderBy(u => u.Description);
            var otDetail = mc.Select(outlet =>
            new
            {
                outlet.Id,
                outlet.Description,
                outlet.ModifiedAt
            });

            dgvMedCat.DataSource = otDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvMedCat.Columns[nameof(MedicineCat.Description)].HeaderText = "KATEGORI OBAT";
            dgvMedCat.Columns[nameof(MedicineCat.Description)].Width = 320;
            
            dgvMedCat.Columns[nameof(MedicineCat.Id)].Visible = false;
            dgvMedCat.Columns[nameof(MedicineCat.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvMedCat.CurrentRow;
            txtMedCat.Text = currentRow.Cells[nameof(OutletType.Description)].Value.ToString();

            // hidden fields
            txtMedCatId.Text = currentRow.Cells[nameof(OutletType.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(OutletType.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtMedCat.Text))
            {
                MessageBox.Show("Data tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }
    }
}
