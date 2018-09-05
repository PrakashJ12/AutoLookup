namespace AutoLookup
{
    partial class BulkProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkProcessForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Lookup = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FQDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReverseLookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_Lookup = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lookup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView_Lookup);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 870);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Processing";
            // 
            // dataGridView_Lookup
            // 
            this.dataGridView_Lookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lookup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FQDN,
            this.IP,
            this.Ping,
            this.Lookup,
            this.ReverseLookup,
            this.Remarks});
            this.dataGridView_Lookup.Location = new System.Drawing.Point(6, 131);
            this.dataGridView_Lookup.Name = "dataGridView_Lookup";
            this.dataGridView_Lookup.RowTemplate.Height = 33;
            this.dataGridView_Lookup.Size = new System.Drawing.Size(1242, 733);
            this.dataGridView_Lookup.TabIndex = 1;
            // 
            // No
            // 
            this.No.HeaderText = "No:";
            this.No.Name = "No";
            // 
            // FQDN
            // 
            this.FQDN.HeaderText = "FQDN";
            this.FQDN.Name = "FQDN";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // Ping
            // 
            this.Ping.HeaderText = "Ping";
            this.Ping.Name = "Ping";
            // 
            // Lookup
            // 
            this.Lookup.HeaderText = "Lookup";
            this.Lookup.Name = "Lookup";
            // 
            // ReverseLookup
            // 
            this.ReverseLookup.HeaderText = "Reverse Lookup";
            this.ReverseLookup.Name = "ReverseLookup";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox_FilePath);
            this.groupBox2.Controls.Add(this.button_Lookup);
            this.groupBox2.Controls.Add(this.button_OpenFile);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FilePath.Enabled = false;
            this.textBox_FilePath.Location = new System.Drawing.Point(139, 36);
            this.textBox_FilePath.Multiline = true;
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(943, 43);
            this.textBox_FilePath.TabIndex = 3;
            // 
            // button_Lookup
            // 
            this.button_Lookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Lookup.Location = new System.Drawing.Point(1088, 36);
            this.button_Lookup.Name = "button_Lookup";
            this.button_Lookup.Size = new System.Drawing.Size(148, 43);
            this.button_Lookup.TabIndex = 2;
            this.button_Lookup.Text = "Lookup";
            this.button_Lookup.UseVisualStyleBackColor = true;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(6, 36);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(127, 43);
            this.button_OpenFile.TabIndex = 0;
            this.button_OpenFile.Text = "Select File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            // 
            // BulkProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BulkProcessForm";
            this.Text = "Bulk Lookup (Excel) [Unfinished: Work In Progress]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkProcessForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lookup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_Lookup;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.DataGridView dataGridView_Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FQDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverseLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}