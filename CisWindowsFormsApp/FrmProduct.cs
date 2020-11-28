using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CisWindowsFormsApp
{
    public partial class FrmProduct : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Product> uowProduct;
        bool isAdd = true;

        public FrmProduct()
        {
            InitializeComponent();
            dbContext = new CisDbContext();

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            uowProduct = new UnitOfWork<Product>(dbContext);

            BindUomComboBox();
            BindMedicineCategoriesComboBox();
            BindUsageTypeComboBox();
            BindPrincipalComboBox();
            BindProductGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtProductCode.Focus();
        }
        
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtRestock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            var disc = Convert.ToInt32(string.IsNullOrWhiteSpace(txtDiscount.Text) ? "0" : txtDiscount.Text);
            if (disc > 100)
            {
                MessageBox.Show("Discount tidak boleh melebihi angka 100.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup(); 
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductCode.Focus();

            txtPrice.Text = "0";
            dtpDecreeDate.Value = DateTime.Now;
            txtDiscount.Text = "0";
            txtRestock.Text = "0";
            BindUomComboBox();
            BindMedicineCategoriesComboBox();
            BindUsageTypeComboBox();
            BindPrincipalComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            var existingProduct = uowProduct.Repository.GetAll().Where(p => p.ProductCode == txtProductCode.Text.Trim()).FirstOrDefault();
            if (existingProduct != null)
            {
                MessageBox.Show("Data dengan Kode " + txtProductCode.Text.Trim() + " sudah ada. Silakan gunakan Kode Produk yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var prodToAdd = new Product
                {
                    ProductCode = txtProductCode.Text.Trim(),
                    ProductName = txtProductName.Text.Trim(),
                    Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                    PriceDecreeDate = DateTime.Parse(dtpDecreeDate.Value.ToString("yyyy-MM-dd")),
                    Discount = float.Parse(txtDiscount.Text.Trim()),
                    RestockLevel = Convert.ToInt32(txtRestock.Text.Trim()),
                    UnitId = cbUom.SelectedValue.ToString(),
                    MedicineCatId = cbMedCat.SelectedValue.ToString(),
                    UsageTypeId = cbUsageType.SelectedValue.ToString(),
                    PrincipalId = cbPrincipal.SelectedValue.ToString(),
                    CreatedBy = Properties.Settings.Default.CurrentUser,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUser,
                    ModifiedAt = DateTime.Now
                };
                uowProduct.Repository.Add(prodToAdd);
                uowProduct.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmptyField()) return;
            
            var repoLastUpdated = DateTime.Parse(dgvProduct.CurrentRow.Cells[nameof(Product.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());
            
            if (lastUpdated != repoLastUpdated)
            {
                MessageBox.Show("Data dengan Kode " + txtProductCode.Text.Trim() + " telah diupdate sebelumnya. Silakan klik Reload untuk mendapatkan data terbaru dan ubah data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var prodToUpdate = uowProduct.Repository.GetById(txtProductId.Text.Trim());
                prodToUpdate.ProductCode = txtProductCode.Text.Trim();
                prodToUpdate.ProductName = txtProductName.Text.Trim();
                prodToUpdate.Price = Convert.ToDecimal(txtPrice.Text.Trim());
                prodToUpdate.PriceDecreeDate = DateTime.Parse(dtpDecreeDate.Value.ToString("yyyy-MM-dd"));
                prodToUpdate.Discount = float.Parse(txtDiscount.Text.Trim());
                prodToUpdate.RestockLevel = Convert.ToInt32(txtRestock.Text.Trim());
                prodToUpdate.UnitId = cbUom.SelectedValue.ToString();
                prodToUpdate.MedicineCatId = cbMedCat.SelectedValue.ToString();
                prodToUpdate.UsageTypeId = cbUsageType.SelectedValue.ToString();
                prodToUpdate.PrincipalId = cbPrincipal.SelectedValue.ToString();
                prodToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUser;
                prodToUpdate.ModifiedAt = DateTime.Now;

                uowProduct.Repository.Update(prodToUpdate);
                uowProduct.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var prodToDel = uowProduct.Repository.GetAll().Where(p => p.ProductCode == txtProductCode.Text.Trim()).FirstOrDefault();
            if (prodToDel != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    uowProduct.Repository.Delete(prodToDel);
                    uowProduct.Commit();
                    btnReload.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Data dengan Kode " + txtProductCode.Text.Trim() + " tidak ditemukan. Silakan klik Reload dan hapus data yang diinginkan."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countProduct = uowProduct.Repository.GetAll().Count();
            if (countProduct <= 0)
            {
                gvSelectedIndex = 0;
                BindProductGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countProduct == 1)
                {
                    BindProductGridView();
                    SetUIGridView();
                    dgvProduct.CurrentCell = this.dgvProduct[1, 0];
                }
                gvSelectedIndex = dgvProduct.CurrentRow.Index;
                BindProductGridView();
                SetUIGridView();
                dgvProduct.CurrentCell = this.dgvProduct[1, gvSelectedIndex];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvProduct.CurrentRow.Cells[nameof(Product.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvProduct.RowCount <= 0;
            SetUIButtonGroup();

        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvProduct.CurrentRow;
            txtProductCode.Text = currentRow.Cells[nameof(Product.ProductCode)].Value.ToString();
            txtProductName.Text = currentRow.Cells[nameof(Product.ProductName)].Value.ToString();
            txtPrice.Text = currentRow.Cells[nameof(Product.Price)].Value.ToString();
            dtpDecreeDate.Value = DateTime.Parse(currentRow.Cells[nameof(Product.PriceDecreeDate)].Value.ToString());
            txtDiscount.Text = currentRow.Cells[nameof(Product.Discount)].Value.ToString();
            txtRestock.Text = currentRow.Cells[nameof(Product.RestockLevel)].Value.ToString();
            cbUom.SelectedValue = currentRow.Cells[nameof(Product.UnitId)].Value.ToString();
            cbMedCat.SelectedValue = currentRow.Cells[nameof(Product.MedicineCatId)].Value.ToString();
            cbUsageType.SelectedValue = currentRow.Cells[nameof(Product.UsageTypeId)].Value.ToString();
            cbPrincipal.SelectedValue = currentRow.Cells[nameof(Product.PrincipalId)].Value.ToString();

            // hidden fields
            txtProductId.Text = currentRow.Cells[nameof(Product.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Product.ModifiedAt)].Value.ToString();

        }

        private void BindUomComboBox()
        {
            var uow = new UnitOfWork<UnitOfMeasurement>(dbContext);
            var uoms = uow.Repository.GetAll().OrderBy(m => m.Description);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsUoms = new Dictionary<string, string>();
            foreach (var uom in uoms)
            {
                dsUoms.Add(uom.Id, uom.Description);
                autoCompleteCollection.Add(uom.Description);
            }

            cbUom.DataSource = new BindingSource(dsUoms, null);
            cbUom.DisplayMember = "Value";
            cbUom.ValueMember = "Key";
            cbUom.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindMedicineCategoriesComboBox()
        {
            var uow = new UnitOfWork<MedicineCat>(dbContext);
            var medCats = uow.Repository.GetAll().OrderBy(m => m.Description);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsMedCats = new Dictionary<string, string>();
            foreach (var medicineCat in medCats)
            {
                dsMedCats.Add(medicineCat.Id, medicineCat.Description);
                autoCompleteCollection.Add(medicineCat.Description);
            }

            cbMedCat.DataSource = new BindingSource(dsMedCats, null);
            cbMedCat.DisplayMember = "Value";
            cbMedCat.ValueMember = "Key";
            cbMedCat.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindUsageTypeComboBox()
        {
            var uow = new UnitOfWork<UsageType>(dbContext);
            var usageTypes = uow.Repository.GetAll().OrderBy(u => u.Description);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsUsageTypes = new Dictionary<string, string>();
            foreach (var usageType in usageTypes)
            {
                dsUsageTypes.Add(usageType.Id, usageType.Description);
                autoCompleteCollection.Add(usageType.Description);
            }

            cbUsageType.DataSource = new BindingSource(dsUsageTypes, null);
            cbUsageType.DisplayMember = "Value";
            cbUsageType.ValueMember = "Key";
            cbUsageType.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindPrincipalComboBox()
        {
            var uow = new UnitOfWork<Principal>(dbContext);
            var principals = uow.Repository.GetAll().OrderBy(p => p.PrincipalName);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsPrincipals = new Dictionary<string, string>();
            foreach (var principal in principals)
            {
                dsPrincipals.Add(principal.Id, principal.PrincipalName);
                autoCompleteCollection.Add(principal.PrincipalName);
            }

            cbPrincipal.DataSource = new BindingSource(dsPrincipals, null);
            cbPrincipal.DisplayMember = "Value";
            cbPrincipal.ValueMember = "Key";
            cbPrincipal.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindProductGridView()
        {
            var products = new UnitOfWork<Product>(dbContext).Repository.GetAll().OrderBy(p => p.ProductCode);
            var prodDetail = products.Select(prod =>
            new
            {
                prod.Id,
                prod.ProductCode,
                prod.ProductName,
                prod.Price,
                prod.PriceDecreeDate,
                prod.Discount,
                prod.RestockLevel,
                prod.UnitId,
                prod.MedicineCatId,
                prod.UsageTypeId,
                prod.PrincipalId,
                prod.ModifiedAt
            });

            dgvProduct.DataSource = prodDetail.ToList();
        }

        private void SetUIGridView()
        {
            dgvProduct.Columns[nameof(Product.ProductCode)].HeaderText = "KODE";
            dgvProduct.Columns[nameof(Product.ProductName)].HeaderText = "NAMA PRODUK";
            dgvProduct.Columns[nameof(Product.ProductName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[nameof(Product.Price)].HeaderText = "HARGA";
            dgvProduct.Columns[nameof(Product.Price)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduct.Columns[nameof(Product.PriceDecreeDate)].HeaderText = "SK. HARGA";
            dgvProduct.Columns[nameof(Product.PriceDecreeDate)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduct.Columns[nameof(Product.Discount)].HeaderText = "DISC";
            dgvProduct.Columns[nameof(Product.Discount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduct.Columns[nameof(Product.RestockLevel)].HeaderText = "RESTOCK";
            dgvProduct.Columns[nameof(Product.RestockLevel)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduct.Columns[nameof(Product.Id)].Visible = false;
            dgvProduct.Columns[nameof(Product.UnitId)].Visible = false;
            dgvProduct.Columns[nameof(Product.MedicineCatId)].Visible = false;
            dgvProduct.Columns[nameof(Product.UsageTypeId)].Visible = false;
            dgvProduct.Columns[nameof(Product.PrincipalId)].Visible = false;
            dgvProduct.Columns[nameof(Product.ModifiedAt)].Visible = false;
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private bool ValidateEmptyField()
        {
            if (string.IsNullOrEmpty(txtProductCode.Text) || string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Data Kode Produk dan Nama Produk tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            return true;
        }

        private void SetUIButtonGroup()
        {
            btnSave.Enabled = !isAdd;
            btnDel.Enabled = !isAdd;

            btnSave.BackColor = !isAdd ? Color.FromArgb( 36, 141, 193) : Color.Gray;
            btnDel.BackColor = !isAdd ? Color.FromArgb( 36, 141, 193) : Color.Gray;

        }
    }
}
