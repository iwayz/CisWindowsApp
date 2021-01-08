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
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.sari-sehat.com");
        }
    }
}
