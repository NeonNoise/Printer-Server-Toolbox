namespace PrinterServerToolbox
{
    partial class CreatePrinterConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrinterConfigForm));
            this.RefrshPrintersbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateConfigbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RefrshPrintersbutton
            // 
            this.RefrshPrintersbutton.Location = new System.Drawing.Point(12, 12);
            this.RefrshPrintersbutton.Name = "RefrshPrintersbutton";
            this.RefrshPrintersbutton.Size = new System.Drawing.Size(267, 23);
            this.RefrshPrintersbutton.TabIndex = 0;
            this.RefrshPrintersbutton.Text = "Refresh Printers";
            this.RefrshPrintersbutton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // CreateConfigbutton
            // 
            this.CreateConfigbutton.Location = new System.Drawing.Point(13, 160);
            this.CreateConfigbutton.Name = "CreateConfigbutton";
            this.CreateConfigbutton.Size = new System.Drawing.Size(266, 23);
            this.CreateConfigbutton.TabIndex = 2;
            this.CreateConfigbutton.Text = "Create Config for Selected Printer";
            this.CreateConfigbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(266, 71);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Port:\r\nDriver:";
            // 
            // CreatePrinterConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 221);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateConfigbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RefrshPrintersbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePrinterConfigForm";
            this.Text = "Create Printer Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefrshPrintersbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreateConfigbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}