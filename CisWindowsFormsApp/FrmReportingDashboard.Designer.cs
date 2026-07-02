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
            this.btnStockCard = new System.Windows.Forms.Button();
            this.btnStockMovement = new System.Windows.Forms.Button();
            this.pnlChildHeader = new System.Windows.Forms.Panel();
            this.lblReportingChildHeader = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlReportingChildren = new System.Windows.Forms.Panel();
            this.pnlMenuReporting = new System.Windows.Forms.Panel();
            this.gbMenuReporting = new System.Windows.Forms.GroupBox();
            this.pnlChildHeader.SuspendLayout();
            this.pnlMenuReporting.SuspendLayout();
            this.gbMenuReporting.SuspendLayout();
            this.SuspendLayout();
            //
            // btnStockCard  (row 1, col 1)
            //
            this.btnStockCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnStockCard.FlatAppearance.BorderSize = 0;
            this.btnStockCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockCard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockCard.ForeColor = System.Drawing.Color.White;
            this.btnStockCard.Location = new System.Drawing.Point(114, 36);
            this.btnStockCard.Name = "btnStockCard";
            this.btnStockCard.Size = new System.Drawing.Size(172, 74);
            this.btnStockCard.TabIndex = 0;
            this.btnStockCard.Text = "Stock Card";
            this.btnStockCard.UseVisualStyleBackColor = false;
            this.btnStockCard.Click += new System.EventHandler(this.btnStockCard_Click);
            //
            // btnStockMovement  (row 1, col 2)
            //
            this.btnStockMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnStockMovement.FlatAppearance.BorderSize = 0;
            this.btnStockMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockMovement.ForeColor = System.Drawing.Color.White;
            this.btnStockMovement.Location = new System.Drawing.Point(302, 36);
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Size = new System.Drawing.Size(172, 74);
            this.btnStockMovement.TabIndex = 1;
            this.btnStockMovement.Text = "Stock Movement";
            this.btnStockMovement.UseVisualStyleBackColor = false;
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);
            //
            // btnExportExcel  (row 2, col 1)
            //
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(20, 126);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(172, 74);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "Export Faktur";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            //
            // btnExportProduct  (row 2, col 2)
            //
            this.btnExportProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExportProduct.FlatAppearance.BorderSize = 0;
            this.btnExportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportProduct.ForeColor = System.Drawing.Color.White;
            this.btnExportProduct.Location = new System.Drawing.Point(208, 126);
            this.btnExportProduct.Name = "btnExportProduct";
            this.btnExportProduct.Size = new System.Drawing.Size(172, 74);
            this.btnExportProduct.TabIndex = 3;
            this.btnExportProduct.Text = "Export Produk";
            this.btnExportProduct.UseVisualStyleBackColor = false;
            this.btnExportProduct.Click += new System.EventHandler(this.btnExportProduct_Click);
            //
            // btnExportPelanggan  (row 2, col 3)
            //
            this.btnExportPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnExportPelanggan.FlatAppearance.BorderSize = 0;
            this.btnExportPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnExportPelanggan.Location = new System.Drawing.Point(396, 126);
            this.btnExportPelanggan.Name = "btnExportPelanggan";
            this.btnExportPelanggan.Size = new System.Drawing.Size(172, 74);
            this.btnExportPelanggan.TabIndex = 4;
            this.btnExportPelanggan.Text = "Export Pelanggan";
            this.btnExportPelanggan.UseVisualStyleBackColor = false;
            this.btnExportPelanggan.Click += new System.EventHandler(this.btnExportPelanggan_Click);
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
            // pnlReportingChildren
            //
            this.pnlReportingChildren.AutoScroll = true;
            this.pnlReportingChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportingChildren.Location = new System.Drawing.Point(0, 42);
            this.pnlReportingChildren.Name = "pnlReportingChildren";
            this.pnlReportingChildren.Size = new System.Drawing.Size(1002, 637);
            this.pnlReportingChildren.TabIndex = 4;
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
            this.gbMenuReporting.Controls.Add(this.btnStockCard);
            this.gbMenuReporting.Controls.Add(this.btnStockMovement);
            this.gbMenuReporting.Location = new System.Drawing.Point(183, 92);
            this.gbMenuReporting.Name = "gbMenuReporting";
            this.gbMenuReporting.Size = new System.Drawing.Size(588, 230);
            this.gbMenuReporting.TabIndex = 0;
            this.gbMenuReporting.TabStop = false;
            // 
            // FrmReportingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 679);
            this.Controls.Add(this.pnlMenuReporting);
            this.Controls.Add(this.pnlReportingChildren);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportingDashboard";
            this.Text = "REPORTING";
            this.Load += new System.EventHandler(this.FrmReportingDashboard_Load);
            this.Resize += new System.EventHandler(this.FrmReportingDashboard_Resize);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.pnlMenuReporting.ResumeLayout(false);
            this.gbMenuReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlReportingChildren;
        private System.Windows.Forms.Label lblReportingChildHeader;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel pnlMenuReporting;
        private System.Windows.Forms.Button btnExportPelanggan;
        private System.Windows.Forms.Button btnExportProduct;
        private System.Windows.Forms.Button btnStockCard;
        private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.GroupBox gbMenuReporting;
    }
}