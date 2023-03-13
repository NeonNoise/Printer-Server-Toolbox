﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenPrinterListForm(object sender, EventArgs e)
        {
            GetPrinterListForm newPrinterListForm = new GetPrinterListForm();
            newPrinterListForm.Show();
        }

        private void OpenBulkCreatePrinterForm(object sender, EventArgs e)
        {
            BulkCreatePrinterForm newPCreatePrinterForm = new BulkCreatePrinterForm();
            newPCreatePrinterForm.Show();
        }

        private void ConfirmSpoolerReboot(object sender, EventArgs e)
        {
            ConfirmSpoolerRestart confirmSpoolerRestart = new ConfirmSpoolerRestart();
            confirmSpoolerRestart.Show();
        }
    }
}
