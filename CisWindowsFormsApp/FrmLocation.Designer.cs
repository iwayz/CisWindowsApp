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
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.NAME = new System.Windows.Forms.ColumnHeader();
            this.lvDistrict = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvSubDistrict = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProvince = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalDistrict = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSubDistrict = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvProvince
            // 
            this.lvProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProvince.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME});
            this.lvProvince.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvProvince.FullRowSelect = true;
            this.lvProvince.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvProvince.HideSelection = false;
            this.lvProvince.Location = new System.Drawing.Point(71, 71);
            this.lvProvince.Name = "lvProvince";
            this.lvProvince.Size = new System.Drawing.Size(222, 511);
            this.lvProvince.TabIndex = 0;
            this.lvProvince.UseCompatibleStateImageBehavior = false;
            this.lvProvince.View = System.Windows.Forms.View.Details;
            this.lvProvince.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProvince_MouseClick);
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
            this.lvDistrict.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvDistrict.FullRowSelect = true;
            this.lvDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDistrict.HideSelection = false;
            this.lvDistrict.Location = new System.Drawing.Point(340, 71);
            this.lvDistrict.Name = "lvDistrict";
            this.lvDistrict.Size = new System.Drawing.Size(222, 511);
            this.lvDistrict.TabIndex = 0;
            this.lvDistrict.UseCompatibleStateImageBehavior = false;
            this.lvDistrict.View = System.Windows.Forms.View.Details;
            this.lvDistrict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvDistrict_MouseClick);
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
            this.lvSubDistrict.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvSubDistrict.FullRowSelect = true;
            this.lvSubDistrict.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSubDistrict.HideSelection = false;
            this.lvSubDistrict.Location = new System.Drawing.Point(609, 71);
            this.lvSubDistrict.Name = "lvSubDistrict";
            this.lvSubDistrict.Size = new System.Drawing.Size(222, 511);
            this.lvSubDistrict.TabIndex = 0;
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
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provinsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(340, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kabupaten/ Kota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(609, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kecamatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(156, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // lblTotalProvince
            // 
            this.lblTotalProvince.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTotalProvince.Location = new System.Drawing.Point(209, 585);
            this.lblTotalProvince.Name = "lblTotalProvince";
            this.lblTotalProvince.Size = new System.Drawing.Size(84, 60);
            this.lblTotalProvince.TabIndex = 1;
            this.lblTotalProvince.Text = "0";
            this.lblTotalProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(425, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total:";
            // 
            // lblTotalDistrict
            // 
            this.lblTotalDistrict.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTotalDistrict.Location = new System.Drawing.Point(478, 585);
            this.lblTotalDistrict.Name = "lblTotalDistrict";
            this.lblTotalDistrict.Size = new System.Drawing.Size(84, 60);
            this.lblTotalDistrict.TabIndex = 1;
            this.lblTotalDistrict.Text = "0";
            this.lblTotalDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.label8.Location = new System.Drawing.Point(694, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total:";
            // 
            // lblTotalSubDistrict
            // 
            this.lblTotalSubDistrict.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSubDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTotalSubDistrict.Location = new System.Drawing.Point(747, 585);
            this.lblTotalSubDistrict.Name = "lblTotalSubDistrict";
            this.lblTotalSubDistrict.Size = new System.Drawing.Size(84, 60);
            this.lblTotalSubDistrict.TabIndex = 1;
            this.lblTotalSubDistrict.Text = "0";
            this.lblTotalSubDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalSubDistrict);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalDistrict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalProvince);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSubDistrict);
            this.Controls.Add(this.lvDistrict);
            this.Controls.Add(this.lvProvince);
            this.Name = "FrmLocation";
            this.Text = "Data Kota";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalDistrict;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSubDistrict;
    }
}