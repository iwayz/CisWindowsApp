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
    public partial class FrmUser : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<User> uowUser;
        bool isAdd = false;

        public FrmUser()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            uowUser = new UnitOfWork<User>(dbContext);

            BindUserGridView();
            SetUIGridView();
            SetUIButtonGroup();

            if (dgvUser.RowCount <= 0)
            {
                isAdd = true;
                SetUIButtonGroup();
            }
            
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtRetypePassword.Text = string.Empty;
            chkChangePassword.Checked = false;
            txtUsername.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var existingRole = uowUser.Repository.GetAll().Where(u => u.Username == txtUsername.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                MessageBox.Show("Data dengan Kode " + txtUsername.Text.Trim() + " sudah ada. Silakan gunakan Kode yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var userToAdd = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = new UserHelper().HashPassword(txtPassword.Text.Trim()),
                    FullName = txtFullName.Text.Trim(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowUser.Repository.Add(userToAdd);
                uowUser.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowUser.Repository.GetAll().Count();
            if (countRole <= 0)
            {
                gvSelectedIndex = 0;
                BindUserGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countRole == 1)
                {
                    BindUserGridView();
                    SetUIGridView();
                    dgvUser.CurrentCell = this.dgvUser[1, 0];
                }
                gvSelectedIndex = dgvUser.CurrentRow.Index;
                BindUserGridView();
                SetUIGridView();
                dgvUser.CurrentCell = this.dgvUser[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvUser.CurrentRow.Cells[nameof(User.ModifiedAt)].Value.ToString();
            }
            chkChangePassword.Checked = false;
            txtRetypePassword.Text = string.Empty;

            isAdd = dgvUser.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var uomToDel = uowUser.Repository.GetAll().Where(u => u.Username == txtUsername.Text.Trim()).FirstOrDefault();
            if (uomToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowUser.Repository.Delete(uomToDel);
                    uowUser.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtUsername.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            
            if (chkChangePassword.Checked && !txtPassword.Text.Trim().Equals(txtRetypePassword.Text.Trim()))
            {
                MessageBox.Show("Pastikan password yang anda masukkan sama."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repoLastUpdated = DateTime.Parse(dgvUser.CurrentRow.Cells[nameof(User.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtUsername.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var userToUpdate = uowUser.Repository.GetById(txtUserId.Text.Trim());
                userToUpdate.Username = txtUsername.Text.Trim();

                if (chkChangePassword.Checked)
                    userToUpdate.Password = new UserHelper().HashPassword(txtPassword.Text.Trim());
                
                userToUpdate.FullName = txtFullName.Text.Trim();
                userToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                userToUpdate.ModifiedAt = DateTime.Now;

                uowUser.Repository.Update(userToUpdate);
                uowUser.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetUIbySelectedGridItem();
        }

        private void BindUserGridView()
        {
            var users = new UnitOfWork<User>(dbContext).Repository.GetAll().OrderBy(u => u.Username);
            var uomDetail = users.Select(user =>
            new
            {
                user.Id,
                user.Username,
                user.Password,
                user.FullName,
                user.ModifiedAt
            });

            dgvUser.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvUser.Columns[nameof(User.Username)].HeaderText = "USERNAME";
            dgvUser.Columns[nameof(User.FullName)].HeaderText = "NAMA LENGKAP";
            dgvUser.Columns[nameof(User.FullName)].Width = 220;
            dgvUser.Columns[nameof(User.Id)].Visible = false;
            dgvUser.Columns[nameof(User.Password)].Visible = false;
            dgvUser.Columns[nameof(User.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvUser.CurrentRow;
            txtUsername.Text = currentRow.Cells[nameof(User.Username)].Value.ToString();
            txtPassword.Text = currentRow.Cells[nameof(User.Password)].Value.ToString();
            txtFullName.Text = currentRow.Cells[nameof(User.FullName)].Value.ToString();

            // hidden fields
            txtUserId.Text = currentRow.Cells[nameof(User.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(User.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) 
                || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Data Username, Password dan Nama Lengkap tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangePassword.Checked)
            {
                chkChangePassword.ForeColor = SystemColors.ControlText;
                pnlRetypePassword.Visible = true;
            }
            else
            {
                chkChangePassword.ForeColor = Color.Gray;
                pnlRetypePassword.Visible = false;
            }
            SetUIButtonGroup();
        }

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;
            
            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;

            if (!chkChangePassword.Checked)
            {
                pnlButtons.Location = new Point(14, 233);
            }
            else
            {
                pnlButtons.Location = new Point(14, 320);
            }
        }
        
    }
}
