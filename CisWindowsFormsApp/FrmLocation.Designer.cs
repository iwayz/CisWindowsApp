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
            this.lvProvince = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDistrict = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSubDistrict = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProvince = new System.Windows.Forms.Label();
            this.lblTotalDistrict = new System.Windows.Forms.Label();
            this.lblTotalSubDistrict = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProvince = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProvince
            // 
            this.lvProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProvince.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME});
            this.lvProvince.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lvProvince.FullRowSelect = true;
            this.lvProvince.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvProvince.HideSelection = false;
            this.lvProvince.Location = new System.Drawing.Point(30, 36);
            this.lvProvince.Name = "lvProvince";
            this.lvProvince.Size = new System.Drawing.Size(250, 322);
            this.lvProvince.TabIndex = 1;
            this.lvProvince.UseCompatibleStateImageBehavior = false;
            this.lvProvince.View = System.Windows.Forms.View.Details;
            this.lvProvince.SelectedIndexChanged += new System.EventHandler(this.lvProvince_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NAME
            // 
            this.NAME.Text = "Provinsi";
            this.NAME.Width = 200;
            // 
            // lvDistrict
            // 
            this.lvDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDistrict.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lvDistrict.FullRowSelect = true;
            this.lvDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDistrict.HideSelection = false;
            this.lvDistrict.LabelWrap = false;
            this.lvDistrict.Location = new System.Drawing.Point(327, 36);
            this.lvDistrict.Name = "lvDistrict";
            this.lvDistrict.Size = new System.Drawing.Size(250, 322);
            this.lvDistrict.TabIndex = 2;
            this.lvDistrict.UseCompatibleStateImageBehavior = false;
            this.lvDistrict.View = System.Windows.Forms.View.Details;
            this.lvDistrict.SelectedIndexChanged += new System.EventHandler(this.lvDistrict_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Provinsi";
            this.columnHeader2.Width = 200;
            // 
            // lvSubDistrict
            // 
            this.lvSubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSubDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvSubDistrict.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lvSubDistrict.FullRowSelect = true;
            this.lvSubDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSubDistrict.HideSelection = false;
            this.lvSubDistrict.Location = new System.Drawing.Point(624, 36);
            this.lvSubDistrict.Name = "lvSubDistrict";
            this.lvSubDistrict.Size = new System.Drawing.Size(250, 322);
            this.lvSubDistrict.TabIndex = 3;
            this.lvSubDistrict.UseCompatibleStateImageBehavior = false;
            this.lvSubDistrict.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Provinsi";
            this.columnHeader4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provinsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(324, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kabupaten/ Kota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(621, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kecamatan";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Provinsi di";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProvince
            // 
            this.lblTotalProvince.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalProvince.ForeColor = System.Drawing.Color.White;
            this.lblTotalProvince.Location = new System.Drawing.Point(0, 43);
            this.lblTotalProvince.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalProvince.Name = "lblTotalProvince";
            this.lblTotalProvince.Size = new System.Drawing.Size(249, 72);
            this.lblTotalProvince.TabIndex = 1;
            this.lblTotalProvince.Text = "0";
            this.lblTotalProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalDistrict
            // 
            this.lblTotalDistrict.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalDistrict.ForeColor = System.Drawing.Color.White;
            this.lblTotalDistrict.Location = new System.Drawing.Point(3, 43);
            this.lblTotalDistrict.Name = "lblTotalDistrict";
            this.lblTotalDistrict.Size = new System.Drawing.Size(243, 72);
            this.lblTotalDistrict.TabIndex = 1;
            this.lblTotalDistrict.Text = "0";
            this.lblTotalDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalSubDistrict
            // 
            this.lblTotalSubDistrict.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalSubDistrict.ForeColor = System.Drawing.Color.White;
            this.lblTotalSubDistrict.Location = new System.Drawing.Point(0, 43);
            this.lblTotalSubDistrict.Name = "lblTotalSubDistrict";
            this.lblTotalSubDistrict.Size = new System.Drawing.Size(249, 72);
            this.lblTotalSubDistrict.TabIndex = 1;
            this.lblTotalSubDistrict.Text = "0";
            this.lblTotalSubDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalProvince);
            this.panel1.Location = new System.Drawing.Point(31, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 115);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "INDONESIA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblProvince);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTotalDistrict);
            this.panel2.Location = new System.Drawing.Point(327, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 115);
            this.panel2.TabIndex = 4;
            // 
            // lblProvince
            // 
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProvince.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProvince.ForeColor = System.Drawing.Color.White;
            this.lblProvince.Location = new System.Drawing.Point(0, 16);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblProvince.Size = new System.Drawing.Size(249, 27);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "Provinsi";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Kab./Kota di";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lblDistrict);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblTotalSubDistrict);
            this.panel3.Location = new System.Drawing.Point(625, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 115);
            this.panel3.TabIndex = 4;
            // 
            // lblDistrict
            // 
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDistrict.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDistrict.ForeColor = System.Drawing.Color.White;
            this.lblDistrict.Location = new System.Drawing.Point(0, 16);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblDistrict.Size = new System.Drawing.Size(249, 27);
            this.lblDistrict.TabIndex = 1;
            this.lblDistrict.Text = "Kabupaten";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Kecamatan di";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSubDistrict);
            this.Controls.Add(this.lvDistrict);
            this.Controls.Add(this.lvProvince);
            this.Name = "FrmLocation";
            this.Text = "DATA KOTA";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalProvince;
        private System.Windows.Forms.Label lblTotalDistrict;
        private System.Windows.Forms.Label lblTotalSubDistrict;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}