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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkProcessForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Lookup = new System.Windows.Forms.DataGridView();
            this.fqdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReverseLookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_BulkLookup = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(663, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Processing";
            // 
            // dataGridView_Lookup
            // 
            this.dataGridView_Lookup.AllowUserToAddRows = false;
            this.dataGridView_Lookup.AllowUserToDeleteRows = false;
            this.dataGridView_Lookup.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.dataGridView_Lookup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Lookup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Lookup.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Lookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lookup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fqdn,
            this.ip,
            this.Ping,
            this.Lookup,
            this.ReverseLookup,
            this.Remarks});
            this.dataGridView_Lookup.Location = new System.Drawing.Point(3, 68);
            this.dataGridView_Lookup.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Lookup.Name = "dataGridView_Lookup";
            this.dataGridView_Lookup.ReadOnly = true;
            this.dataGridView_Lookup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Lookup.RowTemplate.Height = 33;
            this.dataGridView_Lookup.Size = new System.Drawing.Size(657, 348);
            this.dataGridView_Lookup.TabIndex = 1;
            this.dataGridView_Lookup.Sorted += new System.EventHandler(this.dataGridView_Lookup_Sorted);
            // 
            // fqdn
            // 
            this.fqdn.DataPropertyName = "fqdn";
            this.fqdn.HeaderText = "FQDN";
            this.fqdn.Name = "fqdn";
            this.fqdn.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // Ping
            // 
            this.Ping.HeaderText = "Ping";
            this.Ping.Name = "Ping";
            this.Ping.ReadOnly = true;
            // 
            // Lookup
            // 
            this.Lookup.HeaderText = "Lookup";
            this.Lookup.Name = "Lookup";
            this.Lookup.ReadOnly = true;
            // 
            // ReverseLookup
            // 
            this.ReverseLookup.HeaderText = "Reverse Lookup";
            this.ReverseLookup.Name = "ReverseLookup";
            this.ReverseLookup.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox_FilePath);
            this.groupBox2.Controls.Add(this.button_BulkLookup);
            this.groupBox2.Controls.Add(this.button_OpenFile);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(655, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FilePath.Enabled = false;
            this.textBox_FilePath.Location = new System.Drawing.Point(70, 19);
            this.textBox_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FilePath.Multiline = true;
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(503, 24);
            this.textBox_FilePath.TabIndex = 3;
            // 
            // button_BulkLookup
            // 
            this.button_BulkLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BulkLookup.Location = new System.Drawing.Point(577, 19);
            this.button_BulkLookup.Margin = new System.Windows.Forms.Padding(2);
            this.button_BulkLookup.Name = "button_BulkLookup";
            this.button_BulkLookup.Size = new System.Drawing.Size(74, 24);
            this.button_BulkLookup.TabIndex = 2;
            this.button_BulkLookup.Text = "Lookup";
            this.button_BulkLookup.UseVisualStyleBackColor = true;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(3, 19);
            this.button_OpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(64, 22);
            this.button_OpenFile.TabIndex = 0;
            this.button_OpenFile.Text = "Select File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // BulkProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 432);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button_BulkLookup;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.DataGridView dataGridView_Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fqdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverseLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}