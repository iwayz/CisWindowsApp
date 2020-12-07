using Cis.Model;
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
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Role)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmRole(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Customer)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            OpenChildForm(new FrmCustomer(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.User)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            OpenChildForm(new FrmUser(), sender);
        }

        private void btnPrincipals_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Principal)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmPrincipal(), sender);
        }

        private void btnSalesAreas_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.SalesArea)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmSalesArea(), sender);
        }

        private void btnSalesmen_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Salesman)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmSalesman(), sender);
        }

        private void btnBatches_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Batch)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            OpenChildForm(new FrmBatch(), sender);
        }

        private void btnOutletTypes_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.OutletType)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmOutletType(), sender);
        }

        private void btnMedCats_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.MedicineType)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }

            OpenChildForm(new FrmMedicineCategoy(), sender);
        }


        private void btnUOM_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Uom)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
            OpenChildForm(new FrmUOM(), sender);
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Location)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
            OpenChildForm(new FrmLocation(), sender);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Product)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            OpenChildForm(new FrmProduct(), sender);
        }

        private void btnUsageTypes_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.UsageType)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
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
