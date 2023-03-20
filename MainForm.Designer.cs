namespace PrinterServerToolbox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_OpenGetPrinterListForm = new System.Windows.Forms.Button();
            this.BulkAddPrinterbutton = new System.Windows.Forms.Button();
            this.serviceControllerSpooler = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // button_OpenGetPrinterListForm
            // 
            this.button_OpenGetPrinterListForm.Location = new System.Drawing.Point(66, 54);
            this.button_OpenGetPrinterListForm.Name = "button_OpenGetPrinterListForm";
            this.button_OpenGetPrinterListForm.Size = new System.Drawing.Size(117, 61);
            this.button_OpenGetPrinterListForm.TabIndex = 0;
            this.button_OpenGetPrinterListForm.Text = "Get Printer List";
            this.button_OpenGetPrinterListForm.UseVisualStyleBackColor = true;
            this.button_OpenGetPrinterListForm.Click += new System.EventHandler(this.OpenPrinterListForm);
            // 
            // BulkAddPrinterbutton
            // 
            this.BulkAddPrinterbutton.Location = new System.Drawing.Point(238, 54);
            this.BulkAddPrinterbutton.Name = "BulkAddPrinterbutton";
            this.BulkAddPrinterbutton.Size = new System.Drawing.Size(109, 61);
            this.BulkAddPrinterbutton.TabIndex = 1;
            this.BulkAddPrinterbutton.Text = "Bulk Add Printers";
            this.BulkAddPrinterbutton.UseVisualStyleBackColor = true;
            this.BulkAddPrinterbutton.Click += new System.EventHandler(this.OpenBulkCreatePrinterForm);
            // 
            // serviceControllerSpooler
            // 
            this.serviceControllerSpooler.ServiceName = "Spooler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BulkAddPrinterbutton);
            this.Controls.Add(this.button_OpenGetPrinterListForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Printer Server Toolbox";
            this.Load += new System.EventHandler(this.CheckPropertysFolder);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenGetPrinterListForm;
        private System.Windows.Forms.Button BulkAddPrinterbutton;
        private System.ServiceProcess.ServiceController serviceControllerSpooler;
    }
}

