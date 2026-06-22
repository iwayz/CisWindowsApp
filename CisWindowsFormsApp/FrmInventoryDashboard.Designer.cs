namespace CisWindowsFormsApp
{
    partial class FrmInventoryDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlChildHeader = new System.Windows.Forms.Panel();
            this.lblInventoryChildHeader = new System.Windows.Forms.Label();
            this.pnlHeaderSeparator = new System.Windows.Forms.Panel();
            this.pnlInventoryChildren = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnStockAdjustment = new System.Windows.Forms.Button();
            this.btnStockTransfer = new System.Windows.Forms.Button();
            this.btnStockOpname = new System.Windows.Forms.Button();
            this.pnlChildHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildHeader
            // 
            this.pnlChildHeader.Controls.Add(this.lblInventoryChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1472, 49);
            this.pnlChildHeader.TabIndex = 0;
            // 
            // lblInventoryChildHeader
            // 
            this.lblInventoryChildHeader.AutoSize = true;
            this.lblInventoryChildHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInventoryChildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblInventoryChildHeader.Location = new System.Drawing.Point(16, 18);
            this.lblInventoryChildHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryChildHeader.Name = "lblInventoryChildHeader";
            this.lblInventoryChildHeader.Size = new System.Drawing.Size(78, 29);
            this.lblInventoryChildHeader.TabIndex = 0;
            this.lblInventoryChildHeader.Text = "MENU";
            // 
            // pnlHeaderSeparator
            // 
            this.pnlHeaderSeparator.BackColor = System.Drawing.Color.Silver;
            this.pnlHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSeparator.Location = new System.Drawing.Point(0, 49);
            this.pnlHeaderSeparator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeaderSeparator.Name = "pnlHeaderSeparator";
            this.pnlHeaderSeparator.Size = new System.Drawing.Size(1472, 2);
            this.pnlHeaderSeparator.TabIndex = 1;
            // 
            // pnlInventoryChildren
            // 
            this.pnlInventoryChildren.AutoScroll = true;
            this.pnlInventoryChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventoryChildren.Location = new System.Drawing.Point(0, 51);
            this.pnlInventoryChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInventoryChildren.Name = "pnlInventoryChildren";
            this.pnlInventoryChildren.Size = new System.Drawing.Size(1472, 636);
            this.pnlInventoryChildren.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.gbMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 51);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1472, 636);
            this.pnlMenu.TabIndex = 3;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnStockAdjustment);
            this.gbMenu.Controls.Add(this.btnStockTransfer);
            this.gbMenu.Controls.Add(this.btnStockOpname);
            this.gbMenu.Location = new System.Drawing.Point(239, 60);
            this.gbMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMenu.Size = new System.Drawing.Size(655, 191);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            // 
            // btnStockAdjustment
            // 
            this.btnStockAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnStockAdjustment.FlatAppearance.BorderSize = 0;
            this.btnStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdjustment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockAdjustment.ForeColor = System.Drawing.Color.White;
            this.btnStockAdjustment.Location = new System.Drawing.Point(59, 64);
            this.btnStockAdjustment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Size = new System.Drawing.Size(172, 74);
            this.btnStockAdjustment.TabIndex = 0;
            this.btnStockAdjustment.Text = "Adj. Stok";
            this.btnStockAdjustment.UseVisualStyleBackColor = false;
            this.btnStockAdjustment.Click += new System.EventHandler(this.btnStockAdjustment_Click);
            // 
            // btnStockTransfer
            // 
            this.btnStockTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStockTransfer.FlatAppearance.BorderSize = 0;
            this.btnStockTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockTransfer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockTransfer.ForeColor = System.Drawing.Color.White;
            this.btnStockTransfer.Location = new System.Drawing.Point(241, 64);
            this.btnStockTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockTransfer.Name = "btnStockTransfer";
            this.btnStockTransfer.Size = new System.Drawing.Size(172, 74);
            this.btnStockTransfer.TabIndex = 1;
            this.btnStockTransfer.Text = "Transfer Stok";
            this.btnStockTransfer.UseVisualStyleBackColor = false;
            this.btnStockTransfer.Click += new System.EventHandler(this.btnStockTransfer_Click);
            // 
            // btnStockOpname
            // 
            this.btnStockOpname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnStockOpname.FlatAppearance.BorderSize = 0;
            this.btnStockOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOpname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockOpname.ForeColor = System.Drawing.Color.White;
            this.btnStockOpname.Location = new System.Drawing.Point(424, 64);
            this.btnStockOpname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockOpname.Name = "btnStockOpname";
            this.btnStockOpname.Size = new System.Drawing.Size(172, 74);
            this.btnStockOpname.TabIndex = 2;
            this.btnStockOpname.Text = "Stock Opname";
            this.btnStockOpname.UseVisualStyleBackColor = false;
            this.btnStockOpname.Click += new System.EventHandler(this.btnStockOpname_Click);
            // 
            // FrmInventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 687);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInventoryChildren);
            this.Controls.Add(this.pnlHeaderSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInventoryDashboard";
            this.Text = "INVENTORY";
            this.Load += new System.EventHandler(this.FrmInventoryDashboard_Load);
            this.Resize += new System.EventHandler(this.FrmInventoryDashboard_Resize);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Label lblInventoryChildHeader;
        private System.Windows.Forms.Panel pnlHeaderSeparator;
        private System.Windows.Forms.Panel pnlInventoryChildren;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnStockTransfer;
        private System.Windows.Forms.Button btnStockOpname;
    }
}
