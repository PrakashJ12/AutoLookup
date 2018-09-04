namespace AutoLookup
{
    partial class Mainform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_results = new System.Windows.Forms.GroupBox();
            this.progressBar_singleLookup = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel_singleLookup = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_resultPing = new System.Windows.Forms.Label();
            this.label_resultLookup = new System.Windows.Forms.Label();
            this.label_resultReverse = new System.Windows.Forms.Label();
            this.pictureBox_ping = new System.Windows.Forms.PictureBox();
            this.pictureBox_lookup = new System.Windows.Forms.PictureBox();
            this.pictureBox_reverseLookup = new System.Windows.Forms.PictureBox();
            this.button_pasteIP = new System.Windows.Forms.Button();
            this.button_pasteFQDN = new System.Windows.Forms.Button();
            this.button_ClearCancel = new System.Windows.Forms.Button();
            this.button_Lookup = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FQDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_onTop = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoLookup = new System.Windows.Forms.CheckBox();
            this.checkBox_Autocopy = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_results.SuspendLayout();
            this.tableLayoutPanel_singleLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reverseLookup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox_results);
            this.groupBox1.Controls.Add(this.button_pasteIP);
            this.groupBox1.Controls.Add(this.button_pasteFQDN);
            this.groupBox1.Controls.Add(this.button_ClearCancel);
            this.groupBox1.Controls.Add(this.button_Lookup);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_FQDN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1180, 613);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lookup";
            // 
            // groupBox_results
            // 
            this.groupBox_results.Controls.Add(this.progressBar_singleLookup);
            this.groupBox_results.Controls.Add(this.tableLayoutPanel_singleLookup);
            this.groupBox_results.Location = new System.Drawing.Point(8, 267);
            this.groupBox_results.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_results.Name = "groupBox_results";
            this.groupBox_results.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_results.Size = new System.Drawing.Size(1164, 337);
            this.groupBox_results.TabIndex = 8;
            this.groupBox_results.TabStop = false;
            this.groupBox_results.Text = "Results";
            // 
            // progressBar_singleLookup
            // 
            this.progressBar_singleLookup.Location = new System.Drawing.Point(8, 40);
            this.progressBar_singleLookup.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_singleLookup.Maximum = 9;
            this.progressBar_singleLookup.Name = "progressBar_singleLookup";
            this.progressBar_singleLookup.Size = new System.Drawing.Size(1140, 46);
            this.progressBar_singleLookup.TabIndex = 1;
            // 
            // tableLayoutPanel_singleLookup
            // 
            this.tableLayoutPanel_singleLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_singleLookup.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_singleLookup.ColumnCount = 3;
            this.tableLayoutPanel_singleLookup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel_singleLookup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel_singleLookup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label_resultPing, 0, 2);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label_resultLookup, 1, 2);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.label_resultReverse, 2, 2);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.pictureBox_ping, 0, 1);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.pictureBox_lookup, 1, 1);
            this.tableLayoutPanel_singleLookup.Controls.Add(this.pictureBox_reverseLookup, 2, 1);
            this.tableLayoutPanel_singleLookup.Location = new System.Drawing.Point(8, 138);
            this.tableLayoutPanel_singleLookup.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_singleLookup.Name = "tableLayoutPanel_singleLookup";
            this.tableLayoutPanel_singleLookup.RowCount = 3;
            this.tableLayoutPanel_singleLookup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel_singleLookup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel_singleLookup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel_singleLookup.Size = new System.Drawing.Size(1140, 190);
            this.tableLayoutPanel_singleLookup.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ping";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lookup";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reverse";
            // 
            // label_resultPing
            // 
            this.label_resultPing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_resultPing.AutoSize = true;
            this.label_resultPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultPing.Location = new System.Drawing.Point(131, 146);
            this.label_resultPing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_resultPing.Name = "label_resultPing";
            this.label_resultPing.Size = new System.Drawing.Size(118, 31);
            this.label_resultPing.TabIndex = 3;
            this.label_resultPing.Text = "Success";
            // 
            // label_resultLookup
            // 
            this.label_resultLookup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_resultLookup.AutoSize = true;
            this.label_resultLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultLookup.Location = new System.Drawing.Point(510, 146);
            this.label_resultLookup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_resultLookup.Name = "label_resultLookup";
            this.label_resultLookup.Size = new System.Drawing.Size(118, 31);
            this.label_resultLookup.TabIndex = 4;
            this.label_resultLookup.Text = "Success";
            // 
            // label_resultReverse
            // 
            this.label_resultReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_resultReverse.AutoSize = true;
            this.label_resultReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultReverse.Location = new System.Drawing.Point(890, 146);
            this.label_resultReverse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_resultReverse.Name = "label_resultReverse";
            this.label_resultReverse.Size = new System.Drawing.Size(118, 31);
            this.label_resultReverse.TabIndex = 4;
            this.label_resultReverse.Text = "Success";
            // 
            // pictureBox_ping
            // 
            this.pictureBox_ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_ping.Location = new System.Drawing.Point(159, 68);
            this.pictureBox_ping.Name = "pictureBox_ping";
            this.pictureBox_ping.Size = new System.Drawing.Size(62, 62);
            this.pictureBox_ping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ping.TabIndex = 5;
            this.pictureBox_ping.TabStop = false;
            // 
            // pictureBox_lookup
            // 
            this.pictureBox_lookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_lookup.Location = new System.Drawing.Point(538, 68);
            this.pictureBox_lookup.Name = "pictureBox_lookup";
            this.pictureBox_lookup.Size = new System.Drawing.Size(62, 62);
            this.pictureBox_lookup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_lookup.TabIndex = 5;
            this.pictureBox_lookup.TabStop = false;
            // 
            // pictureBox_reverseLookup
            // 
            this.pictureBox_reverseLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_reverseLookup.Location = new System.Drawing.Point(918, 68);
            this.pictureBox_reverseLookup.Name = "pictureBox_reverseLookup";
            this.pictureBox_reverseLookup.Size = new System.Drawing.Size(62, 62);
            this.pictureBox_reverseLookup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reverseLookup.TabIndex = 5;
            this.pictureBox_reverseLookup.TabStop = false;
            // 
            // button_pasteIP
            // 
            this.button_pasteIP.Location = new System.Drawing.Point(524, 104);
            this.button_pasteIP.Margin = new System.Windows.Forms.Padding(4);
            this.button_pasteIP.Name = "button_pasteIP";
            this.button_pasteIP.Size = new System.Drawing.Size(134, 48);
            this.button_pasteIP.TabIndex = 7;
            this.button_pasteIP.Text = "Paste";
            this.button_pasteIP.UseVisualStyleBackColor = true;
            this.button_pasteIP.Click += new System.EventHandler(this.button_pasteIP_Click);
            // 
            // button_pasteFQDN
            // 
            this.button_pasteFQDN.Location = new System.Drawing.Point(964, 42);
            this.button_pasteFQDN.Margin = new System.Windows.Forms.Padding(4);
            this.button_pasteFQDN.Name = "button_pasteFQDN";
            this.button_pasteFQDN.Size = new System.Drawing.Size(134, 48);
            this.button_pasteFQDN.TabIndex = 6;
            this.button_pasteFQDN.Text = "Paste";
            this.button_pasteFQDN.UseVisualStyleBackColor = true;
            this.button_pasteFQDN.Click += new System.EventHandler(this.button_pasteFQDN_Click);
            // 
            // button_ClearCancel
            // 
            this.button_ClearCancel.Location = new System.Drawing.Point(520, 174);
            this.button_ClearCancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_ClearCancel.Name = "button_ClearCancel";
            this.button_ClearCancel.Size = new System.Drawing.Size(192, 50);
            this.button_ClearCancel.TabIndex = 5;
            this.button_ClearCancel.Text = "Clear/Cancel";
            this.button_ClearCancel.UseVisualStyleBackColor = true;
            this.button_ClearCancel.Click += new System.EventHandler(this.button_ClearCancel_Click);
            // 
            // button_Lookup
            // 
            this.button_Lookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Lookup.Location = new System.Drawing.Point(720, 174);
            this.button_Lookup.Margin = new System.Windows.Forms.Padding(4);
            this.button_Lookup.Name = "button_Lookup";
            this.button_Lookup.Size = new System.Drawing.Size(192, 50);
            this.button_Lookup.TabIndex = 5;
            this.button_Lookup.Text = "Lookup";
            this.button_Lookup.UseVisualStyleBackColor = true;
            this.button_Lookup.Click += new System.EventHandler(this.button_Lookup_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(136, 104);
            this.textBox_IP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(380, 50);
            this.textBox_IP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP: ";
            // 
            // textBox_FQDN
            // 
            this.textBox_FQDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FQDN.Location = new System.Drawing.Point(136, 44);
            this.textBox_FQDN.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FQDN.Name = "textBox_FQDN";
            this.textBox_FQDN.Size = new System.Drawing.Size(820, 50);
            this.textBox_FQDN.TabIndex = 2;
            this.textBox_FQDN.TextChanged += new System.EventHandler(this.textBox_FQDN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "FQDN: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_onTop);
            this.groupBox2.Controls.Add(this.checkBox_AutoLookup);
            this.groupBox2.Controls.Add(this.checkBox_Autocopy);
            this.groupBox2.Location = new System.Drawing.Point(956, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(216, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBox_onTop
            // 
            this.checkBox_onTop.AutoSize = true;
            this.checkBox_onTop.Location = new System.Drawing.Point(8, 35);
            this.checkBox_onTop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_onTop.Name = "checkBox_onTop";
            this.checkBox_onTop.Size = new System.Drawing.Size(185, 29);
            this.checkBox_onTop.TabIndex = 6;
            this.checkBox_onTop.Text = "Always on Top";
            this.checkBox_onTop.UseVisualStyleBackColor = true;
            this.checkBox_onTop.CheckedChanged += new System.EventHandler(this.checkBox_onTop_CheckedChanged);
            // 
            // checkBox_AutoLookup
            // 
            this.checkBox_AutoLookup.AutoSize = true;
            this.checkBox_AutoLookup.Enabled = false;
            this.checkBox_AutoLookup.Location = new System.Drawing.Point(8, 110);
            this.checkBox_AutoLookup.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_AutoLookup.Name = "checkBox_AutoLookup";
            this.checkBox_AutoLookup.Size = new System.Drawing.Size(165, 29);
            this.checkBox_AutoLookup.TabIndex = 1;
            this.checkBox_AutoLookup.Text = "Auto Lookup";
            this.checkBox_AutoLookup.UseVisualStyleBackColor = true;
            this.checkBox_AutoLookup.CheckedChanged += new System.EventHandler(this.checkBox_AutoLookup_CheckedChanged);
            // 
            // checkBox_Autocopy
            // 
            this.checkBox_Autocopy.AutoSize = true;
            this.checkBox_Autocopy.Checked = true;
            this.checkBox_Autocopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Autocopy.Location = new System.Drawing.Point(8, 69);
            this.checkBox_Autocopy.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Autocopy.Name = "checkBox_Autocopy";
            this.checkBox_Autocopy.Size = new System.Drawing.Size(134, 29);
            this.checkBox_Autocopy.TabIndex = 0;
            this.checkBox_Autocopy.Text = "Autocopy";
            this.checkBox_Autocopy.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 642);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.Text = "AutoLookup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_results.ResumeLayout(false);
            this.tableLayoutPanel_singleLookup.ResumeLayout(false);
            this.tableLayoutPanel_singleLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reverseLookup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_AutoLookup;
        private System.Windows.Forms.CheckBox checkBox_Autocopy;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FQDN;
        private System.Windows.Forms.Button button_Lookup;
        private System.Windows.Forms.CheckBox checkBox_onTop;
        private System.Windows.Forms.Button button_pasteIP;
        private System.Windows.Forms.Button button_pasteFQDN;
        private System.Windows.Forms.GroupBox groupBox_results;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_singleLookup;
        private System.Windows.Forms.ProgressBar progressBar_singleLookup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_resultPing;
        private System.Windows.Forms.Label label_resultLookup;
        private System.Windows.Forms.Label label_resultReverse;
        private System.Windows.Forms.PictureBox pictureBox_ping;
        private System.Windows.Forms.PictureBox pictureBox_lookup;
        private System.Windows.Forms.PictureBox pictureBox_reverseLookup;
        private System.Windows.Forms.Button button_ClearCancel;
    }
}

