﻿namespace PrinterServerToolbox
{
    partial class BulkCreatePrinterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkCreatePrinterForm));
            this.openDriverFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrintQueueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDefaultPrinter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Shared = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ShareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkCreatePrintQueuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCreateFirstQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDriversDirecotryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDriverFileDialog
            // 
            this.openDriverFileDialog.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrintQueueName,
            this.Location,
            this.Comment,
            this.PortName,
            this.PortIP,
            this.IsDefaultPrinter,
            this.Shared,
            this.ShareName,
            this.DriverName,
            this.InfFilePath});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1277, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PrintQueueName
            // 
            this.PrintQueueName.HeaderText = "Print Queue Name";
            this.PrintQueueName.Name = "PrintQueueName";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // PortName
            // 
            this.PortName.HeaderText = "Port Name";
            this.PortName.Name = "PortName";
            // 
            // PortIP
            // 
            this.PortIP.HeaderText = "Port IP";
            this.PortIP.Name = "PortIP";
            // 
            // IsDefaultPrinter
            // 
            this.IsDefaultPrinter.FalseValue = "N";
            this.IsDefaultPrinter.HeaderText = "Default";
            this.IsDefaultPrinter.Name = "IsDefaultPrinter";
            this.IsDefaultPrinter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDefaultPrinter.TrueValue = "Y";
            // 
            // Shared
            // 
            this.Shared.FalseValue = "N";
            this.Shared.HeaderText = "Shared";
            this.Shared.Name = "Shared";
            this.Shared.TrueValue = "Y";
            // 
            // ShareName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.ShareName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ShareName.HeaderText = "Share Name";
            this.ShareName.Name = "ShareName";
            this.ShareName.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.Name = "DriverName";
            // 
            // InfFilePath
            // 
            this.InfFilePath.HeaderText = "Inf File Path";
            this.InfFilePath.Name = "InfFilePath";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1280, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 432);
            this.vScrollBar1.TabIndex = 1;
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importExportToolStripMenuItem.Text = "Import/Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.tXTToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.tXTToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // tXTToolStripMenuItem1
            // 
            this.tXTToolStripMenuItem1.Name = "tXTToolStripMenuItem1";
            this.tXTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tXTToolStripMenuItem1.Text = "TXT";
            this.tXTToolStripMenuItem1.Click += new System.EventHandler(this.tXTToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshOptionsToolStripMenuItem,
            this.openSettingsDirectoryToolStripMenuItem,
            this.openDriversDirecotryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshOptionsToolStripMenuItem
            // 
            this.refreshOptionsToolStripMenuItem.Name = "refreshOptionsToolStripMenuItem";
            this.refreshOptionsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.refreshOptionsToolStripMenuItem.Text = "Refresh Options";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulkCreatePrintQueuesToolStripMenuItem,
            this.testCreateFirstQueueToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // bulkCreatePrintQueuesToolStripMenuItem
            // 
            this.bulkCreatePrintQueuesToolStripMenuItem.Name = "bulkCreatePrintQueuesToolStripMenuItem";
            this.bulkCreatePrintQueuesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.bulkCreatePrintQueuesToolStripMenuItem.Text = "Bulk Create Print Queues";
            // 
            // testCreateFirstQueueToolStripMenuItem
            // 
            this.testCreateFirstQueueToolStripMenuItem.Name = "testCreateFirstQueueToolStripMenuItem";
            this.testCreateFirstQueueToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testCreateFirstQueueToolStripMenuItem.Text = "Test Create First Queue";
            // 
            // openSettingsDirectoryToolStripMenuItem
            // 
            this.openSettingsDirectoryToolStripMenuItem.Name = "openSettingsDirectoryToolStripMenuItem";
            this.openSettingsDirectoryToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openSettingsDirectoryToolStripMenuItem.Text = "Open Settings Directory";
            // 
            // openDriversDirecotryToolStripMenuItem
            // 
            this.openDriversDirecotryToolStripMenuItem.Name = "openDriversDirecotryToolStripMenuItem";
            this.openDriversDirecotryToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openDriversDirecotryToolStripMenuItem.Text = "Open Drivers Directory";
            // 
            // BulkCreatePrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BulkCreatePrinterForm";
            this.Text = "Printer Creation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDriverFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintQueueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortIP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDefaultPrinter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Shared;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfFilePath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkCreatePrintQueuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testCreateFirstQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDriversDirecotryToolStripMenuItem;
    }
}