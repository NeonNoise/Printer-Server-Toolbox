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
            List<string> printerDriverNames = new List<string>();
            DataGridViewComboBoxColumn myColumn = ((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["Drivername"]);
            foreach(PrinterDriver driver in printerDrivers)
            {
                printerDriverNames.Add(driver.Name);
            }
            myColumn.DataSource = printerDriverNames;
        }

        private void TestCreateFirstQueue(object sender, EventArgs e)
        {


            Queue<PrinterOB> PrintersQueue = new Queue<PrinterOB>();

            foreach (DataGridViewRow row in DataGridView_PrinterCreation.Rows)
            {
                DataGridViewRow workingRow = row;
                PrinterOB WIPPrinter = new PrinterOB();

                for (int CellValue = 0; CellValue < 7; CellValue++)
                {
                    string ParsedValue = ParseCellValueFromRow(workingRow, CellValue);
                    if(ParsedValue != "Invalid")
                    {
                        switch (CellValue)
                        {
                            case 0:
                                WIPPrinter.Name = ParsedValue;
                                break;
                            case 1:
                                WIPPrinter.Location = ParsedValue;
                                break;
                            case 2:
                                WIPPrinter.Comment = ParsedValue;
                                break;
                            case 3:
                                WIPPrinter.PortName = ParsedValue;
                                break;
                            case 4:
                                WIPPrinter.PortIP = ParsedValue;
                                break;
                            case 5:
                                //Unused
                                break;
                            case 6:
                                WIPPrinter.ShareName = ParsedValue;
                                break;
                            default:
                                //Do Nothing
                                break;
                        }
                    }

                    

                }
                PrinterDriver myDriver = new PrinterDriver(((DataGridViewComboBoxCell)(workingRow.Cells[7].Value)).Value.ToString());
                WIPPrinter.Driver = myDriver;
                MessageBox.Show(WIPPrinter.ToString());
                PrintersQueue.Enqueue(WIPPrinter);
            }
            //MessageBox.Show($"Name= {DataGridView_PrinterCreation.Rows[0].Cells[0].Value.ToString()} Driver = {DataGridView_PrinterCreation.Rows[0].Cells[7].Value.ToString()}");
            try
            {
                PrinterProcesser.AddPrinters(PrintersQueue);
            }
            catch (Exception)
            {

            }

        }

        private string ParseCellValueFromRow(DataGridViewRow row,int index)
        {
            //string output;
            //try
            //{
            //    output = row.Cells[index].Value.ToString();

            //}
            //catch (Exception)
            //{
            //    output = "Invalid";
            //}

            //if (string.IsNullOrEmpty(output))
            //{
            //    output = "Invalid";
            //}

            string output = "Test";

            return output;
            
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
