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
    public partial class FrmRole : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Role> uowRole;

        public FrmRole()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }


        private void FrmRole_Load(object sender, EventArgs e)
        {
            uowRole = new UnitOfWork<Role>(dbContext);

            BindRoleGridView();
            SetUIGridView();

            txtRoleCode.Focus();
        }
        private void BindRoleGridView()
        {
            var roles = new UnitOfWork<Role>(dbContext).Repository.GetAll().OrderBy(u => u.RoleCode);
            var uomDetail = roles.Select(role =>
            new
            {
                role.Id,
                role.RoleCode,
                role.Description,
                role.ModifiedAt
            });

            dgvRole.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvRole.Columns[nameof(Role.RoleCode)].HeaderText = "KODE";
            dgvRole.Columns[nameof(Role.Description)].HeaderText = "NAMA ROLE";
            dgvRole.Columns[nameof(Role.Description)].Width = 220;
            dgvRole.Columns[nameof(Role.Id)].Visible = false;
            dgvRole.Columns[nameof(Role.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvRole.CurrentRow;
            txtRoleCode.Text = currentRow.Cells[nameof(Role.RoleCode)].Value.ToString();
            txtDescription.Text = currentRow.Cells[nameof(Role.Description)].Value.ToString();

            // hidden fields
            txtRoleId.Text = currentRow.Cells[nameof(Role.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Role.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtRoleCode.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Data Kode Role dan Keterangan tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoleCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var existingRole = uowRole.Repository.GetAll().Where(r => r.RoleCode == txtRoleCode.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                MessageBox.Show("Data dengan Kode " + txtRoleCode.Text.Trim() + " sudah ada. Silakan gunakan Kode yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var roleToAdd = new Role
                {
                    RoleCode = txtRoleCode.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowRole.Repository.Add(roleToAdd);
                uowRole.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowRole.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindRoleGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindRoleGridView();
                    SetUIGridView();
                    dgvRole.CurrentCell = this.dgvRole[1, 0];
                }
                gvSelectedIndex = dgvRole.CurrentRow.Index;
                BindRoleGridView();
                SetUIGridView();
                dgvRole.CurrentCell = this.dgvRole[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvRole.CurrentRow.Cells[nameof(Role.ModifiedAt)].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowRole.Repository.GetAll().Where(u => u.RoleCode == txtRoleCode.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowRole.Repository.Delete(roleToDel);
                    uowRole.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtRoleCode.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var repoLastUpdated = DateTime.Parse(dgvRole.CurrentRow.Cells[nameof(Role.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtRoleCode.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var roleToUpdate = uowRole.Repository.GetById(txtRoleId.Text.Trim());
                roleToUpdate.RoleCode = txtRoleCode.Text.Trim();
                roleToUpdate.Description = txtDescription.Text.Trim();
                roleToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                roleToUpdate.ModifiedAt = DateTime.Now;

                uowRole.Repository.Update(roleToUpdate);
                uowRole.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvRole_Click(object sender, EventArgs e)
        {
            SetUIbySelectedGridItem();
        }
    }
}
