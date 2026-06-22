namespace CisWindowsFormsApp
{
    partial class FrmStockMovement
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
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cbMovementType = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvMovement = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovement)).BeginInit();
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
            this.lblTitle.Text = "STOCK MOVEMENT";
            //
            // pnlToolbar
            //
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlToolbar.Controls.Add(this.lblDateFrom);
            this.pnlToolbar.Controls.Add(this.dtpDateFrom);
            this.pnlToolbar.Controls.Add(this.lblDateTo);
            this.pnlToolbar.Controls.Add(this.dtpDateTo);
            this.pnlToolbar.Controls.Add(this.lblType);
            this.pnlToolbar.Controls.Add(this.cbMovementType);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.lblTotal);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 50);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 74);
            this.pnlToolbar.TabIndex = 1;
            //
            // lblDateFrom
            //
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDateFrom.Location = new System.Drawing.Point(10, 12);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Dari Tgl:";
            //
            // dtpDateFrom
            //
            this.dtpDateFrom.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(72, 8);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(110, 21);
            this.dtpDateFrom.TabIndex = 1;
            //
            // lblDateTo
            //
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDateTo.Location = new System.Drawing.Point(192, 12);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "s/d:";
            //
            // dtpDateTo
            //
            this.dtpDateTo.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(218, 8);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(110, 21);
            this.dtpDateTo.TabIndex = 3;
            //
            // lblType
            //
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblType.Location = new System.Drawing.Point(340, 12);
            this.lblType.Name = "lblType";
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipe:";
            //
            // cbMovementType
            //
            this.cbMovementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovementType.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbMovementType.Location = new System.Drawing.Point(372, 8);
            this.cbMovementType.Name = "cbMovementType";
            this.cbMovementType.Size = new System.Drawing.Size(160, 22);
            this.cbMovementType.TabIndex = 5;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblSearch.Location = new System.Drawing.Point(10, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Cari Barang:";
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSearch.Location = new System.Drawing.Point(88, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
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
            this.btnRefresh.Location = new System.Drawing.Point(302, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 26);
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
            this.btnPrint.Location = new System.Drawing.Point(392, 38);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 26);
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
            this.lblTotal.Location = new System.Drawing.Point(490, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "";
            //
            // dgvMovement
            //
            this.dgvMovement.AllowUserToAddRows = false;
            this.dgvMovement.AllowUserToDeleteRows = false;
            this.dgvMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovement.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNo,
                this.colDate,
                this.colType,
                this.colProductCode,
                this.colProductName,
                this.colBatchCode,
                this.colRemarks,
                this.colQtyIn,
                this.colQtyOut });
            this.dgvMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovement.Location = new System.Drawing.Point(0, 124);
            this.dgvMovement.Name = "dgvMovement";
            this.dgvMovement.ReadOnly = true;
            this.dgvMovement.RowHeadersWidth = 25;
            this.dgvMovement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovement.TabIndex = 2;
            //
            // colNo
            //
            this.colNo.FillWeight = 35F;
            this.colNo.HeaderText = "#";
            this.colNo.Name = "colNo";
            //
            // colDate
            //
            this.colDate.FillWeight = 70F;
            this.colDate.HeaderText = "Tanggal";
            this.colDate.Name = "colDate";
            //
            // colType
            //
            this.colType.FillWeight = 110F;
            this.colType.HeaderText = "Tipe Gerakan";
            this.colType.Name = "colType";
            //
            // colProductCode
            //
            this.colProductCode.FillWeight = 80F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            //
            // colProductName
            //
            this.colProductName.FillWeight = 200F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            //
            // colBatchCode
            //
            this.colBatchCode.FillWeight = 70F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            //
            // colRemarks
            //
            this.colRemarks.FillWeight = 150F;
            this.colRemarks.HeaderText = "Keterangan";
            this.colRemarks.Name = "colRemarks";
            //
            // colQtyIn
            //
            this.colQtyIn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyIn.FillWeight = 70F;
            this.colQtyIn.HeaderText = "Qty In";
            this.colQtyIn.Name = "colQtyIn";
            //
            // colQtyOut
            //
            this.colQtyOut.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyOut.FillWeight = 70F;
            this.colQtyOut.HeaderText = "Qty Out";
            this.colQtyOut.Name = "colQtyOut";
            //
            // FrmStockMovement
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.dgvMovement);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmStockMovement";
            this.Text = "STOCK MOVEMENT";
            this.Load += new System.EventHandler(this.FrmStockMovement_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovement)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbMovementType;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyOut;
    }
}
