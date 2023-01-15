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
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompLicenseNo), txtPbf.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.CompNpwp), txtNpwp.Text);

            SaveCompInfoValue(nameof(Properties.Settings.Default.PicName), txtPicName.Text);
            SaveCompInfoValue(nameof(Properties.Settings.Default.PicLicenseNo), txtPicLincenseNo.Text);

            // update app settings
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompName)] = txtName.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompAddress)] = txtAddress.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompPhone)] = txtPhone.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompEmail)] = txtEmail.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompWebsite)] = txtWeb.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompLicenseNo)] = txtPbf.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.CompNpwp)] = txtNpwp.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.PicName)] = txtPicName.Text;
            Properties.Settings.Default[nameof(Properties.Settings.Default.PicLicenseNo)] = txtPicLincenseNo.Text;
            Properties.Settings.Default.Save();


            // find the last sales order no and get the prefix
            //var salesOrderPrefix = new UnitOfWork<SalesOrder>(dbContext).Repository.GetAll()
            //    .OrderByDescending(so => so.SalesDate)
            //    .FirstOrDefault()?.SalesNo.Substring(0, 2) ?? string.Empty;
            //if (salesOrderPrefix != txtSalesOrderPrefix.Text.Trim()
            //    && DialogResult.Yes == MessageBox.Show("Terdapat perubahan pada Prefix No. Faktur dari data sebelumnya. Perubahan pada prefix akan berpengaruh pada penomoran faktur dan akan diset ulang dari awal (0). Yakin melakukan perubahan pada Prefix No. Faktur?"
            //    , "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    SaveCompInfoValue(nameof(Properties.Settings.Default.SalesOrderPrefix), txtSalesOrderPrefix.Text);
            //    Properties.Settings.Default[nameof(Properties.Settings.Default.SalesOrderPrefix)] = txtSalesOrderPrefix.Text;
            //}

            btnReload.PerformClick();
            MessageBox.Show("Data telah berhasil disimpan. Silakan restart aplikasi ini agar perubahan bisa diterapkan."
                            , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadCompanyInfo()
        {
            var compInfo = uow.Repository.GetAll();

            txtName.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompName))?.Value ?? Properties.Settings.Default.CompName;
            txtAddress.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompAddress))?.Value ?? Properties.Settings.Default.CompAddress;
            txtPhone.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompPhone))?.Value ?? Properties.Settings.Default.CompPhone;
            txtEmail.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompEmail))?.Value ?? Properties.Settings.Default.CompEmail;
            txtWeb.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompWebsite))?.Value ?? Properties.Settings.Default.CompWebsite;
            txtPbf.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompLicenseNo))?.Value ?? Properties.Settings.Default.CompLicenseNo;
            txtNpwp.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.CompNpwp))?.Value ?? Properties.Settings.Default.CompNpwp;
            //txtSalesOrderPrefix.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.SalesOrderPrefix))?.Value ?? Properties.Settings.Default.SalesOrderPrefix;

            txtPicName.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.PicName))?.Value ?? Properties.Settings.Default.PicName;
            txtPicLincenseNo.Text = compInfo.FirstOrDefault(e => e.Key == nameof(Properties.Settings.Default.PicLicenseNo))?.Value ?? Properties.Settings.Default.PicLicenseNo;

        }

        private void SaveCompInfoValue(string key, string val)
        {
            var valToUpdate = uow.Repository.GetAll().Where(e => e.Key == key).FirstOrDefault();
            if (valToUpdate != null)
            {
                valToUpdate.Value = val;
                valToUpdate.ModifiedBy = Properties.Settings.Default.CurrentUserId;
                valToUpdate.ModifiedAt = DateTime.Now;
                uow.Repository.Update(valToUpdate);
            }
            else
            {
                uow.Repository.Add(new CompanyInfo
                {
                    Key = key,
                    Value = val,
                    CreatedBy = Properties.Settings.Default.CurrentUserId,
                    CreatedAt = DateTime.Now,
                    ModifiedBy = Properties.Settings.Default.CurrentUserId,
                    ModifiedAt = DateTime.Now
                });
            }

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
