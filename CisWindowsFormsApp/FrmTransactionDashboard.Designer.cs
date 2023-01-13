namespace CisWindowsFormsApp
{
    partial class FrmTransactionDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransactionDashboard));
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnlChildHeader = new System.Windows.Forms.Panel();
            this.lblTransactionChildHeader = new System.Windows.Forms.Label();
            this.pnlTransactionChildren = new System.Windows.Forms.Panel();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlMenuTransaction = new System.Windows.Forms.Panel();
            this.gbMenuTransaction = new System.Windows.Forms.GroupBox();
            this.toolTipTransactionMenu = new System.Windows.Forms.ToolTip(this.components);
            this.pnlChildHeader.SuspendLayout();
            this.pnlMenuTransaction.SuspendLayout();
            this.gbMenuTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonPurchase.FlatAppearance.BorderSize = 0;
            this.buttonPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonPurchase.Image = ((System.Drawing.Image)(resources.GetObject("buttonPurchase.Image")));
            this.buttonPurchase.Location = new System.Drawing.Point(135, 125);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(237, 60);
            this.buttonPurchase.TabIndex = 0;
            this.buttonPurchase.Text = "Pembelian";
            this.buttonPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipTransactionMenu.SetToolTip(this.buttonPurchase, "Transaksi Pembelian - Saat ini belum aktif. Silakan hubungi Admin untuk mengaktif" +
        "kan.");
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(237)))));
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.Location = new System.Drawing.Point(135, 57);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(237, 60);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Penjualan";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipTransactionMenu.SetToolTip(this.btnSales, "Transaksi Penjualan/ Faktur");
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnlChildHeader
            // 
            this.pnlChildHeader.Controls.Add(this.lblTransactionChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1064, 40);
            this.pnlChildHeader.TabIndex = 1;
            // 
            // lblTransactionChildHeader
            // 
            this.lblTransactionChildHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionChildHeader.AutoSize = true;
            this.lblTransactionChildHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTransactionChildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTransactionChildHeader.Location = new System.Drawing.Point(12, 11);
            this.lblTransactionChildHeader.Name = "lblTransactionChildHeader";
            this.lblTransactionChildHeader.Size = new System.Drawing.Size(61, 23);
            this.lblTransactionChildHeader.TabIndex = 0;
            this.lblTransactionChildHeader.Text = "MENU";
            // 
            // pnlTransactionChildren
            // 
            this.pnlTransactionChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactionChildren.Location = new System.Drawing.Point(0, 40);
            this.pnlTransactionChildren.Name = "pnlTransactionChildren";
            this.pnlTransactionChildren.Size = new System.Drawing.Size(1064, 562);
            this.pnlTransactionChildren.TabIndex = 2;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Silver;
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1064, 2);
            this.pnlSeparator.TabIndex = 2;
            // 
            // pnlMenuTransaction
            // 
            this.pnlMenuTransaction.Controls.Add(this.gbMenuTransaction);
            this.pnlMenuTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTransaction.Location = new System.Drawing.Point(0, 42);
            this.pnlMenuTransaction.Name = "pnlMenuTransaction";
            this.pnlMenuTransaction.Size = new System.Drawing.Size(1064, 505);
            this.pnlMenuTransaction.TabIndex = 3;
            // 
            // gbMenuTransaction
            // 
            this.gbMenuTransaction.Controls.Add(this.buttonPurchase);
            this.gbMenuTransaction.Controls.Add(this.btnSales);
            this.gbMenuTransaction.Location = new System.Drawing.Point(258, 94);
            this.gbMenuTransaction.Name = "gbMenuTransaction";
            this.gbMenuTransaction.Size = new System.Drawing.Size(505, 252);
            this.gbMenuTransaction.TabIndex = 0;
            this.gbMenuTransaction.TabStop = false;
            // 
            // FrmTransactionDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.pnlMenuTransaction);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlTransactionChildren);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransactionDashboard";
            this.Text = "TRANSAKSI";
            this.Load += new System.EventHandler(this.FrmTransactionDashboard_Load);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.pnlMenuTransaction.ResumeLayout(false);
            this.gbMenuTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlTransactionChildren;
        private System.Windows.Forms.Label lblTransactionChildHeader;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlMenuTransaction;
        private System.Windows.Forms.GroupBox gbMenuTransaction;
        private System.Windows.Forms.ToolTip toolTipTransactionMenu;
    }
}