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
            //List<PrinterDriver> printerDrivers = PrinterProcesser.GetAllPrintDrivers();
            //ComboBox combo = new ComboBox();
            //foreach(PrinterDriver driver in printerDrivers)
            //{
            //    combo.Items.Add(driver);
            //}
            //((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["DriverName"]).DataSource = combo.Items;
            //((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["Drivername"]).DataPropertyName = "Name";
            //((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["Drivername"]).ValueType = typeof(PrinterDriver);

            List<PrinterDriver> printerDrivers = PrinterProcesser.GetAllPrintDrivers();
            DataGridViewComboBoxColumn myColumn = ((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["Drivername"]);
            myColumn.DataSource = printerDrivers;
            myColumn.DataPropertyName = "Name";
        }

        private void TestCreateFirstQueue(object sender, EventArgs e)
        {
            
            PrinterOB WIPPrinter;
            Queue<PrinterOB> PrintersQueue = new Queue<PrinterOB>();

            foreach(DataGridViewRow row in DataGridView_PrinterCreation.Rows)
            {
                WIPPrinter = new PrinterOB();

                WIPPrinter.Name = row.Cells[0].Value.ToString();
                WIPPrinter.Location = row.Cells[1].Value.ToString();
                WIPPrinter.Comment = row.Cells[2].Value.ToString();
                WIPPrinter.PortName = row.Cells[3].Value.ToString();
                WIPPrinter.PortIP = row.Cells[4].Value.ToString();
                WIPPrinter.ShareName = row.Cells[6].Value.ToString();
                WIPPrinter.Driver = (PrinterDriver) row.Cells[7].Value;
                PrintersQueue.Enqueue(WIPPrinter);
            }

            while(PrintersQueue.Count > 0)
            {
                //PrinterProcesser.AddPrinters()
            }
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

        private void DataGrid_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if(DataGridView_PrinterCreation.CurrentCell.OwningColumn is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxEditingControl editingControl = (DataGridViewComboBoxEditingControl) DataGridView_PrinterCreation.EditingControl;
                e.Value = editingControl.SelectedItem;
                e.ParsingApplied = true;
            }
        }
    }
}
