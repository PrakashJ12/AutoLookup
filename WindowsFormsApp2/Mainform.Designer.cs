namespace Autolookup
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
            this.button_Lookup = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FQDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_AutoLookup = new System.Windows.Forms.CheckBox();
            this.checkBox_Autocopy = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Lookup);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_FQDN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lookup";
            // 
            // button_Lookup
            // 
            this.button_Lookup.Location = new System.Drawing.Point(301, 140);
            this.button_Lookup.Name = "button_Lookup";
            this.button_Lookup.Size = new System.Drawing.Size(143, 40);
            this.button_Lookup.TabIndex = 5;
            this.button_Lookup.Text = "Check";
            this.button_Lookup.UseVisualStyleBackColor = true;
            this.button_Lookup.Click += new System.EventHandler(this.button_Lookup_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(102, 83);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(342, 39);
            this.textBox_IP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP: ";
            // 
            // textBox_FQDN
            // 
            this.textBox_FQDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FQDN.Location = new System.Drawing.Point(102, 35);
            this.textBox_FQDN.Name = "textBox_FQDN";
            this.textBox_FQDN.Size = new System.Drawing.Size(342, 39);
            this.textBox_FQDN.TabIndex = 2;
            this.textBox_FQDN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FQDN: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_AutoLookup);
            this.groupBox2.Controls.Add(this.checkBox_Autocopy);
            this.groupBox2.Location = new System.Drawing.Point(570, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 93);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBox_AutoLookup
            // 
            this.checkBox_AutoLookup.AutoSize = true;
            this.checkBox_AutoLookup.Location = new System.Drawing.Point(7, 57);
            this.checkBox_AutoLookup.Name = "checkBox_AutoLookup";
            this.checkBox_AutoLookup.Size = new System.Drawing.Size(126, 24);
            this.checkBox_AutoLookup.TabIndex = 1;
            this.checkBox_AutoLookup.Text = "Auto Lookup";
            this.checkBox_AutoLookup.UseVisualStyleBackColor = true;
            // 
            // checkBox_Autocopy
            // 
            this.checkBox_Autocopy.AutoSize = true;
            this.checkBox_Autocopy.Location = new System.Drawing.Point(7, 26);
            this.checkBox_Autocopy.Name = "checkBox_Autocopy";
            this.checkBox_Autocopy.Size = new System.Drawing.Size(102, 24);
            this.checkBox_Autocopy.TabIndex = 0;
            this.checkBox_Autocopy.Text = "Autocopy";
            this.checkBox_Autocopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

