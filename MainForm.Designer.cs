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
            this.CreatePrinterConfigbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.BulkAddPrinterbutton.Size = new System.Drawing.Size(117, 61);
            this.BulkAddPrinterbutton.TabIndex = 1;
            this.BulkAddPrinterbutton.Text = "Bulk Add Printers";
            this.BulkAddPrinterbutton.UseVisualStyleBackColor = true;
            this.BulkAddPrinterbutton.Click += new System.EventHandler(this.OpenBulkCreatePrinterForm);
            // 
            // serviceControllerSpooler
            // 
            this.serviceControllerSpooler.ServiceName = "Spooler";
            // 
            // CreatePrinterConfigbutton
            // 
            this.CreatePrinterConfigbutton.Location = new System.Drawing.Point(398, 54);
            this.CreatePrinterConfigbutton.Name = "CreatePrinterConfigbutton";
            this.CreatePrinterConfigbutton.Size = new System.Drawing.Size(117, 61);
            this.CreatePrinterConfigbutton.TabIndex = 2;
            this.CreatePrinterConfigbutton.Text = "Create Printer Config";
            this.CreatePrinterConfigbutton.UseVisualStyleBackColor = true;
            this.CreatePrinterConfigbutton.Click += new System.EventHandler(this.OpenCreatePrinterConfigForm);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Placeholder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Placeholder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "Placeholder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 61);
            this.button5.TabIndex = 7;
            this.button5.Text = "Placeholder";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreatePrinterConfigbutton);
            this.Controls.Add(this.BulkAddPrinterbutton);
            this.Controls.Add(this.button_OpenGetPrinterListForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Printer Server Toolbox";
            this.Load += new System.EventHandler(this.CheckAllFolders);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenGetPrinterListForm;
        private System.Windows.Forms.Button BulkAddPrinterbutton;
        private System.ServiceProcess.ServiceController serviceControllerSpooler;
        private System.Windows.Forms.Button CreatePrinterConfigbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

