namespace CisWindowsFormsApp
{
    partial class FrmStockCard
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkHideZero = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 50);
            this.pnlTop.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STOCK CARD";
            //
            // pnlToolbar
            //
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.chkHideZero);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.lblTotal);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 50);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 46);
            this.pnlToolbar.TabIndex = 1;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblSearch.Location = new System.Drawing.Point(10, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Cari Barang:";
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSearch.Location = new System.Drawing.Point(88, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            //
            // chkHideZero
            //
            this.chkHideZero.AutoSize = true;
            this.chkHideZero.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkHideZero.Location = new System.Drawing.Point(322, 14);
            this.chkHideZero.Name = "chkHideZero";
            this.chkHideZero.Size = new System.Drawing.Size(120, 18);
            this.chkHideZero.TabIndex = 2;
            this.chkHideZero.Text = "Sembunyikan Stok 0";
            this.chkHideZero.UseVisualStyleBackColor = true;
            this.chkHideZero.CheckedChanged += new System.EventHandler(this.chkHideZero_CheckedChanged);
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(460, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 26);
            this.btnRefresh.TabIndex = 3;
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
            this.btnPrint.Location = new System.Drawing.Point(550, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 26);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTotal.Location = new System.Drawing.Point(648, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "";
            //
            // dgvStock
            //
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNo,
                this.colProductCode,
                this.colProductName,
                this.colBatchCode,
                this.colExpDate,
                this.colUomCode,
                this.colQtyOnHand,
                this.colQtyReserved,
                this.colQtyAvailable });
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 96);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 25;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.TabIndex = 2;
            //
            // colNo
            //
            this.colNo.FillWeight = 35F;
            this.colNo.HeaderText = "#";
            this.colNo.Name = "colNo";
            //
            // colProductCode
            //
            this.colProductCode.FillWeight = 80F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            //
            // colProductName
            //
            this.colProductName.FillWeight = 220F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            //
            // colBatchCode
            //
            this.colBatchCode.FillWeight = 80F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            //
            // colExpDate
            //
            this.colExpDate.FillWeight = 80F;
            this.colExpDate.HeaderText = "Exp. Date";
            this.colExpDate.Name = "colExpDate";
            //
            // colUomCode
            //
            this.colUomCode.FillWeight = 55F;
            this.colUomCode.HeaderText = "Satuan";
            this.colUomCode.Name = "colUomCode";
            //
            // colQtyOnHand
            //
            this.colQtyOnHand.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyOnHand.FillWeight = 80F;
            this.colQtyOnHand.HeaderText = "Qty On Hand";
            this.colQtyOnHand.Name = "colQtyOnHand";
            //
            // colQtyReserved
            //
            this.colQtyReserved.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyReserved.FillWeight = 80F;
            this.colQtyReserved.HeaderText = "Qty Reserved";
            this.colQtyReserved.Name = "colQtyReserved";
            //
            // colQtyAvailable
            //
            this.colQtyAvailable.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyAvailable.FillWeight = 80F;
            this.colQtyAvailable.HeaderText = "Qty Available";
            this.colQtyAvailable.Name = "colQtyAvailable";
            //
            // FrmStockCard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmStockCard";
            this.Text = "STOCK CARD";
            this.Load += new System.EventHandler(this.FrmStockCard_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkHideZero;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyAvailable;
    }
}
