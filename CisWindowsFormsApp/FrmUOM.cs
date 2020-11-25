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
        bool isAdd = false;

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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return; 
            var existingUom = uowUom.Repository.GetAll().Where(u => u.UomCode == txtUomCode.Text.Trim()).FirstOrDefault();
            if (existingUom != null)
            {
                MessageBox.Show("Data dengan Kode " + txtUomCode.Text.Trim() + " sudah ada. Silakan gunakan Kode yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var uomToAdd = new UnitOfMeasurement
                {
                    UomCode = txtUomCode.Text.Trim(),
                    Description = txtUomDesc.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowUom.Repository.Add(uomToAdd);
                uowUom.Commit();
                btnReload.PerformClick();
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
                dgvUom.CurrentCell = this.dgvUom[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvUom.CurrentRow.Cells[nameof(UnitOfMeasurement.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvUom.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var uomToDel = uowUom.Repository.GetAll().Where(u => u.UomCode == txtUomCode.Text.Trim()).FirstOrDefault();
            if (uomToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowUom.Repository.Delete(uomToDel);
                    uowUom.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtUomCode.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            
            var repoLastUpdated = DateTime.Parse(dgvUom.CurrentRow.Cells[nameof(UnitOfMeasurement.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtUomCode.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var uomToUpdate = uowUom.Repository.GetById(txtUomId.Text.Trim());
                uomToUpdate.UomCode = txtUomCode.Text.Trim();
                uomToUpdate.Description = txtUomDesc.Text.Trim();
                uomToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                uomToUpdate.ModifiedAt = DateTime.Now;

                uowUom.Repository.Update(uomToUpdate);
                uowUom.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvUom_Click(object sender, EventArgs e)
        {
            SetUIbySelectedGridItem();
        }

        private void FrmUOM_Load(object sender, EventArgs e)
        {
            uowUom = new UnitOfWork<UnitOfMeasurement>(dbContext);
            
            BindUomGridView();
            SetUIGridView();

            if (dgvUom.RowCount <= 0)
            {
                isAdd = true;
                SetUIButtonGroup();
            }
            
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

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtUomCode.Text) || string.IsNullOrEmpty(txtUomDesc.Text))
            {
                MessageBox.Show("Data Kode Unit dan Keterangan tidak boleh kosong."
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
