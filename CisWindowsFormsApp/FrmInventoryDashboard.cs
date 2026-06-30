using Cis.Model;
using System;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public partial class FrmInventoryDashboard : Form
    {
        private Form activeForm;

        public int AreaWidth { get; set; } = 1024;
        public int AreaHeight { get; set; } = 800;

        public FrmInventoryDashboard()
        {
            InitializeComponent();
        }

        private void FrmInventoryDashboard_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void FrmInventoryDashboard_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            gbMenu.Left = (pnlMenu.Width - gbMenu.Width) / 2;
            gbMenu.Top = (pnlMenu.Height - gbMenu.Height) / 5;

            lblInventoryChildHeader.Left = (pnlChildHeader.Width - lblInventoryChildHeader.Width) / 2;
            lblInventoryChildHeader.Top = (pnlChildHeader.Height - lblInventoryChildHeader.Height) / 2;
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Inventory.AdjustStock)))
            { CommonMessageHelper.NoAccess(); return; }
            OpenChildForm(new FrmStockAdjustment(), sender);
        }

        private void btnStockTransfer_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Inventory.TransferStock)))
            { CommonMessageHelper.NoAccess(); return; }
            OpenChildForm(new FrmStockTransfer(), sender);
        }

        private void btnStockOpname_Click(object sender, EventArgs e)
        {
            if (!(new CommonFunctionHelper().ValidateAccess((int)Constant.Permission.Inventory.StockOpname)))
            { CommonMessageHelper.NoAccess(); return; }
            OpenChildForm(new FrmStockOpname(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlInventoryChildren.Controls.Add(childForm);
            pnlInventoryChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblInventoryChildHeader.Text = childForm.Text;
            pnlMenu.Visible = false;
        }
    }
}
