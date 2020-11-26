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
            if (!ValidateEmptyField()) return;

            var existingMedCat = uowMedCat.Repository.GetAll().Where(u => u.Description == txtMedCat.Text.Trim()).FirstOrDefault();
            if (existingMedCat != null)
            {
                MessageBox.Show("Data dengan Kode '" + txtMedCat.Text.Trim() + "' sudah ada. Silakan gunakan kode yang lain."
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
            if (dgvMedCat.RowCount <= 0)
            {
                MessageBox.Show("Tekan tombol Add untuk menyimpan data baru."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            var repoLastUpdated = DateTime.Parse(dgvMedCat.CurrentRow.Cells[nameof(MedicineCat.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data '" + txtMedCat.Text.Trim() + "' telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtMedCatCode.Text) || string.IsNullOrEmpty(txtMedCat.Text))
            {
                MessageBox.Show("Data Kode Kategori dan Kategori Obat tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
