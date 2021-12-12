namespace CisWindowsFormsApp
{
    partial class FrmRptInvoiceViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptInvoiceViewer));
            this.reportViewerInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSourceInvoice = new CisWindowsFormsApp.DataSources.DataSourceInvoice();
            this.dataTableInvoiceTableAdapter = new CisWindowsFormsApp.DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerInvoice
            // 
            this.reportViewerInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerInvoice.LocalReport.ReportEmbeddedResource = "CisWindowsFormsApp.Reports.RptInvoiceV2.rdlc";
            this.reportViewerInvoice.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInvoice.Name = "reportViewerInvoice";
            this.reportViewerInvoice.ServerReport.BearerToken = null;
            this.reportViewerInvoice.Size = new System.Drawing.Size(800, 450);
            this.reportViewerInvoice.TabIndex = 0;
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
            // FrmRptInvoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRptInvoiceViewer";
            this.Text = "Cetak Faktur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRptInvoiceViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInvoice;
        private DataSources.DataSourceInvoice dataSourceInvoice;
        private DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter dataTableInvoiceTableAdapter;
    }
}