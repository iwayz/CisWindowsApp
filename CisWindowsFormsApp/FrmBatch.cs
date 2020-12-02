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
    public partial class FrmBatch : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Batch> uowBatch;
        bool isAdd = true;
        List<int> foundIndices = new List<int>();

        public FrmBatch()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmBatch_Load(object sender, EventArgs e)
        {
            uowBatch = new UnitOfWork<Batch>(dbContext);

            BindProductComboBox();
            BindBatchtGridView();
            SetUIGridView();

            isAdd = true;
            SetUIButtonGroup();

            txtBatchCode.Focus();
            CheckSourceRefData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetUIButtonGroup();
            txtBatchCode.Text = string.Empty;
            txtBatchCode.Focus();
            txtQuantity.Text = "0";
            dtpEntryDate.Value = DateTime.Now;
            dtpExpiredDate.Value = DateTime.Now;
            BindProductComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var existingProduct = uowBatch.Repository.GetAll().Where(p => p.BatchCode == txtBatchCode.Text.Trim()).FirstOrDefault();
            if (existingProduct != null)
            {
                CommonMessageHelper.DataAlreadyExist(txtBatchCode.Text.Trim());
            }
            else
            {
                var batchToAdd = new Batch
                {
                    BatchCode = txtBatchCode.Text.Trim(),
                    ProductId= cbProductCode.SelectedValue.ToString(),
                    Quantity = Convert.ToInt32(txtQuantity.Text.Trim()),
                    EntryDate = DateTime.Parse(dtpEntryDate.Value.ToString("yyyy-MM-dd")),
                    ExpiredDate= DateTime.Parse(dtpExpiredDate.Value.ToString("yyyy-MM-dd")),
                    
 					 // Audit Fields 
					CreatedBy = Guid.NewGuid().ToString().ToUpper(),
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Guid.NewGuid().ToString().ToUpper(),
                    ModifiedAt = DateTime.Now
                };
                uowBatch.Repository.Add(batchToAdd);
                uowBatch.Commit();
                btnReload.PerformClick();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var countProduct = uowBatch.Repository.GetAll().Count();
            if (countProduct <= 0)
            {
                gvSelectedIndex = 0;
                BindBatchtGridView();
                SetUIGridView();
                btnClear.PerformClick();
            }
            else
            {
                if (countProduct == 1)
                {
                    BindBatchtGridView();
                    SetUIGridView();
                    dgvBatch.CurrentCell = this.dgvBatch[1, 0];
                }
                gvSelectedIndex = dgvBatch.CurrentRow.Index;
                BindBatchtGridView();
                SetUIGridView();
                dgvBatch.CurrentCell = this.dgvBatch[1, gvSelectedIndex < dgvBatch.RowCount ? gvSelectedIndex : gvSelectedIndex - 1];
                SetUIbySelectedGridItem();
                txtModifiedAt.Text = dgvBatch.CurrentRow.Cells[nameof(Batch.ModifiedAt)].Value.ToString();
            }

            isAdd = dgvBatch.RowCount <= 0;
            SetUIButtonGroup();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var prodToDel = uowBatch.Repository.GetAll().Where(p => p.BatchCode == txtBatchCode.Text.Trim()).FirstOrDefault();
            if (prodToDel != null)
            {
                if (DialogResult.Yes == CommonMessageHelper.ConfirmDelete())
                {
                    uowBatch.Repository.Delete(prodToDel);
                    var res = uowBatch.Commit();
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
                CommonMessageHelper.DataNotFound(txtBatchCode.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMandatoryFields()) return;

            var repoLastUpdated = DateTime.Parse(dgvBatch.CurrentRow.Cells[nameof(Batch.ModifiedAt)].Value.ToString());
            var lastUpdated = DateTime.Parse(txtModifiedAt.Text.Trim());

            if (lastUpdated != repoLastUpdated)
            {
                CommonMessageHelper.DataHasBeenUpdated(txtBatchCode.Text.Trim());
            }
            else
            {
                var batchToUpdate = uowBatch.Repository.GetById(txtBatchId.Text.Trim());
                batchToUpdate.BatchCode = txtBatchCode.Text.Trim();
                batchToUpdate.ProductId = cbProductCode.SelectedValue.ToString();
                batchToUpdate.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                batchToUpdate.EntryDate = DateTime.Parse(dtpEntryDate.Value.ToString("yyyy-MM-dd"));
                batchToUpdate.ExpiredDate = DateTime.Parse(dtpExpiredDate.Value.ToString("yyyy-MM-dd"));
                batchToUpdate.ModifiedBy = Guid.NewGuid().ToString().ToUpper();
                batchToUpdate.ModifiedAt = DateTime.Now;

                uowBatch.Repository.Update(batchToUpdate);
                uowBatch.Commit();
                btnReload.PerformClick();
            }
        }

        private void SetUIbySelectedGridItem()
        {
            var currentRow = dgvBatch.CurrentRow;
            txtBatchCode.Text = currentRow.Cells[nameof(Batch.BatchCode)].Value.ToString();
            cbProductCode.SelectedValue = currentRow.Cells[nameof(Batch.ProductId)].Value.ToString();
            txtQuantity.Text = currentRow.Cells[nameof(Batch.Quantity)].Value.ToString();
            dtpEntryDate.Value = DateTime.Parse(currentRow.Cells[nameof(Batch.EntryDate)].Value.ToString());
            dtpExpiredDate.Value = DateTime.Parse(currentRow.Cells[nameof(Batch.ExpiredDate)].Value.ToString());
            
            // hidden fields
            txtBatchId.Text = currentRow.Cells[nameof(Batch.Id)].Value.ToString();
            txtModifiedAt.Text = currentRow.Cells[nameof(Batch.ModifiedAt)].Value.ToString();

        }

        private void BindProductComboBox()
        {
            var uow = new UnitOfWork<Product>(dbContext);
            var products = uow.Repository.GetAll().OrderBy(e => e.ProductCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dsProducts = new Dictionary<string, string>();
            dsProducts.Add("0", "--Pilih--");
            foreach (var prod in products)
            {
                dsProducts.Add(prod.Id, prod.ProductCode + " - " + prod.ProductName);
                autoCompleteCollection.Add(prod.ProductCode + " - " + prod.ProductName);
            }

            cbProductCode.DataSource = new BindingSource(dsProducts, null);
            cbProductCode.DisplayMember = "Value";
            cbProductCode.ValueMember = "Key";
            cbProductCode.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindBatchtGridView()
        {
            var batches = new UnitOfWork<Batch>(dbContext).Repository.GetAll().OrderBy(p => p.BatchCode);
            var products = new UnitOfWork<Product>(dbContext).Repository.GetAll().OrderBy(p => p.ProductCode);
            var prodBatch = batches
                .Join(products, b => b.ProductId, p => p.Id, (batch, prod) => new { batch, prod })
                .Select(pb => 
                new
                {
                    pb.batch.Id,
                    pb.batch.BatchCode,
                    pb.batch.ProductId,
                    pb.prod.ProductCode,
                    pb.prod.ProductName,
                    pb.batch.Quantity,
                    pb.batch.EntryDate,
                    pb.batch.ExpiredDate,
                    pb.batch.ModifiedAt
                });

            dgvBatch.DataSource = prodBatch.ToList();
        }

        private void SetUIGridView()
        {
            dgvBatch.Columns[nameof(Batch.BatchCode)].HeaderText = "KODE BATCH";
            dgvBatch.Columns[nameof(Batch.BatchCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBatch.Columns[nameof(Product.ProductCode)].HeaderText = "KODE PRODUK";
            dgvBatch.Columns[nameof(Product.ProductCode)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBatch.Columns[nameof(Product.ProductName)].HeaderText = "NAMA PRODUK";
            dgvBatch.Columns[nameof(Product.ProductName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBatch.Columns[nameof(Batch.Quantity)].HeaderText = "JUMLAH";
            dgvBatch.Columns[nameof(Batch.Quantity)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBatch.Columns[nameof(Batch.EntryDate)].HeaderText = "TGL. MASUK";
            dgvBatch.Columns[nameof(Batch.EntryDate)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBatch.Columns[nameof(Batch.ExpiredDate)].HeaderText = "TGL. KEDALUWARSA";
            dgvBatch.Columns[nameof(Batch.ExpiredDate)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvBatch.Columns[nameof(Batch.Id)].Visible = false;
            dgvBatch.Columns[nameof(Batch.ProductId)].Visible = false;
            dgvBatch.Columns[nameof(Batch.ModifiedAt)].Visible = false;
        }

        private bool ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtBatchCode.Text) || cbProductCode.Items.Count <= 1)
            {
                CommonMessageHelper.DataCannotBeEmpty("Kode Batch dan Nama Produk");
                return false;

            }

            if (cbProductCode.Items.Count <= 1 )
            {
                var emptyRefData = "Produk";
                CommonMessageHelper.ReferredDataNotSet(emptyRefData);
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CheckSourceRefData()
        {
            List<string> refData = new List<string>();
            if (cbProductCode.Items.Count <= 1) refData.Add("Produk");

            lblNoteDetail.Text = "Data referensi ("+ string.Join(", ", refData) + ") belum tersedia.";
            if (refData.Count > 0) pnlNote.Visible = true;
        }

        private void dgvBatch_Click(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchVal = txtSearch.Text.Trim();
            var idx = new CommonFunctionHelper().SearchGridViewFirstTwoColumn(searchVal, ref dgvBatch, ref foundIndices);
            dgvBatch.CurrentCell = dgvBatch[1, idx];
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

    }
}
