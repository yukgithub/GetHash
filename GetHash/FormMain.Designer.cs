
namespace GetHash
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSHA512 = new System.Windows.Forms.RadioButton();
            this.rdoSHA384 = new System.Windows.Forms.RadioButton();
            this.rdoSHA256 = new System.Windows.Forms.RadioButton();
            this.rdoSHA1 = new System.Windows.Forms.RadioButton();
            this.rdoMD5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.rdoChars = new System.Windows.Forms.RadioButton();
            this.txtCharas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputHash = new System.Windows.Forms.TextBox();
            this.chkCompare = new System.Windows.Forms.CheckBox();
            this.txtCompareHash = new System.Windows.Forms.TextBox();
            this.lblCompareHash = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSHA512);
            this.groupBox1.Controls.Add(this.rdoSHA384);
            this.groupBox1.Controls.Add(this.rdoSHA256);
            this.groupBox1.Controls.Add(this.rdoSHA1);
            this.groupBox1.Controls.Add(this.rdoMD5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // rdoSHA512
            // 
            this.rdoSHA512.AutoSize = true;
            this.rdoSHA512.Location = new System.Drawing.Point(396, 37);
            this.rdoSHA512.Name = "rdoSHA512";
            this.rdoSHA512.Size = new System.Drawing.Size(100, 26);
            this.rdoSHA512.TabIndex = 5;
            this.rdoSHA512.Text = "SHA512";
            this.rdoSHA512.UseVisualStyleBackColor = true;
            this.rdoSHA512.CheckedChanged += new System.EventHandler(this.rdoSHA512_CheckedChanged);
            // 
            // rdoSHA384
            // 
            this.rdoSHA384.AutoSize = true;
            this.rdoSHA384.Location = new System.Drawing.Point(290, 37);
            this.rdoSHA384.Name = "rdoSHA384";
            this.rdoSHA384.Size = new System.Drawing.Size(100, 26);
            this.rdoSHA384.TabIndex = 4;
            this.rdoSHA384.Text = "SHA384";
            this.rdoSHA384.UseVisualStyleBackColor = true;
            this.rdoSHA384.CheckedChanged += new System.EventHandler(this.rdoSHA384_CheckedChanged);
            // 
            // rdoSHA256
            // 
            this.rdoSHA256.AutoSize = true;
            this.rdoSHA256.Checked = true;
            this.rdoSHA256.Location = new System.Drawing.Point(184, 37);
            this.rdoSHA256.Name = "rdoSHA256";
            this.rdoSHA256.Size = new System.Drawing.Size(100, 26);
            this.rdoSHA256.TabIndex = 3;
            this.rdoSHA256.TabStop = true;
            this.rdoSHA256.Text = "SHA256";
            this.rdoSHA256.UseVisualStyleBackColor = true;
            this.rdoSHA256.CheckedChanged += new System.EventHandler(this.rdoSHA256_CheckedChanged);
            // 
            // rdoSHA1
            // 
            this.rdoSHA1.AutoSize = true;
            this.rdoSHA1.Location = new System.Drawing.Point(100, 37);
            this.rdoSHA1.Name = "rdoSHA1";
            this.rdoSHA1.Size = new System.Drawing.Size(78, 26);
            this.rdoSHA1.TabIndex = 1;
            this.rdoSHA1.Text = "SHA1";
            this.rdoSHA1.UseVisualStyleBackColor = true;
            this.rdoSHA1.CheckedChanged += new System.EventHandler(this.rdoSHA1_CheckedChanged);
            // 
            // rdoMD5
            // 
            this.rdoMD5.AutoSize = true;
            this.rdoMD5.Location = new System.Drawing.Point(25, 37);
            this.rdoMD5.Name = "rdoMD5";
            this.rdoMD5.Size = new System.Drawing.Size(69, 26);
            this.rdoMD5.TabIndex = 0;
            this.rdoMD5.Text = "MD5";
            this.rdoMD5.UseVisualStyleBackColor = true;
            this.rdoMD5.CheckedChanged += new System.EventHandler(this.rdoMD5_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFile);
            this.groupBox2.Controls.Add(this.rdoChars);
            this.groupBox2.Location = new System.Drawing.Point(536, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Source";
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(146, 33);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(59, 26);
            this.rdoFile.TabIndex = 7;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;
            this.rdoFile.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // rdoChars
            // 
            this.rdoChars.AutoSize = true;
            this.rdoChars.Checked = true;
            this.rdoChars.Location = new System.Drawing.Point(20, 33);
            this.rdoChars.Name = "rdoChars";
            this.rdoChars.Size = new System.Drawing.Size(120, 26);
            this.rdoChars.TabIndex = 6;
            this.rdoChars.TabStop = true;
            this.rdoChars.Text = "Characters";
            this.rdoChars.UseVisualStyleBackColor = true;
            this.rdoChars.CheckedChanged += new System.EventHandler(this.rdoChars_CheckedChanged);
            // 
            // txtCharas
            // 
            this.txtCharas.AllowDrop = true;
            this.txtCharas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharas.Location = new System.Drawing.Point(124, 133);
            this.txtCharas.Name = "txtCharas";
            this.txtCharas.Size = new System.Drawing.Size(731, 29);
            this.txtCharas.TabIndex = 8;
            this.txtCharas.TextChanged += new System.EventHandler(this.txtCharas_TextChanged);
            this.txtCharas.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCharas_DragDrop);
            this.txtCharas.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtCharas_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Characters:";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Enabled = false;
            this.btnFile.Location = new System.Drawing.Point(861, 133);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(37, 29);
            this.btnFile.TabIndex = 9;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hash:";
            // 
            // txtInputHash
            // 
            this.txtInputHash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputHash.Location = new System.Drawing.Point(124, 168);
            this.txtInputHash.Multiline = true;
            this.txtInputHash.Name = "txtInputHash";
            this.txtInputHash.ReadOnly = true;
            this.txtInputHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputHash.Size = new System.Drawing.Size(731, 58);
            this.txtInputHash.TabIndex = 10;
            // 
            // chkCompare
            // 
            this.chkCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCompare.AutoSize = true;
            this.chkCompare.Location = new System.Drawing.Point(12, 251);
            this.chkCompare.Name = "chkCompare";
            this.chkCompare.Size = new System.Drawing.Size(106, 26);
            this.chkCompare.TabIndex = 11;
            this.chkCompare.Text = "Compare";
            this.chkCompare.UseVisualStyleBackColor = true;
            this.chkCompare.CheckedChanged += new System.EventHandler(this.chkCompare_CheckedChanged);
            // 
            // txtCompareHash
            // 
            this.txtCompareHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompareHash.Enabled = false;
            this.txtCompareHash.Location = new System.Drawing.Point(124, 288);
            this.txtCompareHash.Name = "txtCompareHash";
            this.txtCompareHash.Size = new System.Drawing.Size(731, 29);
            this.txtCompareHash.TabIndex = 12;
            this.txtCompareHash.TextChanged += new System.EventHandler(this.txtCompareHash_TextChanged);
            // 
            // lblCompareHash
            // 
            this.lblCompareHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompareHash.AutoSize = true;
            this.lblCompareHash.Enabled = false;
            this.lblCompareHash.Location = new System.Drawing.Point(59, 291);
            this.lblCompareHash.Name = "lblCompareHash";
            this.lblCompareHash.Size = new System.Drawing.Size(59, 22);
            this.lblCompareHash.TabIndex = 9;
            this.lblCompareHash.Text = "Hash:";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(408, 345);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 22);
            this.lblResult.TabIndex = 10;
            this.lblResult.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(750, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 443);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCompareHash);
            this.Controls.Add(this.txtCompareHash);
            this.Controls.Add(this.chkCompare);
            this.Controls.Add(this.txtInputHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 490);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Get Hash";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSHA512;
        private System.Windows.Forms.RadioButton rdoSHA384;
        private System.Windows.Forms.RadioButton rdoSHA256;
        private System.Windows.Forms.RadioButton rdoSHA1;
        private System.Windows.Forms.RadioButton rdoMD5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoChars;
        private System.Windows.Forms.TextBox txtCharas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputHash;
        private System.Windows.Forms.CheckBox chkCompare;
        private System.Windows.Forms.TextBox txtCompareHash;
        private System.Windows.Forms.Label lblCompareHash;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClose;
    }
}

