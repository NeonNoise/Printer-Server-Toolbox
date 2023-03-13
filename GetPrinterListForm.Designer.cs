namespace PrinterServerToolbox
{
    partial class GetPrinterListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPrinterListForm));
            this.button_Run = new System.Windows.Forms.Button();
            this.PrinterListView = new System.Windows.Forms.DataGridView();
            this.Server_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Share_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print_processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_pages_per_minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printer_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterListView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(1222, 12);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 7;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.RunPrinterList);
            // 
            // PrinterListView
            // 
            this.PrinterListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrinterListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Server_name,
            this.Printer_name,
            this.Share_name,
            this.Driver_name,
            this.Port_name,
            this.Comment,
            this.Location,
            this.Print_processor,
            this.Data_type,
            this.Average_pages_per_minute,
            this.Printer_status});
            this.PrinterListView.Location = new System.Drawing.Point(12, 41);
            this.PrinterListView.Name = "PrinterListView";
            this.PrinterListView.Size = new System.Drawing.Size(1265, 499);
            this.PrinterListView.TabIndex = 8;
            // 
            // Server_name
            // 
            this.Server_name.HeaderText = "Server Name";
            this.Server_name.Name = "Server_name";
            this.Server_name.ToolTipText = "Name of the Print Server";
            // 
            // Printer_name
            // 
            this.Printer_name.HeaderText = "Printer Name";
            this.Printer_name.Name = "Printer_name";
            // 
            // Share_name
            // 
            this.Share_name.HeaderText = "Share Name";
            this.Share_name.Name = "Share_name";
            // 
            // Driver_name
            // 
            this.Driver_name.HeaderText = "Driver Name";
            this.Driver_name.Name = "Driver_name";
            // 
            // Port_name
            // 
            this.Port_name.HeaderText = "Port Name";
            this.Port_name.Name = "Port_name";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Print_processor
            // 
            this.Print_processor.HeaderText = "Print Processor";
            this.Print_processor.Name = "Print_processor";
            // 
            // Data_type
            // 
            this.Data_type.HeaderText = "Data Type";
            this.Data_type.Name = "Data_type";
            // 
            // Average_pages_per_minute
            // 
            this.Average_pages_per_minute.HeaderText = "Avg Pages Per Minute";
            this.Average_pages_per_minute.Name = "Average_pages_per_minute";
            // 
            // Printer_status
            // 
            this.Printer_status.HeaderText = "Printer Status";
            this.Printer_status.Name = "Printer_status";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1280, 41);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 499);
            this.vScrollBar1.TabIndex = 9;
            // 
            // GetPrinterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 552);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.PrinterListView);
            this.Controls.Add(this.button_Run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetPrinterListForm";
            this.Text = "Printer List";
            ((System.ComponentModel.ISupportInitialize)(this.PrinterListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.DataGridView PrinterListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Print_processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_pages_per_minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printer_status;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}