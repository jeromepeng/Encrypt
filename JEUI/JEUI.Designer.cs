namespace JEUI
{
    partial class JEUI
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(500, 11);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 21);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncryptClick);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(500, 38);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 21);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecryptClick);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 38);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(195, 291);
            this.rtbInput.TabIndex = 2;
            this.rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(253, 38);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(195, 291);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 350);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(195, 21);
            this.tbPassword.TabIndex = 4;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 8);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(29, 12);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "输入";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(250, 8);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(29, 12);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "输出";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 335);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(29, 12);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "密码";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(500, 91);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 21);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImportClick);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(500, 118);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(75, 21);
            this.btnEncryptFile.TabIndex = 10;
            this.btnEncryptFile.Text = "加密文件";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFileClick);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(500, 145);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(75, 21);
            this.btnDecryptFile.TabIndex = 11;
            this.btnDecryptFile.Text = "解密文件";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFileClick);
            // 
            // JEUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 379);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "JEUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
    }
}

