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
        bool isAdd = false;
        List<int> foundIndices = new List<int>();

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

            isAdd = true;
            SetUIButtonGroup();


            BindCheckBoxList(cblMasterData, Constant.Permission.PermissionType.Master);
            BindCheckBoxList(cblTransaksi, Constant.Permission.PermissionType.Transaction);

            txtRoleCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup(); 
            txtRoleCode.Text = string.Empty;
            txtDescription.Text = string.Empty;

            ClearCheckedItems(cblMasterData);
            ClearCheckedItems(cblTransaksi);
            ClearCheckedItems(cblReporting);

            txtRoleCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            var existingRole = uowRole.Repository.GetAll().Where(r => r.RoleCode == txtRoleCode.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtRoleCode.Text.Trim());
            }
            else
            {
                using (var context = new CisDbContext())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        var roleToAdd = new Role
                        {
                            RoleCode = txtRoleCode.Text.Trim(),
                            Description = txtDescription.Text.Trim(),

                            // Audit Fields 
                            CreatedBy = Properties.Settings.Default.CurrentUserId,
                            CreatedAt = DateTime.Now,
                            ModifiedBy = Properties.Settings.Default.CurrentUserId,
                            ModifiedAt = DateTime.Now
                        };
                        var uwRole = new UnitOfWork<Role>(context);
                        uwRole.Repository.Add(roleToAdd);
                        uwRole.Commit();

                        var permRolesToAdd = GetSelectedRolePermisions(roleToAdd.Id);
                        var uwPermRole = new UnitOfWork<PermissionRole>(context);
                        uwPermRole.Repository.Add(permRolesToAdd);
                        uwPermRole.Commit();

                        dbContextTransaction.Commit();
                    }
                }

                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
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
                dgvRole.CurrentCell = this.dgvRole[1, gvSelectedIndex < dgvRole.RowCount ? gvSelectedIndex : gvSelectedIndex - 1];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvRole.CurrentRow.Cells[nameof(Role.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvRole.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowRole.Repository.GetAll().Where(u => u.RoleCode == txtRoleCode.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowRole.Repository.Delete(roleToDel);
                    var res = uowRole.Commit();
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
                CommonMessageHelper.DataNotFound(txtRoleCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;
            
            var repoLastUpdated = uowRole.Repository.GetById(txtRoleId.Text.Trim()).ModifiedAt;
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            var commonHelper = new CommonFunctionHelper();
            if (commonHelper.StandardizeDateTime(lastUpdated) != commonHelper.StandardizeDateTime(repoLastUpdated))
            {
                CommonMessageHelper.DataHasBeenUpdatedPriorToSave(txtRoleCode.Text.Trim());
            }
            else
            {
                using (var context = new CisDbContext())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {

                        var roleToUpdate = uowRole.Repository.GetById(txtRoleId.Text.Trim());
                        roleToUpdate.RoleCode = txtRoleCode.Text.Trim();
                        roleToUpdate.Description = txtDescription.Text.Trim();
                        roleToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                        roleToUpdate.ModifiedAt = DateTime.Now;

                        var uwRole = new UnitOfWork<Role>(context);
                        uwRole.Repository.Update(roleToUpdate);
                        uwRole.Commit();


                        var uwPermRole = new UnitOfWork<PermissionRole>(context);
                        var existingAccessCodes = GetExistingAccessCodes();
                        for (int i = 0; i < cblMasterData.Items.Count; i++)
                        {
                            var permissionCode = existingAccessCodes.Where(a => cblMasterData.Items[i].ToString().Contains(a.ToString())).FirstOrDefault().ToString();
                            var permission = new UnitOfWork<Permission>(dbContext).Repository.GetAll()
                                .Where(perm => perm.PermissionCode == permissionCode).FirstOrDefault();
                            var permRole = uwPermRole.Repository.GetAll().Where(pr => pr.PermisionId == permission.Id && pr.RoleId == roleToUpdate.Id).FirstOrDefault();

                            if (cblMasterData.GetItemCheckState(i) == CheckState.Unchecked && permRole != null)
                            {
                                uwPermRole.Repository.Delete(permRole);
                            }
                            else if (cblMasterData.GetItemCheckState(i) == CheckState.Checked && permRole == null)
                            {
                                var permRoleToAdd = new PermissionRole
                                {
                                    RoleId = roleToUpdate.Id,
                                    PermisionId = permission.Id,

                                    // Audit Fields 
                                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                                    CreatedAt = DateTime.Now,
                                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                                    ModifiedAt = DateTime.Now
                                };
                                uwPermRole.Repository.Add(permRoleToAdd);
                            }

                            uwPermRole.Commit();
                        }

                        for (int i = 0; i < cblTransaksi.Items.Count; i++)
                        {
                            var permissionCode = existingAccessCodes.Where(a => cblTransaksi.Items[i].ToString().Contains(a.ToString())).FirstOrDefault().ToString();
                            var permission = new UnitOfWork<Permission>(dbContext).Repository.GetAll()
                                .Where(perm => perm.PermissionCode == permissionCode).FirstOrDefault();
                            var permRole = uwPermRole.Repository.GetAll().Where(pr => pr.PermisionId == permission.Id && pr.RoleId == roleToUpdate.Id).FirstOrDefault();

                            if (cblTransaksi.GetItemCheckState(i) == CheckState.Unchecked && permRole != null)
                            {
                                uwPermRole.Repository.Delete(permRole);
                            }
                            else if (cblTransaksi.GetItemCheckState(i) == CheckState.Checked && permRole == null)
                            {
                                var permRoleToAdd = new PermissionRole
                                {
                                    RoleId = roleToUpdate.Id,
                                    PermisionId = permission.Id,

                                    // Audit Fields 
                                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                                    CreatedAt = DateTime.Now,
                                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                                    ModifiedAt = DateTime.Now
                                };
                                uwPermRole.Repository.Add(permRoleToAdd);
                            }

                            uwPermRole.Commit();
                        }

                        for (int i = 0; i < cblReporting.Items.Count; i++)
                        {
                            var permissionCode = existingAccessCodes.Where(a => cblReporting.Items[i].ToString().Contains(a.ToString())).FirstOrDefault().ToString();
                            var permission = new UnitOfWork<Permission>(dbContext).Repository.GetAll()
                                .Where(perm => perm.PermissionCode == permissionCode).FirstOrDefault();
                            var permRole = uwPermRole.Repository.GetAll().Where(pr => pr.PermisionId == permission.Id && pr.RoleId == roleToUpdate.Id).FirstOrDefault();

                            if (cblReporting.GetItemCheckState(i) == CheckState.Unchecked && permRole != null)
                            {
                                uwPermRole.Repository.Delete(permRole);
                            }
                            else if (cblReporting.GetItemCheckState(i) == CheckState.Checked && permRole == null)
                            {
                                var permRoleToAdd = new PermissionRole
                                {
                                    RoleId = roleToUpdate.Id,
                                    PermisionId = permission.Id,

                                    // Audit Fields 
                                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                                    CreatedAt = DateTime.Now,
                                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                                    ModifiedAt = DateTime.Now
                                };
                                uwPermRole.Repository.Add(permRoleToAdd);
                            }

                            uwPermRole.Commit();
                        }

                        dbContextTransaction.Commit();
                    }
                }

                btnReload.PerformClick();
                CommonMessageHelper.DataSavedSuccessfully();
            }
        }

        private void dgvRole_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
            LoadRolePermision();
        }

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb(36, 141, 193) : Color.Gray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvRole, ref foundIndices);
            dgvRole.CurrentCell = dgvRole[1, idx];
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
            dgvRole.Columns[nameof(Role.Description)].Width = 300;
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

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtRoleCode.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Role dan Keterangan");
                return false;
            }
            return true;
        }

        private void BindCheckBoxList(CheckedListBox checkBoxList, Constant.Permission.PermissionType permissionType)
        {
            var permissions = new UnitOfWork<Permission>(dbContext).Repository.GetAll()
                .Where(e => e.PermisionType == permissionType)
                .OrderBy(e => e.PermissionCode);

            foreach (var item in permissions)
            {
                checkBoxList.Items.Add(item.PermissionCode + " - " + item.Description);
            }
        }

        private List<PermissionRole> GetSelectedRolePermisions(string roleId)
        {
            List<PermissionRole> permissionRoles = new List<PermissionRole>();
            var existingAccessCodes = GetExistingAccessCodes();
            var checkedItems = cblMasterData.CheckedItems.OfType<object>().ToList();
            checkedItems.AddRange(cblTransaksi.CheckedItems.OfType<object>().ToList());
            checkedItems.AddRange(cblReporting.CheckedItems.OfType<object>().ToList());

            foreach (var checkedItem in checkedItems)
            {
                var permissionCode = existingAccessCodes.Where(a => checkedItem.ToString().Contains(a.ToString())).FirstOrDefault().ToString();
                var permission = new UnitOfWork<Permission>(dbContext).Repository.GetAll()
                    .Where(e => e.PermissionCode == permissionCode).FirstOrDefault();

                var permRole = new PermissionRole
                {
                    RoleId = roleId.ToUpper(),
                    PermisionId = permission.Id,

                    // Audit Fields 
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                };
                permissionRoles.Add(permRole);
            }
            return permissionRoles;
        }

        private List<int> GetExistingAccessCodes()
        {
            var existingAccessCodes = Enum.GetValues(typeof(Constant.Permission.MasterData)).Cast<int>().ToList();
            existingAccessCodes.AddRange(Enum.GetValues(typeof(Constant.Permission.Transaction)).Cast<int>().ToList());
            // TODO: ACTIVATE this when the reporting is ready
            //existingAccessCodes.AddRange(Enum.GetValues(typeof(Constant.Permission.Reporting)).Cast<int>().ToList());
            
            return existingAccessCodes;
        }

        private void LoadRolePermision()
        {
            var uowPermission = new UnitOfWork<Permission>(dbContext);
            var uowPermissionRole = new UnitOfWork<PermissionRole>(dbContext);
            var permissions = uowPermission.Repository.GetAll();
            var permissionCodes = uowPermissionRole.Repository.GetAll()
                .Where(p => p.RoleId == txtRoleId.Text.ToString().Trim())
                .Join(permissions, pr => pr.PermisionId, p => p.Id, (pr, p) => new { pr, p })
                .Select(res => res.p.PermissionCode)
                .ToList();

            SetItemChecked(cblMasterData, permissionCodes);
            SetItemChecked(cblTransaksi, permissionCodes);
            SetItemChecked(cblReporting, permissionCodes);
        }

        private void SetItemChecked(CheckedListBox checkedListBox, List<string> permissionCodes)
        {
            ClearCheckedItems(checkedListBox);
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (permissionCodes.Any(p => checkedListBox.Items[i].ToString().Contains(p)))
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
           
            checkedListBox.Refresh();
        }

        private void ClearCheckedItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }

            checkedListBox.Refresh();
        }
    }
}
