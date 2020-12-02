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
        List<int> foundIndices = new List<int>();

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
            BindRoleComboBox();

            isAdd = true;
            SetUIButtonGroup();

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

            BindRoleComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingRole = uowUser.Repository.GetAll().Where(u => u.Username == txtUsername.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtUsername.Text.Trim());
            }
            else
            {
                var userToAdd = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = new UserHelper().HashPassword(txtPassword.Text.Trim()),
                    FullName = txtFullName.Text.Trim(),
                     					 // Audit Fields 					CreatedBy = Guid.NewGuid().ToString().ToUpper(),
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Guid.NewGuid().ToString().ToUpper(),
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
                dgvUser.CurrentCell = this.dgvUser[1, gvSelectedIndex < dgvUser.RowCount ? gvSelectedIndex : gvSelectedIndex - 1];
                SetUIbySelectedGridItem();
                txtUserModifiedAt.Text = dgvUser.CurrentRow.Cells["UModifiedAt"].Value.ToString();
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
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowUser.Repository.Delete(uomToDel);
                    var res = uowUser.Commit();
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
                CommonMessageHelper.DataNotFound(txtUsername.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            
            if (chkChangePassword.Checked && !txtPassword.Text.Trim().Equals(txtRetypePassword.Text.Trim()))
            {
                MessageBox.Show("Pastikan password yang anda masukkan sama."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repoLastUpdated = DateTime.Parse(dgvUser.CurrentRow.Cells["UModifiedAt"].Value.ToString());
            var lastUpdated = DateTime.Parse(txtUserModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                CommonMessageHelper.DataHasBeenUpdated(txtUsername.Text.Trim());
            }
            else
            {
                using (var context = new CisDbContext())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        var now = DateTime.Now;
                        var uowUsr = new UnitOfWork<User>(context);
                        var userToUpdate = uowUsr.Repository.GetById(txtUserId.Text.Trim());
                        userToUpdate.Username = txtUsername.Text.Trim();

                        if (chkChangePassword.Checked)
                            userToUpdate.Password = new UserHelper().HashPassword(txtPassword.Text.Trim());

                        userToUpdate.FullName = txtFullName.Text.Trim();
                        userToUpdate.ModifiedBy = Guid.NewGuid().ToString().ToUpper();
                        userToUpdate.ModifiedAt = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                        uowUsr.Repository.Update(userToUpdate);
                        uowUsr.Commit();

                        var uowUsrRole = new UnitOfWork<UserRole>(context);
                        var userRoleToUpdate = uowUsrRole.Repository.GetById(txtUserRoleId.Text.ToString().Trim());
                        userRoleToUpdate.UserId = txtUserId.Text.Trim();
                        userRoleToUpdate.RoleId = cbRole.SelectedValue.ToString().Trim();
                        userRoleToUpdate.ModifiedBy = Guid.NewGuid().ToString().ToUpper();
                        userRoleToUpdate.ModifiedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        uowUsrRole.Repository.Update(userRoleToUpdate);
                        uowUsrRole.Commit();

                        dbContextTransaction.Commit();
                    }
                }

                //var userToUpdate = uowUser.Repository.GetById(txtUserId.Text.Trim());
                //userToUpdate.Username = txtUsername.Text.Trim();

                //if (chkChangePassword.Checked)
                //    userToUpdate.Password = new UserHelper().HashPassword(txtPassword.Text.Trim());
                
                //userToUpdate.FullName = txtFullName.Text.Trim();
                //userToUpdate.ModifiedBy = Guid.NewGuid().ToString().ToUpper();
                //userToUpdate.ModifiedAt = DateTime.Now;

                //uowUser.Repository.Update(userToUpdate);
                //uowUser.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReload.PerformClick();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvUser, ref foundIndices);
            dgvUser.CurrentCell = dgvUser[1, idx];
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


        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;

            if (!chkChangePassword.Checked)
            {
                pnlButtons.Location = new Point(14, 254);
            }
            else
            {
                pnlButtons.Location = new Point(14, 315);
            }
        }

        private void BindRoleComboBox()
        {
            var uow = new UnitOfWork<Role>(dbContext);
            var Roles = uow.Repository.GetAll().OrderBy(m => m.Description);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsRole = new Dictionary<string, string>();
            dsRole.Add("0", "--Pilih--");
            foreach (var role in Roles)
            {
                dsRole.Add(role.Id, role.RoleCode + " - " + role.Description);
                autoCompleteCollection.Add(role.RoleCode + " - " + role.Description);
            }

            cbRole.DataSource = new BindingSource(dsRole, null);
            cbRole.DisplayMember = "Value";
            cbRole.ValueMember = "Key";
            cbRole.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindUserGridView()
        {
            var users = new UnitOfWork<User>(dbContext).Repository.GetAll();
            var userRoles = new UnitOfWork<UserRole>(dbContext).Repository.GetAll();
            var roles = new UnitOfWork<Role>(dbContext).Repository.GetAll();

            var userRoleDetail = users
                .Join(userRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
                .Join(roles, uUr => uUr.ur.RoleId, r => r.Id, (uUr, r) => new { uUr, r })
                .Select(res => new
                {
                    UserId      = res.uUr.u.Id,
                    Username    = res.uUr.u.Username,
                    Password    = res.uUr.u.Password,
                    Fullname    = res.uUr.u.FullName,
                    UserRoleId  = res.uUr.ur.Id,
                    RoleId      = res.r.Id,
                    RoleCode    = res.r.RoleCode,
                    Description = res.r.Description,
                    UModifiedAt = res.uUr.u.ModifiedAt,
                    URModifiedAt= res.uUr.ur.ModifiedAt,
                });


            dgvUser.DataSource = userRoleDetail.OrderBy(e => e.Username).ToList();
        }

        private void SetUIGridView()
        {
            dgvUser.Columns[nameof(User.Username)].HeaderText = "USERNAME";
            dgvUser.Columns[nameof(User.FullName)].HeaderText = "NAMA LENGKAP";
            dgvUser.Columns[nameof(User.FullName)].Width = 220;
            dgvUser.Columns[nameof(Role.Description)].HeaderText = "ROLE";
            dgvUser.Columns[nameof(Role.Description)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // hidden fields
            //dgvUser.Columns["UserId"].Visible = false;
            //dgvUser.Columns[nameof(User.Password)].Visible = false;
            //dgvUser.Columns["UserRoleId"].Visible = false;
            //dgvUser.Columns[nameof(UserRole.RoleId)].Visible = false;
            //dgvUser.Columns[nameof(Role.RoleCode)].Visible = false;
            //dgvUser.Columns["UModifiedAt"].Visible = false;
            //dgvUser.Columns["URModifiedAt"].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvUser.CurrentRow;
            txtUsername.Text = currentRow.Cells[nameof(User.Username)].Value.ToString();
            txtPassword.Text = currentRow.Cells[nameof(User.Password)].Value.ToString();
            txtFullName.Text = currentRow.Cells[nameof(User.FullName)].Value.ToString();

            cbRole.SelectedValue = currentRow.Cells[nameof(UserRole.RoleId)].Value.ToString();


            // hidden fields
            txtUserId.Text = currentRow.Cells["UserId"].Value.ToString();
            txtUserRoleId.Text = currentRow.Cells["UserRoleId"].Value.ToString();
            txtRoleId.Text = currentRow.Cells[nameof(UserRole.RoleId)].Value.ToString();
            txtUserModifiedAt.Text = currentRow.Cells["UModifiedAt"].Value.ToString();
            txtUserRoleModifiedAt.Text = currentRow.Cells["URModifiedAt"].Value.ToString();

        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtUsername.Text)
                || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtFullName.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Username, Password dan Nama Lengkap");
                return false;

            }

            if (cbRole.Items.Count <= 1)
            {
                var emptyRefData = "User Role";
                CommonMessageHelper.ReferredDataNotSet(emptyRefData);
                return false;
            }
            return true;
        }
    }
}
