namespace CisWindowsFormsApp
{
    partial class FrmStockMutation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvMutation = new System.Windows.Forms.DataGridView();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutation)).BeginInit();
            this.SuspendLayout();
            //
            // pnlToolbar
            //
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlToolbar.Controls.Add(this.lblDateFrom);
            this.pnlToolbar.Controls.Add(this.dtpDateFrom);
            this.pnlToolbar.Controls.Add(this.lblDateTo);
            this.pnlToolbar.Controls.Add(this.dtpDateTo);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.lblTotal);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1467, 91);
            this.pnlToolbar.TabIndex = 1;
            //
            // lblDateFrom
            //
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDateFrom.Location = new System.Drawing.Point(13, 15);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Dari Tgl:";
            //
            // dtpDateFrom
            //
            this.dtpDateFrom.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(96, 10);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(145, 22);
            this.dtpDateFrom.TabIndex = 1;
            //
            // lblDateTo
            //
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDateTo.Location = new System.Drawing.Point(256, 15);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "s/d:";
            //
            // dtpDateTo
            //
            this.dtpDateTo.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(291, 10);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(145, 22);
            this.dtpDateTo.TabIndex = 3;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblSearch.Location = new System.Drawing.Point(13, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Cari Barang:";
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSearch.Location = new System.Drawing.Point(117, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 24);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(403, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 32);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnPrint
            //
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(523, 47);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 32);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTotal.Location = new System.Drawing.Point(653, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 10;
            //
            // dgvMutation
            //
            this.dgvMutation.AllowUserToAddRows = false;
            this.dgvMutation.AllowUserToDeleteRows = false;
            this.dgvMutation.BackgroundColor = System.Drawing.Color.White;
            this.dgvMutation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMutation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMutation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMutation.Name = "dgvMutation";
            this.dgvMutation.ReadOnly = true;
            this.dgvMutation.RowHeadersWidth = 25;
            this.dgvMutation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMutation.TabIndex = 2;
            //
            // FrmStockMutation
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 837);
            this.Controls.Add(this.dgvMutation);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "FrmStockMutation";
            this.Text = "MUTASI STOK PER BARANG";
            this.Load += new System.EventHandler(this.FrmStockMutation_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutation)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvMutation;
    }
}
