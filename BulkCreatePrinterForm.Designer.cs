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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkCreatePrinterForm));
            this.openDriverFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1280, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 432);
            this.vScrollBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1189, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.ShareName.DefaultCellStyle = dataGridViewCellStyle3;
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
            // BulkCreatePrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BulkCreatePrinterForm";
            this.Text = "Printer Creation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDriverFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.Button button2;
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
    }
}