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
    public partial class FrmSalesArea : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<SalesArea> uowArea;

        public FrmSalesArea()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesArea_Load(object sender, EventArgs e)
        {
            uowArea = new UnitOfWork<SalesArea>(dbContext);

            BindAreaGridView();
            SetUIGridView();

            txtAreaCode.Focus();
        }

        private void dgvSalesArea_Click(object sender, EventArgs e)
        {
            SetUIbySelectedGridItem();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAreaCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var existingRole = uowArea.Repository.GetAll().Where(r => r.AreaCode == txtAreaCode.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                MessageBox.Show("Data dengan Kode " + txtAreaCode.Text.Trim() + " sudah ada. Silakan gunakan Kode yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var areaToAdd = new SalesArea
                {
                    AreaCode = txtAreaCode.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowArea.Repository.Add(areaToAdd);
                uowArea.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowArea.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindAreaGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindAreaGridView();
                    SetUIGridView();
                    dgvSalesArea.CurrentCell = this.dgvSalesArea[1, 0];
                }
                gvSelectedIndex = dgvSalesArea.CurrentRow.Index;
                BindAreaGridView();
                SetUIGridView();
                dgvSalesArea.CurrentCell = this.dgvSalesArea[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvSalesArea.CurrentRow.Cells[nameof(SalesArea.ModifiedAt)].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var uomToDel = uowArea.Repository.GetAll().Where(u => u.AreaCode == txtAreaCode.Text.Trim()).FirstOrDefault();
            if (uomToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowArea.Repository.Delete(uomToDel);
                    uowArea.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtAreaCode.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var repoLastUpdated = DateTime.Parse(dgvSalesArea.CurrentRow.Cells[nameof(SalesArea.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtAreaCode.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var areaToUpdate = uowArea.Repository.GetById(txtAreaId.Text.Trim());
                areaToUpdate.AreaCode = txtAreaCode.Text.Trim();
                areaToUpdate.Description = txtDescription.Text.Trim();
                areaToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                areaToUpdate.ModifiedAt = DateTime.Now;

                uowArea.Repository.Update(areaToUpdate);
                uowArea.Commit();
                btnReload.PerformClick();
            }
        }

        private void BindAreaGridView()
        {
            var areas = new UnitOfWork<SalesArea>(dbContext).Repository.GetAll().OrderBy(u => u.AreaCode);
            var areaDetail = areas.Select(area =>
            new
            {
                area.Id,
                area.AreaCode,
                area.Description,
                area.ModifiedAt
            });

            dgvSalesArea.DataSource = areaDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvSalesArea.Columns[nameof(SalesArea.AreaCode)].HeaderText = "KODE AREA";
            dgvSalesArea.Columns[nameof(SalesArea.Description)].HeaderText = "KETERANGAN";
            dgvSalesArea.Columns[nameof(SalesArea.Description)].Width = 220;
            dgvSalesArea.Columns[nameof(SalesArea.Id)].Visible = false;
            dgvSalesArea.Columns[nameof(SalesArea.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvSalesArea.CurrentRow;
            txtAreaCode.Text = currentRow.Cells[nameof(SalesArea.AreaCode)].Value.ToString();
            txtDescription.Text = currentRow.Cells[nameof(SalesArea.Description)].Value.ToString();

            // hidden fields
            txtAreaId.Text = currentRow.Cells[nameof(SalesArea.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(SalesArea.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtAreaCode.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Data Kode Area dan Keterangan tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }

    }
}
