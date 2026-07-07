namespace CisWindowsFormsApp
{
    partial class FrmLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocation));
            this.lvProvince = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDistrict = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSubDistrict = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalProvince = new System.Windows.Forms.Label();
            this.lblTotalDistrict = new System.Windows.Forms.Label();
            this.lblTotalSubDistrict = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            System.Windows.Forms.Panel pnlActionBar = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlContent = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlMain = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlProvince = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlSpacer1 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlDistrict = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlSpacer2 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlSubDistrict = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel panel2 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel panel3 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblProvinceTitle = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblDistrictTitle = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblSubDistrictTitle = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblStatProvinceHeader = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblStatProvinceSubHeader = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblStatDistrictHeader = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblStatSubDistrictHeader = new System.Windows.Forms.Label();
            pnlContent.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlProvince.SuspendLayout();
            panel1.SuspendLayout();
            pnlDistrict.SuspendLayout();
            panel2.SuspendLayout();
            pnlSubDistrict.SuspendLayout();
            panel3.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlActionBar
            //
            pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlActionBar.Location = new System.Drawing.Point(0, 0);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new System.Drawing.Size(1360, 52);
            pnlActionBar.TabIndex = 0;
            //
            // pnlContent
            //
            pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            pnlContent.Controls.Add(pnlMain);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 52);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(8);
            pnlContent.Size = new System.Drawing.Size(1360, 668);
            pnlContent.TabIndex = 1;
            //
            // pnlMain
            //
            pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            pnlMain.Controls.Add(pnlSubDistrict);
            pnlMain.Controls.Add(pnlSpacer2);
            pnlMain.Controls.Add(pnlDistrict);
            pnlMain.Controls.Add(pnlSpacer1);
            pnlMain.Controls.Add(pnlProvince);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new System.Windows.Forms.Padding(12);
            pnlMain.Size = new System.Drawing.Size(1344, 652);
            pnlMain.TabIndex = 0;
            //
            // pnlProvince
            //
            pnlProvince.BackColor = System.Drawing.Color.White;
            pnlProvince.Controls.Add(this.lvProvince);
            pnlProvince.Controls.Add(panel1);
            pnlProvince.Controls.Add(lblProvinceTitle);
            pnlProvince.Dock = System.Windows.Forms.DockStyle.Left;
            pnlProvince.Location = new System.Drawing.Point(12, 12);
            pnlProvince.Name = "pnlProvince";
            pnlProvince.Size = new System.Drawing.Size(424, 628);
            pnlProvince.TabIndex = 0;
            //
            // pnlSpacer1
            //
            pnlSpacer1.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSpacer1.Location = new System.Drawing.Point(436, 12);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new System.Drawing.Size(8, 628);
            pnlSpacer1.TabIndex = 1;
            //
            // pnlDistrict
            //
            pnlDistrict.BackColor = System.Drawing.Color.White;
            pnlDistrict.Controls.Add(this.lvDistrict);
            pnlDistrict.Controls.Add(panel2);
            pnlDistrict.Controls.Add(lblDistrictTitle);
            pnlDistrict.Dock = System.Windows.Forms.DockStyle.Left;
            pnlDistrict.Location = new System.Drawing.Point(444, 12);
            pnlDistrict.Name = "pnlDistrict";
            pnlDistrict.Size = new System.Drawing.Size(424, 628);
            pnlDistrict.TabIndex = 2;
            //
            // pnlSpacer2
            //
            pnlSpacer2.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSpacer2.Location = new System.Drawing.Point(868, 12);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new System.Drawing.Size(8, 628);
            pnlSpacer2.TabIndex = 3;
            //
            // pnlSubDistrict
            //
            pnlSubDistrict.BackColor = System.Drawing.Color.White;
            pnlSubDistrict.Controls.Add(this.lvSubDistrict);
            pnlSubDistrict.Controls.Add(panel3);
            pnlSubDistrict.Controls.Add(lblSubDistrictTitle);
            pnlSubDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSubDistrict.Location = new System.Drawing.Point(876, 12);
            pnlSubDistrict.Name = "pnlSubDistrict";
            pnlSubDistrict.Size = new System.Drawing.Size(456, 628);
            pnlSubDistrict.TabIndex = 4;
            //
            // lblProvinceTitle
            //
            lblProvinceTitle.AutoSize = false;
            lblProvinceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblProvinceTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblProvinceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblProvinceTitle.Location = new System.Drawing.Point(0, 0);
            lblProvinceTitle.Name = "lblProvinceTitle";
            lblProvinceTitle.Size = new System.Drawing.Size(424, 28);
            lblProvinceTitle.TabIndex = 0;
            lblProvinceTitle.Text = "Provinsi";
            lblProvinceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblDistrictTitle
            //
            lblDistrictTitle.AutoSize = false;
            lblDistrictTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblDistrictTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblDistrictTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblDistrictTitle.Location = new System.Drawing.Point(0, 0);
            lblDistrictTitle.Name = "lblDistrictTitle";
            lblDistrictTitle.Size = new System.Drawing.Size(424, 28);
            lblDistrictTitle.TabIndex = 0;
            lblDistrictTitle.Text = "Kabupaten / Kota";
            lblDistrictTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSubDistrictTitle
            //
            lblSubDistrictTitle.AutoSize = false;
            lblSubDistrictTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblSubDistrictTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblSubDistrictTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblSubDistrictTitle.Location = new System.Drawing.Point(0, 0);
            lblSubDistrictTitle.Name = "lblSubDistrictTitle";
            lblSubDistrictTitle.Size = new System.Drawing.Size(456, 28);
            lblSubDistrictTitle.TabIndex = 0;
            lblSubDistrictTitle.Text = "Kecamatan";
            lblSubDistrictTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // panel1 (Province stat)
            //
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            panel1.Controls.Add(this.lblTotalProvince);
            panel1.Controls.Add(lblStatProvinceSubHeader);
            panel1.Controls.Add(lblStatProvinceHeader);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 508);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(424, 120);
            panel1.TabIndex = 2;
            //
            // lblStatProvinceHeader
            //
            lblStatProvinceHeader.BackColor = System.Drawing.Color.Transparent;
            lblStatProvinceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblStatProvinceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblStatProvinceHeader.ForeColor = System.Drawing.Color.White;
            lblStatProvinceHeader.Location = new System.Drawing.Point(0, 0);
            lblStatProvinceHeader.Name = "lblStatProvinceHeader";
            lblStatProvinceHeader.Size = new System.Drawing.Size(424, 20);
            lblStatProvinceHeader.TabIndex = 0;
            lblStatProvinceHeader.Text = "Total Provinsi di";
            lblStatProvinceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblStatProvinceSubHeader
            //
            lblStatProvinceSubHeader.BackColor = System.Drawing.Color.Transparent;
            lblStatProvinceSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblStatProvinceSubHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblStatProvinceSubHeader.ForeColor = System.Drawing.Color.White;
            lblStatProvinceSubHeader.Location = new System.Drawing.Point(0, 20);
            lblStatProvinceSubHeader.Name = "lblStatProvinceSubHeader";
            lblStatProvinceSubHeader.Size = new System.Drawing.Size(424, 20);
            lblStatProvinceSubHeader.TabIndex = 1;
            lblStatProvinceSubHeader.Text = "INDONESIA";
            lblStatProvinceSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblTotalProvince
            //
            this.lblTotalProvince.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalProvince.ForeColor = System.Drawing.Color.White;
            this.lblTotalProvince.Location = new System.Drawing.Point(0, 44);
            this.lblTotalProvince.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalProvince.Name = "lblTotalProvince";
            this.lblTotalProvince.Size = new System.Drawing.Size(424, 72);
            this.lblTotalProvince.TabIndex = 2;
            this.lblTotalProvince.Text = "0";
            this.lblTotalProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // panel2 (District stat)
            //
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            panel2.Controls.Add(this.lblTotalDistrict);
            panel2.Controls.Add(this.lblProvince);
            panel2.Controls.Add(lblStatDistrictHeader);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 508);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(424, 120);
            panel2.TabIndex = 2;
            //
            // lblStatDistrictHeader
            //
            lblStatDistrictHeader.BackColor = System.Drawing.Color.Transparent;
            lblStatDistrictHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblStatDistrictHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblStatDistrictHeader.ForeColor = System.Drawing.Color.White;
            lblStatDistrictHeader.Location = new System.Drawing.Point(0, 0);
            lblStatDistrictHeader.Name = "lblStatDistrictHeader";
            lblStatDistrictHeader.Size = new System.Drawing.Size(424, 20);
            lblStatDistrictHeader.TabIndex = 0;
            lblStatDistrictHeader.Text = "Total Kab./Kota di";
            lblStatDistrictHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblProvince
            //
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblProvince.ForeColor = System.Drawing.Color.White;
            this.lblProvince.Location = new System.Drawing.Point(0, 20);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblProvince.Size = new System.Drawing.Size(424, 24);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "Provinsi";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblTotalDistrict
            //
            this.lblTotalDistrict.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalDistrict.ForeColor = System.Drawing.Color.White;
            this.lblTotalDistrict.Location = new System.Drawing.Point(0, 44);
            this.lblTotalDistrict.Name = "lblTotalDistrict";
            this.lblTotalDistrict.Size = new System.Drawing.Size(424, 72);
            this.lblTotalDistrict.TabIndex = 2;
            this.lblTotalDistrict.Text = "0";
            this.lblTotalDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // panel3 (SubDistrict stat)
            //
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            panel3.Controls.Add(this.lblTotalSubDistrict);
            panel3.Controls.Add(this.lblDistrict);
            panel3.Controls.Add(lblStatSubDistrictHeader);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 508);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(456, 120);
            panel3.TabIndex = 2;
            //
            // lblStatSubDistrictHeader
            //
            lblStatSubDistrictHeader.BackColor = System.Drawing.Color.Transparent;
            lblStatSubDistrictHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblStatSubDistrictHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblStatSubDistrictHeader.ForeColor = System.Drawing.Color.White;
            lblStatSubDistrictHeader.Location = new System.Drawing.Point(0, 0);
            lblStatSubDistrictHeader.Name = "lblStatSubDistrictHeader";
            lblStatSubDistrictHeader.Size = new System.Drawing.Size(456, 20);
            lblStatSubDistrictHeader.TabIndex = 0;
            lblStatSubDistrictHeader.Text = "Total Kecamatan di";
            lblStatSubDistrictHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblDistrict
            //
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDistrict.ForeColor = System.Drawing.Color.White;
            this.lblDistrict.Location = new System.Drawing.Point(0, 20);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblDistrict.Size = new System.Drawing.Size(456, 24);
            this.lblDistrict.TabIndex = 1;
            this.lblDistrict.Text = "Kabupaten";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblTotalSubDistrict
            //
            this.lblTotalSubDistrict.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalSubDistrict.ForeColor = System.Drawing.Color.White;
            this.lblTotalSubDistrict.Location = new System.Drawing.Point(0, 44);
            this.lblTotalSubDistrict.Name = "lblTotalSubDistrict";
            this.lblTotalSubDistrict.Size = new System.Drawing.Size(456, 72);
            this.lblTotalSubDistrict.TabIndex = 2;
            this.lblTotalSubDistrict.Text = "0";
            this.lblTotalSubDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lvProvince
            //
            this.lvProvince.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProvince.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME});
            this.lvProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvProvince.FullRowSelect = true;
            this.lvProvince.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvProvince.HideSelection = false;
            this.lvProvince.Location = new System.Drawing.Point(0, 28);
            this.lvProvince.Name = "lvProvince";
            this.lvProvince.Size = new System.Drawing.Size(424, 480);
            this.lvProvince.TabIndex = 1;
            this.lvProvince.UseCompatibleStateImageBehavior = false;
            this.lvProvince.View = System.Windows.Forms.View.Details;
            this.lvProvince.SelectedIndexChanged += new System.EventHandler(this.lvProvince_SelectedIndexChanged);
            //
            // ID
            //
            this.ID.Text = "ID";
            this.ID.Width = 0;
            //
            // NAME
            //
            this.NAME.Text = "Provinsi";
            this.NAME.Width = 400;
            //
            // lvDistrict
            //
            this.lvDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvDistrict.FullRowSelect = true;
            this.lvDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDistrict.HideSelection = false;
            this.lvDistrict.LabelWrap = false;
            this.lvDistrict.Location = new System.Drawing.Point(0, 28);
            this.lvDistrict.Name = "lvDistrict";
            this.lvDistrict.Size = new System.Drawing.Size(424, 480);
            this.lvDistrict.TabIndex = 1;
            this.lvDistrict.UseCompatibleStateImageBehavior = false;
            this.lvDistrict.View = System.Windows.Forms.View.Details;
            this.lvDistrict.SelectedIndexChanged += new System.EventHandler(this.lvDistrict_SelectedIndexChanged);
            //
            // columnHeader1
            //
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            //
            // columnHeader2
            //
            this.columnHeader2.Text = "Kabupaten / Kota";
            this.columnHeader2.Width = 400;
            //
            // lvSubDistrict
            //
            this.lvSubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSubDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvSubDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSubDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvSubDistrict.FullRowSelect = true;
            this.lvSubDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSubDistrict.HideSelection = false;
            this.lvSubDistrict.Location = new System.Drawing.Point(0, 28);
            this.lvSubDistrict.Name = "lvSubDistrict";
            this.lvSubDistrict.Size = new System.Drawing.Size(456, 480);
            this.lvSubDistrict.TabIndex = 1;
            this.lvSubDistrict.UseCompatibleStateImageBehavior = false;
            this.lvSubDistrict.View = System.Windows.Forms.View.Details;
            //
            // columnHeader3
            //
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 0;
            //
            // columnHeader4
            //
            this.columnHeader4.Text = "Kecamatan";
            this.columnHeader4.Width = 420;
            //
            // FrmLocation
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlActionBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocation";
            this.Text = "DATA KOTA";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            pnlContent.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlProvince.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlDistrict.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlSubDistrict.ResumeLayout(false);
            panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProvince;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ListView lvDistrict;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvSubDistrict;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblTotalProvince;
        private System.Windows.Forms.Label lblTotalDistrict;
        private System.Windows.Forms.Label lblTotalSubDistrict;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblDistrict;
    }
}
