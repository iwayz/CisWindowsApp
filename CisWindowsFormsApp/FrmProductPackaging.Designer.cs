namespace CisWindowsFormsApp
{
    partial class FrmProductPackaging
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBaseUnit = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtConversionQty = new System.Windows.Forms.TextBox();
            this.lblBaseHint = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.dgvPackaging = new System.Windows.Forms.DataGridView();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPackaging)).BeginInit();
            this.SuspendLayout();

            // lblProductName
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblProductName.Location = new System.Drawing.Point(12, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Text = "Nama Produk";

            // lblBaseUnit
            this.lblBaseUnit.AutoSize = true;
            this.lblBaseUnit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBaseUnit.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.lblBaseUnit.Location = new System.Drawing.Point(12, 36);
            this.lblBaseUnit.Name = "lblBaseUnit";
            this.lblBaseUnit.Text = "Satuan dasar: ";

            // lblAddTitle
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblAddTitle.Location = new System.Drawing.Point(12, 68);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Text = "Tambah Kemasan";

            // cbUnit
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUnit.Location = new System.Drawing.Point(12, 90);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(120, 23);
            this.cbUnit.TabIndex = 0;

            // lblEquals
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEquals.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblEquals.Location = new System.Drawing.Point(140, 94);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Text = "=";

            // txtConversionQty
            this.txtConversionQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConversionQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConversionQty.Location = new System.Drawing.Point(160, 90);
            this.txtConversionQty.Name = "txtConversionQty";
            this.txtConversionQty.Size = new System.Drawing.Size(80, 23);
            this.txtConversionQty.TabIndex = 1;
            this.txtConversionQty.Text = "0";
            this.txtConversionQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblBaseHint
            this.lblBaseHint.AutoSize = true;
            this.lblBaseHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBaseHint.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblBaseHint.Location = new System.Drawing.Point(246, 94);
            this.lblBaseHint.Name = "lblBaseHint";
            this.lblBaseHint.Text = "satuan dasar";

            // btnAddRow
            this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRow.ForeColor = System.Drawing.Color.White;
            this.btnAddRow.Location = new System.Drawing.Point(400, 89);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(100, 26);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "+ Tambah";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);

            // dgvPackaging
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvPackaging.AllowUserToAddRows = false;
            this.dgvPackaging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPackaging.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvPackaging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackaging.DefaultCellStyle = dgvDefaultStyle;
            this.dgvPackaging.Location = new System.Drawing.Point(12, 128);
            this.dgvPackaging.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvPackaging.Name = "dgvPackaging";
            this.dgvPackaging.ReadOnly = true;
            this.dgvPackaging.RowHeadersVisible = false;
            this.dgvPackaging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackaging.Size = new System.Drawing.Size(488, 220);
            this.dgvPackaging.TabIndex = 3;

            // btnDeleteRow
            this.btnDeleteRow.BackColor = System.Drawing.Color.White;
            this.btnDeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRow.ForeColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDeleteRow.Location = new System.Drawing.Point(12, 360);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteRow.TabIndex = 4;
            this.btnDeleteRow.Text = "Hapus Terpilih";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(380, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Tutup";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // FrmProductPackaging
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 402);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBaseUnit);
            this.Controls.Add(this.lblAddTitle);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.txtConversionQty);
            this.Controls.Add(this.lblBaseHint);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.dgvPackaging);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductPackaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konversi Kemasan Produk";
            this.Load += new System.EventHandler(this.FrmProductPackaging_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPackaging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBaseUnit;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtConversionQty;
        private System.Windows.Forms.Label lblBaseHint;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.DataGridView dgvPackaging;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnClose;
    }
}
