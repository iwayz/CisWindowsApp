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
    public partial class FrmAbout : Form
    {
        CisDbContext dbContext;
        
        public FrmAbout()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.CompWebsite);
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            lblAssemblyVersion.Text = $"Assembly version: {assembly.GetName().Version.ToString()}";
            lblFileVersion.Text = $"File version: {fvi.FileVersion.ToString()}";

            var compInfo = new UnitOfWork<CompanyInfo>(dbContext).Repository.GetAll();

            lblCompanyName.Text = compInfo.FirstOrDefault(c => c.Key == nameof(Properties.Settings.Default.CompName))?.Value ?? Properties.Settings.Default.CompName;
            linkLabelWeb.Text = compInfo.FirstOrDefault(c => c.Key == nameof(Properties.Settings.Default.CompWebsite))?.Value ?? Properties.Settings.Default.CompWebsite;
            lblYear.Text = $"©{DateTime.Now.Year.ToString()}";
        }
    }
}
