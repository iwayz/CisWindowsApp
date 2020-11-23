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
    public partial class FrmLocation : Form
    {
        CisDbContext dbContext;

        public FrmLocation()
        {
            InitializeComponent();
            dbContext = new CisDbContext();

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var total = BindDataListView(lvProvince, Constant.LocationType.Province);
            lblTotalProvince.Text = total.ToString();
        }

        private int BindDataListView(ListView parentListView, Constant.LocationType locationType, string parentId = "")
        {
            var uow = new UnitOfWork<Location>(dbContext);
            IQueryable<Location> locations;
            if (string.IsNullOrEmpty(parentId))
            {
                locations = uow.Repository.GetAll().Where(l => l.LocationType == locationType)
                    .OrderBy(l => l.Name);
            }
            else
            {
                locations = uow.Repository.GetAll().Where(l => l.LocationType == locationType && l.ParentId == parentId)
                    .OrderBy(l => l.Name);
            }

            parentListView.Items.Clear();
            parentListView.Columns[0].Width = 0;
            foreach (var loc in locations)
            {
                var listViewItem = new ListViewItem(loc.Id);
                listViewItem.SubItems.Add(loc.Name);
                parentListView.Items.Add(listViewItem);
            }
            return locations.Count();
        }

        private void lvDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDistrict.SelectedItems.Count < 1) return;

            var total = BindDataListView(lvSubDistrict, Constant.LocationType.SubDistrict, lvDistrict.SelectedItems[0].Text);
            lblTotalSubDistrict.Text = total.ToString();
            lblDistrict.Text = lvDistrict.SelectedItems[0].SubItems[1].Text;
        }

        private void lvProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProvince.SelectedItems.Count < 1) return;

            var total = BindDataListView(lvDistrict, Constant.LocationType.District, lvProvince.SelectedItems[0].Text);
            lblTotalDistrict.Text = total.ToString();
            lvSubDistrict.Items.Clear();
            lblTotalSubDistrict.Text = "0";
            lblProvince.Text = lvProvince.SelectedItems[0].SubItems[1].Text;
        }
    }
}
