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
            string path = openDriverFileDialog.FileName;
            OleDbConnection dbConnection;
            DataSet dataSet;
            OleDbDataAdapter dbCommand;
            dbConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + path + "';Extended Properties=Excel 8.0");
            dbCommand = new OleDbDataAdapter("select * from [Sheet1]", dbConnection);
            dbCommand.TableMappings.Add("Table", "PrinterQueueName");
            dataSet = new DataSet();
            try
            {
                dbCommand.Fill(dataSet);
            }
            catch (Exception exception)
            {
                openDriverFileDialog.Title = exception.ToString();
                openDriverFileDialog.ShowDialog();
            }
            
            DataGridView_PrinterCreation.DataSource = dataSet.Tables[0];
            dbConnection.Close();
        }
    }
}
