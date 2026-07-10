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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackaging)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblProductName.Location = new System.Drawing.Point(16, 15);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 19);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Nama Produk";
            // 
            // lblBaseUnit
            // 
            this.lblBaseUnit.AutoSize = true;
            this.lblBaseUnit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBaseUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblBaseUnit.Location = new System.Drawing.Point(16, 44);
            this.lblBaseUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseUnit.Name = "lblBaseUnit";
            this.lblBaseUnit.Size = new System.Drawing.Size(80, 15);
            this.lblBaseUnit.TabIndex = 1;
            this.lblBaseUnit.Text = "Satuan dasar: ";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblAddTitle.Location = new System.Drawing.Point(16, 84);
            this.lblAddTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(103, 15);
            this.lblAddTitle.TabIndex = 2;
            this.lblAddTitle.Text = "Tambah Kemasan";
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUnit.Location = new System.Drawing.Point(16, 111);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(159, 23);
            this.cbUnit.TabIndex = 0;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEquals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblEquals.Location = new System.Drawing.Point(187, 116);
            this.lblEquals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(15, 15);
            this.lblEquals.TabIndex = 3;
            this.lblEquals.Text = "=";
            // 
            // txtConversionQty
            // 
            this.txtConversionQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConversionQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConversionQty.Location = new System.Drawing.Point(213, 111);
            this.txtConversionQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConversionQty.Name = "txtConversionQty";
            this.txtConversionQty.Size = new System.Drawing.Size(106, 23);
            this.txtConversionQty.TabIndex = 1;
            this.txtConversionQty.Text = "0";
            this.txtConversionQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaseHint
            // 
            this.lblBaseHint.AutoSize = true;
            this.lblBaseHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBaseHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblBaseHint.Location = new System.Drawing.Point(328, 116);
            this.lblBaseHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseHint.Name = "lblBaseHint";
            this.lblBaseHint.Size = new System.Drawing.Size(73, 15);
            this.lblBaseHint.TabIndex = 4;
            this.lblBaseHint.Text = "satuan dasar";
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRow.ForeColor = System.Drawing.Color.White;
            this.btnAddRow.Location = new System.Drawing.Point(421, 105);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(118, 37);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "+ Tambah";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // dgvPackaging
            // 
            this.dgvPackaging.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvPackaging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPackaging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackaging.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPackaging.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPackaging.Location = new System.Drawing.Point(16, 158);
            this.dgvPackaging.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPackaging.Name = "dgvPackaging";
            this.dgvPackaging.ReadOnly = true;
            this.dgvPackaging.RowHeadersVisible = false;
            this.dgvPackaging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackaging.Size = new System.Drawing.Size(651, 271);
            this.dgvPackaging.TabIndex = 3;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.White;
            this.btnDeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnDeleteRow.Location = new System.Drawing.Point(547, 105);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(118, 37);
            this.btnDeleteRow.TabIndex = 4;
            this.btnDeleteRow.Text = "Hapus Terpilih";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // FrmProductPackaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 448);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}
