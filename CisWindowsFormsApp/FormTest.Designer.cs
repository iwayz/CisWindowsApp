namespace CisWindowsFormsApp
{
    partial class FormTest
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
            this.dataSourceInvoice = new CisWindowsFormsApp.DataSources.DataSourceInvoice();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableInvoiceTableAdapter = new CisWindowsFormsApp.DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionChildHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSourceInvoice
            // 
            this.dataSourceInvoice.DataSetName = "DataSourceInvoice";
            this.dataSourceInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableInvoiceTableAdapter
            // 
            this.dataTableInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 52);
            this.panel1.TabIndex = 0;
            // 
            // lblTransactionChildHeader
            // 
            this.lblTransactionChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransactionChildHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTransactionChildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTransactionChildHeader.Location = new System.Drawing.Point(0, 52);
            this.lblTransactionChildHeader.Name = "lblTransactionChildHeader";
            this.lblTransactionChildHeader.Size = new System.Drawing.Size(768, 23);
            this.lblTransactionChildHeader.TabIndex = 1;
            this.lblTransactionChildHeader.Text = "Fitur belum tersedia.";
            this.lblTransactionChildHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 489);
            this.Controls.Add(this.lblTransactionChildHeader);
            this.Controls.Add(this.panel1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSources.DataSourceInvoice dataSourceInvoice;
        private System.Windows.Forms.BindingSource bindingSource;
        private DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter dataTableInvoiceTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTransactionChildHeader;
    }
}