using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{

    public partial class FrmMasterDataDashboard : Form
    {
        private Form activeForm;

        public FrmMasterDataDashboard()
        {
            InitializeComponent();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRole(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCustomer(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUser(), sender);
        }

        private void btnPrincipals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPrincipal(), sender);
        }

        private void btnSalesAreas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSalesArea(), sender);
        }

        private void btnSalesmen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSalesman(), sender);
        }

        private void btnBatches_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBatch(), sender);
        }

        private void btnOutletTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmOutletType(), sender);
        }

        private void btnMedCats_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMedicineCategoy(), sender);
        }

        private void btnUserRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUserRole(), sender);
        }

        private void btnUOM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUOM(), sender);
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLocation(), sender);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProduct(), sender);
        }

        private void btnUsageTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUsageType(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMasterDataChildren.Controls.Add(childForm);
            this.pnlMasterDataChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblMasterDataChildHeader.Text = childForm.Text;
        }

        private void FrmMasterDataDashboard_Load(object sender, EventArgs e)
        {
            //btnProducts.PerformClick();
        }
    }
}
