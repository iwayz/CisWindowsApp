﻿namespace CisWindowsFormsApp
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSourceInvoice = new CisWindowsFormsApp.DataSources.DataSourceInvoice();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableInvoiceTableAdapter = new CisWindowsFormsApp.DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CisWindowsFormsApp.Reports.RptInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(768, 489);
            this.reportViewer1.TabIndex = 0;
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
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSources.DataSourceInvoice dataSourceInvoice;
        private System.Windows.Forms.BindingSource bindingSource;
        private DataSources.DataSourceInvoiceTableAdapters.DataTableInvoiceTableAdapter dataTableInvoiceTableAdapter;
    }
}