using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace CisWindowsFormsApp
{
    public partial class FrmInvoiceRecap : Form
    {
        CisDbContext dbContext;
        int gvSelectedIndex = 0;
        UnitOfWork<SalesOrder> uowSo;
        UnitOfWork<SalesOrderItem> uowSoi;

        public FrmInvoiceRecap()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

        private void FrmInvoiceRecap_Load(object sender, EventArgs e)
        {
            uowSo = new UnitOfWork<SalesOrder>(dbContext);
            uowSoi = new UnitOfWork<SalesOrderItem>(dbContext);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var salesOrder = uowSo.Repository.GetAll();
            var salesOrderItem = uowSoi.Repository.GetAll();
            var salesOrderDetail = salesOrderItem
                .Join(salesOrder, soi => soi.SalesOrderId, so => so.Id, (soi, so) => new { soi, so })
                .Select(res => res.so.SalesDate)
                .ToList();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[2, 1] = "1";
            xlWorkSheet.Cells[2, 2] = "One";
            xlWorkSheet.Cells[3, 1] = "2";
            xlWorkSheet.Cells[3, 2] = "Two";


            xlWorkBook.SaveAs("d:\\cis-Excel1.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }
    }
}
