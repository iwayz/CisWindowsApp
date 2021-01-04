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
    public partial class FrmCompanyInfo : Form
    {
        CisDbContext dbContext;
        UnitOfWork<CompanyInfo> uow;

        public FrmCompanyInfo()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmCompanyInfo_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork<CompanyInfo>(dbContext);
            LoadCompanyInfo();

            // only SUPER ADMIN can change the company info
            var enableAccess = UserCanAccess();
            gbContact.Enabled = enableAccess;
            gbLicense.Enabled = enableAccess;
            gbPic.Enabled = enableAccess;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCompanyInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save to db
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompName), txtName.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompAddress), txtAddress.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompPhone), txtPhone.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompEmail), txtEmail.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompWebsite), txtWeb.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompPbf), txtPbf.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompSiup), txtSiup.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompNpwp), txtNpwp.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.SalesPicName), txtPic.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.SalesPicSipaNo), txtSipa.Text);

            // update app settings
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompName)] = txtName.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompAddress)] = txtAddress.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompPhone)] = txtPhone.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompEmail)] = txtEmail.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompWebsite)] = txtWeb.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompPbf)] = txtPbf.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompSiup)] = txtSiup.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompNpwp)] = txtNpwp.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.SalesPicName)] = txtPic.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.SalesPicSipaNo)] = txtSipa.Text;
            Properties.Settings.Default.Save();

            btnReload.PerformClick();
            MessageBox.Show("Data telah berhasil disimpan. Silakan restart aplikasi ini agar perubahan bisa diterapkan."
                            , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadCompanyInfo()
        {
            var compInfo = uow.Repository.GetAll();
            var compName = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompName)).FirstOrDefault().Value;
            var compAddress = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompAddress)).FirstOrDefault().Value;
            var compPhone = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompPhone)).FirstOrDefault().Value;
            var compEmail = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompEmail)).FirstOrDefault().Value;
            var compWeb = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompWebsite)).FirstOrDefault().Value;
            var compPbf = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompPbf)).FirstOrDefault().Value;
            var compSiup = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompSiup)).FirstOrDefault().Value;
            var compNpwp = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.CompNpwp)).FirstOrDefault().Value;
            var salesPicName = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.SalesPicName)).FirstOrDefault().Value;
            var salesPicSipaNo = compInfo.Where(e => e.Key == nameof(Properties.Settings.Default.SalesPicSipaNo)).FirstOrDefault().Value;

            txtName.Text = compName;
            txtAddress.Text = compAddress;
            txtPhone.Text = compPhone;
            txtEmail.Text = compEmail;
            txtWeb.Text = compWeb;
            txtPbf.Text = compPbf;
            txtSiup.Text = compSiup;
            txtNpwp.Text = compNpwp;
            txtPic.Text = salesPicName;
            txtSipa.Text = salesPicSipaNo;
        }

        private void SaveCompInfoValue(string key, string val)
        {
            var valToUpdate = uow.Repository.GetAll().Where(e => e.Key == key).FirstOrDefault();
            valToUpdate.Value = val;
            valToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
            valToUpdate.ModifiedAt = DateTime.Now;

            uow.Repository.Update(valToUpdate);
            var res = uow.Commit();
        }

        private bool UserCanAccess()
        {
            var userRoles = new UnitOfWork<UserRole>(dbContext).Repository.GetAll().Where(e => e.UserId == Properties.Settings.Default.CurrentUserId);
            var roles = new UnitOfWork<Role>(dbContext).Repository.GetAll();
            return userRoles.Join(roles, ur => ur.RoleId, r => r.Id, (ur, r) => new { ur, r })
                 .Select(res => res.r.RoleCode.ToUpper() == "SUPER").FirstOrDefault();
        }
    }
}
