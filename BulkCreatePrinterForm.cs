using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataGridViewRowCollection Rows = DataGridView_PrinterCreation.Rows;
            DataGridViewRow Row = Rows.SharedRow(0);
            Debug.WriteLine(Row.ToString());
            
        }
    }
}
