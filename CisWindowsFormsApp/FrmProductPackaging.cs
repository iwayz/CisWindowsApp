using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmProductPackaging : Form
    {
        readonly CisDbContext dbContext;
        readonly string productId;
        readonly string baseUnitId;
        readonly string baseUomCode;
        UnitOfWork<ProductPackaging> uowPackaging;

        public FrmProductPackaging(string productId, string productName, string baseUnitId, string baseUomCode)
        {
            InitializeComponent();
            dbContext = new CisDbContext();
            this.productId = productId;
            this.baseUnitId = baseUnitId;
            this.baseUomCode = baseUomCode;
            lblProductName.Text = productName;
            lblBaseUnit.Text = $"Satuan dasar: {baseUomCode}";
            lblBaseHint.Text = baseUomCode;
        }

        private void FrmProductPackaging_Load(object sender, EventArgs e)
        {
            uowPackaging = new UnitOfWork<ProductPackaging>(dbContext);
            BindUnitComboBox();
            BindGridView();
        }

        private void BindUnitComboBox()
        {
            var uom = new UnitOfWork<UnitOfMeasurement>(dbContext);
            var existingUnitIds = uowPackaging.Repository.GetAll()
                .Where(p => p.ProductId == productId)
                .Select(p => p.UnitId).ToList();

            var list = uom.Repository.GetAll()
                .Where(u => u.Id != baseUnitId && !existingUnitIds.Contains(u.Id))
                .OrderBy(u => u.UomCode);

            var ds = new Dictionary<string, string> { { "0", "--Pilih--" } };
            foreach (var u in list) ds.Add(u.Id, u.UomCode);

            cbUnit.DataSource = new BindingSource(ds, null);
            cbUnit.DisplayMember = "Value";
            cbUnit.ValueMember = "Key";
        }

        private void BindGridView()
        {
            var list = uowPackaging.Repository.GetAll()
                .Where(p => p.ProductId == productId)
                .OrderBy(p => p.Unit.UomCode)
                .Select(p => new
                {
                    p.Id,
                    UomCode = p.Unit.UomCode,
                    p.ConversionQty,
                    BaseUomCode = baseUomCode
                }).ToList();

            dgvPackaging.DataSource = list;
            if (dgvPackaging.Columns.Count > 0)
            {
                dgvPackaging.Columns["Id"].Visible = false;
                dgvPackaging.Columns["UomCode"].HeaderText = "Kemasan";
                dgvPackaging.Columns["ConversionQty"].HeaderText = "Isi (dlm satuan dasar)";
                dgvPackaging.Columns["BaseUomCode"].HeaderText = "Satuan Dasar";
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cbUnit.SelectedValue == null || cbUnit.SelectedValue.ToString() == "0")
            { CommonMessageHelper.DataCannotBeEmpty("Kemasan"); return; }
            if (!int.TryParse(txtConversionQty.Text.Trim(), out var conversionQty) || conversionQty <= 0)
            { MessageBox.Show("Isi kemasan harus lebih dari 0.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var packaging = new ProductPackaging
            {
                ProductId = productId,
                UnitId = cbUnit.SelectedValue.ToString(),
                ConversionQty = conversionQty,
                CreatedBy = Properties.Settings.Default.CurrentUserId,
                CreatedAt = DateTime.Now,
                ModifiedBy = Properties.Settings.Default.CurrentUserId,
                ModifiedAt = DateTime.Now
            };
            uowPackaging.Repository.Add(packaging);
            uowPackaging.Commit();

            txtConversionQty.Text = "0";
            BindUnitComboBox();
            BindGridView();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvPackaging.SelectedRows.Count == 0) return;
            var id = dgvPackaging.SelectedRows[0].Cells["Id"].Value.ToString();
            var toDel = uowPackaging.Repository.GetById(id);
            if (toDel == null) return;
            if (DialogResult.Yes != CommonMessageHelper.ConfirmDelete()) return;

            uowPackaging.Repository.Delete(toDel);
            uowPackaging.Commit();

            BindUnitComboBox();
            BindGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
