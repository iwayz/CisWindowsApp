using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmSalesOrder : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<Salesman> uowSalesman;
        bool isAdd = false;
        List<int> foundIndices = new List<int>();
        CommonFunctionHelper commonHelper = new CommonFunctionHelper();


        public FrmSalesOrder()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmSalesOrder_Load(object sender, EventArgs e)
        {
            BindComboBoxCustomer();
            BindComboBoxSalesman();
            BindComboBoxTermOfPayment();
            BindComboBoxSalesArea();
            BindComboBoxProduct();
            commonHelper.BindLocationComboBox(dbContext, cbProvince, Constant.LocationType.Province);

            CheckSourceRefData();
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbDistrict, Constant.LocationType.District, cbProvince.SelectedValue.ToString());
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonHelper.BindLocationComboBox(dbContext, cbSubDistrict, Constant.LocationType.SubDistrict, cbDistrict.SelectedValue.ToString());
        }

        private void BindComboBoxCustomer()
        {
            var uow = new UnitOfWork<Customer>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.CustomerName);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.CustomerName);
                autoCompleteCollection.Add(res.CustomerName);
            }

            cbCustomer.DataSource = new BindingSource(dataSource, null);
            cbCustomer.DisplayMember = "Value";
            cbCustomer.ValueMember = "Key";
            cbCustomer.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxSalesman()
        {
            var uow = new UnitOfWork<Salesman>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.SalesmanCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.SalesmanCode);
                autoCompleteCollection.Add(res.SalesmanCode);
            }

            cbSalesman.DataSource = new BindingSource(dataSource, null);
            cbSalesman.DisplayMember = "Value";
            cbSalesman.ValueMember = "Key";
            cbSalesman.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxTermOfPayment()
        {
            var uow = new UnitOfWork<TermOfPayment>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.TermCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.TermCode);
                autoCompleteCollection.Add(res.TermCode);
            }

            cbTermOfPayment.DataSource = new BindingSource(dataSource, null);
            cbTermOfPayment.DisplayMember = "Value";
            cbTermOfPayment.ValueMember = "Key";
            cbTermOfPayment.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxSalesArea()
        {
            var uow = new UnitOfWork<SalesArea>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.AreaCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.AreaCode);
                autoCompleteCollection.Add(res.AreaCode);
            }

            cbSalesArea.DataSource = new BindingSource(dataSource, null);
            cbSalesArea.DisplayMember = "Value";
            cbSalesArea.ValueMember = "Key";
            cbSalesArea.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindComboBoxProduct()
        {
            var uow = new UnitOfWork<Product>(dbContext);
            var queryResult = uow.Repository.GetAll().OrderBy(e => e.ProductCode);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            Dictionary<string, string> dataSource = new Dictionary<string, string>();
            dataSource.Add("0", "--Pilih--");
            foreach (var res in queryResult)
            {
                dataSource.Add(res.Id, res.ProductCode + " - " + res.ProductName);
                autoCompleteCollection.Add(res.ProductCode + " - " + res.ProductName);
            }

            cbProduct.DataSource = new BindingSource(dataSource, null);
            cbProduct.DisplayMember = "Value";
            cbProduct.ValueMember = "Key";
            cbProduct.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void CheckSourceRefData()
        {
            List<string> refData = new List<string>();
            if (cbCustomer.Items.Count <= 1) refData.Add("Pelanggan");
            if (cbSalesman.Items.Count <= 1) refData.Add("Salesman");
            if (cbTermOfPayment.Items.Count <= 1) refData.Add("Term of Payment");
            if (cbSalesArea.Items.Count <= 1) refData.Add("Sales Area");

            lblNoteDetail.Text = "Data referensi (" + string.Join(", ", refData) + ") belum tersedia. ";
            if (refData.Count > 0) pnlNote.Visible = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            var disc = Convert.ToInt32(string.IsNullOrWhiteSpace(txtDiscount.Text) ? "0" : txtDiscount.Text);
            if (disc > 100)
            {
                MessageBox.Show("Discount tidak boleh melebihi angka 100.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Text = "0";
                txtDiscount.Focus();
            }
        }

        private void txtExtraDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int rowId = dgvSalesOrderItem.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = dgvSalesOrderItem.Rows[rowId];

            // Add the data
            row.Cells["productCode"].Value = "Value1";
            row.Cells["batchCode"].Value = "Value2";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var num = Convert.ToInt32(txtPrice.Text);
            MessageBox.Show(SpellNumber.Spell(num));
            
        }
    }
}
