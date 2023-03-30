using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace PrinterServerToolbox
{
    public partial class BulkCreatePrinterForm : Form
    {
        

        public BulkCreatePrinterForm()
        {
            InitializeComponent();
            
            
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPrinterOptions(object sender, EventArgs e)
        {
            List<PrinterDriver> printerDrivers = PrinterProcesser.GetAllPrintDrivers();
            ComboBox combo = new ComboBox();
            foreach(PrinterDriver driver in printerDrivers)
            {
                combo.Items.Add(driver.Name);
            }
            ((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["DriverName"]).DataSource = combo.Items;
        }

        private void TestCreateFirstQueue(object sender, EventArgs e)
        {
            openExcelFileDialog.ShowDialog();
        }

        private void OpenImport(object sender, EventArgs e)
        {
            openExcelFileDialog.ShowDialog();
        }

        private void LoadExcel(object sender, CancelEventArgs e)
        {
            string path = openExcelFileDialog.FileName;
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook ExcelWorkbook = ExcelApp.Workbooks.Open(path, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Worksheet ExcelWorksheet = ExcelWorkbook.ActiveSheet;
            
            int RowCount = ExcelWorksheet.UsedRange.Row;
            int ColumnCount = ExcelWorksheet.UsedRange.Column;

            Range readRange = ExcelWorksheet.UsedRange;
            string test = (readRange.Cells[1, 1] as Range).Value2;
            MessageBox.Show(test);

        }
    }
}
