namespace MD5
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaltKey = new System.Windows.Forms.TextBox();
            this.txtVIKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEncryptText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PasswordHash";
            // 
            // txtPasswordHash
            // 
            this.txtPasswordHash.Location = new System.Drawing.Point(93, 20);
            this.txtPasswordHash.Name = "txtPasswordHash";
            this.txtPasswordHash.Size = new System.Drawing.Size(134, 20);
            this.txtPasswordHash.TabIndex = 1;
            this.txtPasswordHash.Text = "P@@Sw0rd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SaltKey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "VIKey";
            // 
            // txtSaltKey
            // 
            this.txtSaltKey.Location = new System.Drawing.Point(93, 44);
            this.txtSaltKey.Name = "txtSaltKey";
            this.txtSaltKey.Size = new System.Drawing.Size(134, 20);
            this.txtSaltKey.TabIndex = 2;
            this.txtSaltKey.Text = "S@LT&KEY";
            // 
            // txtVIKey
            // 
            this.txtVIKey.Location = new System.Drawing.Point(93, 68);
            this.txtVIKey.Name = "txtVIKey";
            this.txtVIKey.Size = new System.Drawing.Size(134, 20);
            this.txtVIKey.TabIndex = 3;
            this.txtVIKey.Text = "@1B2c3D4e5F6g7H8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(105, 132);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(243, 20);
            this.txtText.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Encrypted Text";
            // 
            // txtEncryptText
            // 
            this.txtEncryptText.Location = new System.Drawing.Point(105, 175);
            this.txtEncryptText.Name = "txtEncryptText";
            this.txtEncryptText.Size = new System.Drawing.Size(243, 20);
            this.txtEncryptText.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPasswordHash);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVIKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSaltKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // btEncrypt
            // 
            this.btEncrypt.Location = new System.Drawing.Point(354, 130);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(74, 23);
            this.btEncrypt.TabIndex = 4;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(354, 174);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(74, 23);
            this.btDecrypt.TabIndex = 6;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(354, 203);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(74, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEncryptText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmMain";
            this.Text = "FormMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaltKey;
        private System.Windows.Forms.TextBox txtVIKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEncryptText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btClear;
    }
}

