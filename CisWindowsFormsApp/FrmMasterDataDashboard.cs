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
        public int AreaWidth { get; set; } = 1024;
        public int AreaHeight { get; set; } = 800;

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
            
            pnlMenu.Hide();
            OpenChildForm(new FrmRole(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Customer)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            pnlMenu.Hide();
            OpenChildForm(new FrmCustomer(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.User)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            pnlMenu.Hide();
            OpenChildForm(new FrmUser(), sender);
        }

        private void btnPrincipals_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Principal)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmPrincipal(), sender);
        }

        private void btnSalesAreas_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.SalesArea)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmSalesArea(), sender);
        }

        private void btnSalesmen_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Salesman)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmSalesman(), sender);
        }

        private void btnBatches_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Batch)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }

            pnlMenu.Hide();
            OpenChildForm(new FrmBatch(), sender);
        }

        private void btnOutletTypes_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.OutletType)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmOutletType(), sender);
        }

        private void btnMedCats_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.MedicineType)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }

            pnlMenu.Hide();
            OpenChildForm(new FrmMedicineCategoy(), sender);
        }


        private void btnUOM_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Uom)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmUOM(), sender);
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Location)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
            pnlMenu.Hide();
            OpenChildForm(new FrmLocation(), sender);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Product)))
            {
                CommonMessageHelper.NoAccess();
                return;
            }
            pnlMenu.Hide();
            OpenChildForm(new FrmProduct(), sender);
        }

        private void btnUsageTypes_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.UsageType)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }
            
            pnlMenu.Hide();
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
            gbMenu.Left = (AreaWidth - gbMenu.Width) / 2;
            gbMenu.Top = (AreaHeight- gbMenu.Height) / 5;

            lblMasterDataChildHeader.Left = (this.pnlChildHeader.Width - lblMasterDataChildHeader.Width) / 2;
            lblMasterDataChildHeader.Top = (this.pnlChildHeader.Height - lblMasterDataChildHeader.Height) / 2;
        }

        private void btnTermOfPayment_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.TermOfPayment)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }

            pnlMenu.Hide();
            OpenChildForm(new FrmTermOfPayment(), sender);
        }

        private void btnRepresentative_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.MasterData.Representative)))
            {
                CommonMessageHelper.NoAccess();
                return;

            }

            pnlMenu.Hide();
            OpenChildForm(new FrmRepresentative(), sender);
        }
    }
}
