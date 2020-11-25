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
    public partial class FrmSalesman : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Salesman> uowSalesman;
        bool isAdd = false;

        public FrmSalesman()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesman_Load(object sender, EventArgs e)
        {
            uowSalesman = new UnitOfWork<Salesman>(dbContext);

            BindRoleGridView();
            SetUIGridView();
            BindLocationComboBox(cbProvince, Constant.LocationType.Province);

            if (dgvSalesman.RowCount <= 0)
            {
                isAdd = true;
                SetUIButtonGroup();
            }

            txtSalesmanCode.Focus();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            
            txtSalesmanCode.Focus();
            txtSalesmanCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            rbFemale.Checked = true;
            txtAddress.Text = string.Empty;

            BindLocationComboBox(cbProvince, Constant.LocationType.Province);
            BindLocationComboBox(cbDistrict, Constant.LocationType.District);
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict);

            txtPostCode.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtSalesmanId.Text = string.Empty;
            txtModifiedAt.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var existingRole = uowSalesman.Repository.GetAll().Where(r => r.SalesmanCode == txtSalesmanCode.Text.Trim()).FirstOrDefault();
            if (existingRole != null)
            {
                MessageBox.Show("Data dengan Kode " + txtSalesmanCode.Text.Trim() + " sudah ada. Silakan gunakan Kode yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var salesmanToAdd = new Salesman
                {
                    SalesmanCode = txtSalesmanCode.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Gender = rbFemale.Checked ? Constant.Gender.Female : Constant.Gender.Male,
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    ProvinceId = cbProvince.SelectedValue.ToString(),
                    DistrictId = cbDistrict.SelectedValue.ToString(),
                    SubDistrictId = cbSubDistrict.SelectedValue.ToString(),

                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowSalesman.Repository.Add(salesmanToAdd);
                uowSalesman.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countRole = uowSalesman.Repository.GetAll().Count();
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
                    dgvSalesman.CurrentCell = this.dgvSalesman[1, 0];
                }
                gvSelectedIndex = dgvSalesman.CurrentRow.Index;
                BindRoleGridView();
                SetUIGridView();
                dgvSalesman.CurrentCell = this.dgvSalesman[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvSalesman.CurrentRow.Cells[nameof(Salesman.ModifiedAt)].Value.ToString();
            }
            isAdd = dgvSalesman.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var roleToDel = uowSalesman.Repository.GetAll().Where(u => u.SalesmanCode == txtSalesmanCode.Text.Trim()).FirstOrDefault();
            if (roleToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowSalesman.Repository.Delete(roleToDel);
                    uowSalesman.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtSalesmanCode.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;

            var repoLastUpdated = DateTime.Parse(dgvSalesman.CurrentRow.Cells[nameof(Salesman.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtSalesmanCode.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var salesmanToUpdate = uowSalesman.Repository.GetById(txtSalesmanId.Text.Trim());
                salesmanToUpdate.SalesmanCode = txtSalesmanCode.Text.Trim();
                salesmanToUpdate.FullName = txtFullName.Text.Trim();
                salesmanToUpdate.Gender = rbFemale.Checked ? Constant.Gender.Female : Constant.Gender.Male;
                salesmanToUpdate.Address = txtAddress.Text.Trim();
                salesmanToUpdate.PostalCode = txtPostCode.Text.Trim();
                salesmanToUpdate.Phone = txtPhone.Text.Trim();
                salesmanToUpdate.Email = txtEmail.Text.Trim();
                salesmanToUpdate.ProvinceId = cbProvince.SelectedValue.ToString();
                salesmanToUpdate.DistrictId = cbDistrict.SelectedValue.ToString();
                salesmanToUpdate.SubDistrictId = cbSubDistrict.SelectedValue.ToString();

                salesmanToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                salesmanToUpdate.ModifiedAt = DateTime.Now;

                uowSalesman.Repository.Update(salesmanToUpdate);
                uowSalesman.Commit();
                btnReload.PerformClick();
            }
        }

        private void dgvSalesman_Click(object sender, EventArgs e)
        {
            SetUIbySelectedGridItem();
        }

        private void BindRoleGridView()
        {
            var salesmen = new UnitOfWork<Salesman>(dbContext).Repository.GetAll().OrderBy(s => s.SalesmanCode);
            var uomDetail = salesmen.Select(salesman =>
            new
            {
                salesman.Id,
                salesman.SalesmanCode,
                salesman.FullName,
                salesman.Gender,
                salesman.Address,
                salesman.ProvinceId,
                salesman.DistrictId,
                salesman.SubDistrictId,
                salesman.PostalCode,
                salesman.Phone,
                salesman.Email,
                salesman.ModifiedAt
            });

            dgvSalesman.DataSource = uomDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvSalesman.Columns[nameof(Salesman.SalesmanCode)].HeaderText = "KODE SALESMAN";
            dgvSalesman.Columns[nameof(Salesman.SalesmanCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSalesman.Columns[nameof(Salesman.FullName)].HeaderText = "NAMA LENGKAP";
            dgvSalesman.Columns[nameof(Salesman.FullName)].Width = 300;
            dgvSalesman.Columns[nameof(Salesman.Phone)].HeaderText = "TELEPON";
            dgvSalesman.Columns[nameof(Salesman.Phone)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSalesman.Columns[nameof(Salesman.Email)].HeaderText = "EMAIL";
            dgvSalesman.Columns[nameof(Salesman.Email)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSalesman.Columns[nameof(Salesman.Id)].Visible = false;
            dgvSalesman.Columns[nameof(Salesman.ModifiedAt)].Visible = false;
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvSalesman.CurrentRow;
            txtSalesmanCode.Text = currentRow.Cells[nameof(Salesman.SalesmanCode)].Value.ToString();
            txtFullName.Text = currentRow.Cells[nameof(Salesman.FullName)].Value.ToString();
            rbFemale.Checked = currentRow.Cells[nameof(Salesman.Gender)].Value.ToString() == Constant.Gender.Female.ToString() ? true : false;
            rbMale.Checked = currentRow.Cells[nameof(Salesman.Gender)].Value.ToString() == Constant.Gender.Male.ToString() ? true : false;
            txtAddress.Text = currentRow.Cells[nameof(Salesman.Address)].Value.ToString();
            cbProvince.SelectedValue = currentRow.Cells[nameof(Salesman.ProvinceId)].Value.ToString();
            cbDistrict.SelectedValue = currentRow.Cells[nameof(Salesman.DistrictId)].Value.ToString();
            cbSubDistrict.SelectedValue = currentRow.Cells[nameof(Salesman.SubDistrictId)].Value.ToString();
            txtPostCode.Text = currentRow.Cells[nameof(Salesman.PostalCode)].Value.ToString();
            txtPhone.Text = currentRow.Cells[nameof(Salesman.Phone)].Value.ToString();
            txtEmail.Text = currentRow.Cells[nameof(Salesman.Email)].Value.ToString();
            
            // hidden fields
            txtSalesmanId.Text = currentRow.Cells[nameof(Salesman.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Salesman.ModifiedAt)].Value.ToString();

        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtSalesmanCode.Text) || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Data Kode Sales dan Nama Lengkap tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }

        private void BindLocationComboBox(ComboBox cbLocation, Constant.LocationType locationType, string parentId = "")
        {
            var uow = new UnitOfWork<Location>(dbContext);
            var locations = uow.Repository.GetAll();
            if (string.IsNullOrEmpty(parentId))
            {
                locations = locations
                    .Where(l => l.LocationType == locationType)
                    .OrderBy(l => l.Name);
            }
            else
            {
                locations = locations
                    .Where(l => l.LocationType == locationType && l.ParentId == parentId)
                    .OrderBy(l => l.Name);
            }
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsLocations = new Dictionary<string, string>();
            dsLocations.Add("0", "--Pilih--");
            foreach (var loc in locations)
            {
                dsLocations.Add(loc.Id, loc.Name);
                autoCompleteCollection.Add(loc.Name);
            }
            cbLocation.DataSource = new BindingSource(dsLocations, null);
            cbLocation.DisplayMember = "Value";
            cbLocation.ValueMember = "Key";
            cbLocation.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindLocationComboBox(cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());
        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
