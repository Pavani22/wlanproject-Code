namespace NodeC
{
    partial class NodeC
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
            this.listBoxDest = new System.Windows.Forms.ListBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDest
            // 
            this.listBoxDest.FormattingEnabled = true;
            this.listBoxDest.Location = new System.Drawing.Point(304, 12);
            this.listBoxDest.Name = "listBoxDest";
            this.listBoxDest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDest.Size = new System.Drawing.Size(120, 95);
            this.listBoxDest.TabIndex = 0;
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(70, 131);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(742, 20);
            this.textBoxFN.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(851, 131);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(57, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Of Encryption";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(429, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(211, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "128-bit WEP with 26 hexadecimal digits";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(50, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "128-bit WEP with 13 characters";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(429, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(205, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "64-bit WEP with 10 hexadecimal digits";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(50, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "64-bit WEP with 5 characters";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonEnc
            // 
            this.buttonEnc.Location = new System.Drawing.Point(851, 224);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(75, 23);
            this.buttonEnc.TabIndex = 4;
            this.buttonEnc.Text = "Encrypt";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(57, 346);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxData.Size = new System.Drawing.Size(742, 285);
            this.textBoxData.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(851, 370);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(851, 460);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(75, 23);
            this.buttonRec.TabIndex = 7;
            this.buttonRec.Text = "Recieve";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(851, 548);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(75, 23);
            this.buttonDec.TabIndex = 8;
            this.buttonDec.Text = "Decrypt";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NodeC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 643);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.listBoxDest);
            this.Name = "NodeC";
            this.Text = "NodeC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDest;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

