namespace CisWindowsFormsApp
{
    partial class FrmReportingDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportingDashboard));
            this.btnExportPelanggan = new System.Windows.Forms.Button();
            this.btnExportProduct = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.pnlChildHeader = new System.Windows.Forms.Panel();
            this.lblReportingChildHeader = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlMenuReporting = new System.Windows.Forms.Panel();
            this.gbMenuReporting = new System.Windows.Forms.GroupBox();
            this.pnlChildHeader.SuspendLayout();
            this.pnlMenuReporting.SuspendLayout();
            this.gbMenuReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportPelanggan
            // 
            this.btnExportPelanggan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExportPelanggan.FlatAppearance.BorderSize = 0;
            this.btnExportPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnExportPelanggan.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPelanggan.Image")));
            this.btnExportPelanggan.Location = new System.Drawing.Point(133, 169);
            this.btnExportPelanggan.Name = "btnExportPelanggan";
            this.btnExportPelanggan.Size = new System.Drawing.Size(237, 60);
            this.btnExportPelanggan.TabIndex = 2;
            this.btnExportPelanggan.Text = " Exp. Pelanggan";
            this.btnExportPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportPelanggan.UseVisualStyleBackColor = false;
            this.btnExportPelanggan.Click += new System.EventHandler(this.btnExportPelanggan_Click);
            // 
            // btnExportProduct
            // 
            this.btnExportProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(143)))));
            this.btnExportProduct.FlatAppearance.BorderSize = 0;
            this.btnExportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportProduct.ForeColor = System.Drawing.Color.White;
            this.btnExportProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnExportProduct.Image")));
            this.btnExportProduct.Location = new System.Drawing.Point(133, 103);
            this.btnExportProduct.Name = "btnExportProduct";
            this.btnExportProduct.Size = new System.Drawing.Size(237, 60);
            this.btnExportProduct.TabIndex = 1;
            this.btnExportProduct.Text = " Exp. Produk";
            this.btnExportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportProduct.UseVisualStyleBackColor = false;
            this.btnExportProduct.Click += new System.EventHandler(this.btnExportProduct_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(133, 37);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(237, 60);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = " Exp. Faktur";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // pnlChildHeader
            // 
            this.pnlChildHeader.Controls.Add(this.lblReportingChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1002, 40);
            this.pnlChildHeader.TabIndex = 1;
            // 
            // lblReportingChildHeader
            // 
            this.lblReportingChildHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReportingChildHeader.AutoSize = true;
            this.lblReportingChildHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblReportingChildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblReportingChildHeader.Location = new System.Drawing.Point(12, 9);
            this.lblReportingChildHeader.Name = "lblReportingChildHeader";
            this.lblReportingChildHeader.Size = new System.Drawing.Size(61, 23);
            this.lblReportingChildHeader.TabIndex = 0;
            this.lblReportingChildHeader.Text = "MENU";
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Silver;
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1002, 2);
            this.pnlSeparator.TabIndex = 2;
            // 
            // pnlMenuReporting
            // 
            this.pnlMenuReporting.Controls.Add(this.gbMenuReporting);
            this.pnlMenuReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuReporting.Location = new System.Drawing.Point(0, 42);
            this.pnlMenuReporting.Name = "pnlMenuReporting";
            this.pnlMenuReporting.Size = new System.Drawing.Size(1002, 637);
            this.pnlMenuReporting.TabIndex = 3;
            // 
            // gbMenuReporting
            // 
            this.gbMenuReporting.Controls.Add(this.btnExportPelanggan);
            this.gbMenuReporting.Controls.Add(this.btnExportProduct);
            this.gbMenuReporting.Controls.Add(this.btnExportExcel);
            this.gbMenuReporting.Location = new System.Drawing.Point(183, 92);
            this.gbMenuReporting.Name = "gbMenuReporting";
            this.gbMenuReporting.Size = new System.Drawing.Size(506, 266);
            this.gbMenuReporting.TabIndex = 0;
            this.gbMenuReporting.TabStop = false;
            // 
            // FrmReportingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 679);
            this.Controls.Add(this.pnlMenuReporting);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportingDashboard";
            this.Text = "REPORTING";
            this.Load += new System.EventHandler(this.FrmReportingDashboard_Load);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.pnlMenuReporting.ResumeLayout(false);
            this.gbMenuReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblReportingChildHeader;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel pnlMenuReporting;
        private System.Windows.Forms.Button btnExportPelanggan;
        private System.Windows.Forms.Button btnExportProduct;
        private System.Windows.Forms.GroupBox gbMenuReporting;
    }
}