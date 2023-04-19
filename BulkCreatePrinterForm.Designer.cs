namespace PrinterServerToolbox
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
            this.DataGridView_PrinterCreation = new System.Windows.Forms.DataGridView();
            this.PrintQueueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shared = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ShareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ConfigProfile = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDriversDirecotryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestCreateFirstQueueButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PrinterCreation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDriverFileDialog
            // 
            this.openDriverFileDialog.FileName = "openFileDialog1";
            // 
            // DataGridView_PrinterCreation
            // 
            this.DataGridView_PrinterCreation.AllowDrop = true;
            this.DataGridView_PrinterCreation.AllowUserToOrderColumns = true;
            this.DataGridView_PrinterCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_PrinterCreation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrintQueueName,
            this.Location,
            this.Comment,
            this.PortName,
            this.PortIP,
            this.Shared,
            this.ShareName,
            this.DriverName,
            this.ConfigProfile});
            this.DataGridView_PrinterCreation.Location = new System.Drawing.Point(0, 27);
            this.DataGridView_PrinterCreation.Name = "DataGridView_PrinterCreation";
            this.DataGridView_PrinterCreation.Size = new System.Drawing.Size(1277, 414);
            this.DataGridView_PrinterCreation.TabIndex = 0;
            this.DataGridView_PrinterCreation.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGrid_CellParsing);
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
            this.DriverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.Items.AddRange(new object[] {
            "None"});
            this.DriverName.Name = "DriverName";
            this.DriverName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DriverName.Width = 84;
            // 
            // ConfigProfile
            // 
            this.ConfigProfile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ConfigProfile.HeaderText = "Config Profile";
            this.ConfigProfile.Name = "ConfigProfile";
            this.ConfigProfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ConfigProfile.Width = 87;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1280, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 432);
            this.vScrollBar1.TabIndex = 1;
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.FileName = "Import";
            this.openExcelFileDialog.Title = "Import Excel Data";
            this.openExcelFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadExcel);
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
            this.ImportButton,
            this.exportToolStripMenuItem});
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.importExportToolStripMenuItem.Text = "Import/Export";
            // 
            // ImportButton
            // 
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(110, 22);
            this.ImportButton.Text = "Import";
            this.ImportButton.Click += new System.EventHandler(this.OpenImport);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.tXTToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
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
            this.refreshOptionsToolStripMenuItem.Click += new System.EventHandler(this.RefreshPrinterOptions);
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
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestCreateFirstQueueButton});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // TestCreateFirstQueueButton
            // 
            this.TestCreateFirstQueueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestCreateFirstQueueButton.Name = "TestCreateFirstQueueButton";
            this.TestCreateFirstQueueButton.Size = new System.Drawing.Size(180, 22);
            this.TestCreateFirstQueueButton.Text = "Bulk Create Queues";
            this.TestCreateFirstQueueButton.Click += new System.EventHandler(this.TestCreateFirstQueue);
            // 
            // BulkCreatePrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.DataGridView_PrinterCreation);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BulkCreatePrinterForm";
            this.Text = "Printer Creation";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PrinterCreation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDriverFileDialog;
        private System.Windows.Forms.DataGridView DataGridView_PrinterCreation;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestCreateFirstQueueButton;
        private System.Windows.Forms.ToolStripMenuItem openSettingsDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDriversDirecotryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintQueueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortIP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Shared;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ConfigProfile;
    }
}