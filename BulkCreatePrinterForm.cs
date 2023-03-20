using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterServerToolbox
{
    public partial class BulkCreatePrinterForm : Form
    {
        ComboBox combo;
        public BulkCreatePrinterForm()
        {
            InitializeComponent();
            combo = new ComboBox();
            ((DataGridViewComboBoxColumn)DataGridView_PrinterCreation.Columns["DriverName"]).DataSource = combo.Items;
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPrinterOptions(object sender, EventArgs e)
        {
            List<PrinterDriver> printerDrivers = PrinterProcesser.GetAllPrintDrivers();
            combo = new ComboBox();
            foreach(PrinterDriver driver in printerDrivers)
            {
                combo.Items.Add(driver.Name);
            }

            

        }
    }
}
