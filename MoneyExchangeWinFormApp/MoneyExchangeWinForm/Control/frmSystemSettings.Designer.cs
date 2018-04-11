namespace MoneyExchangeWinForm
{
    partial class frmSystemSettings
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
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.txtXmlFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTextFilePath = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXmlFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileType:";
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Location = new System.Drawing.Point(193, 62);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(216, 33);
            this.cboFileType.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "textFilePath:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "xmlFilePath:";
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Location = new System.Drawing.Point(193, 151);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(666, 31);
            this.txtTextFilePath.TabIndex = 5;
            // 
            // txtXmlFilePath
            // 
            this.txtXmlFilePath.Location = new System.Drawing.Point(193, 241);
            this.txtXmlFilePath.Name = "txtXmlFilePath";
            this.txtXmlFilePath.Size = new System.Drawing.Size(666, 31);
            this.txtXmlFilePath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "textFileFullPath:";
            // 
            // lblTextFilePath
            // 
            this.lblTextFilePath.AutoSize = true;
            this.lblTextFilePath.Location = new System.Drawing.Point(188, 112);
            this.lblTextFilePath.Name = "lblTextFilePath";
            this.lblTextFilePath.Size = new System.Drawing.Size(167, 25);
            this.lblTextFilePath.TabIndex = 7;
            this.lblTextFilePath.Text = "textFileFullPath:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "xmlFileFullPath:";
            // 
            // lblXmlFilePath
            // 
            this.lblXmlFilePath.AutoSize = true;
            this.lblXmlFilePath.Location = new System.Drawing.Point(189, 200);
            this.lblXmlFilePath.Name = "lblXmlFilePath";
            this.lblXmlFilePath.Size = new System.Drawing.Size(165, 25);
            this.lblXmlFilePath.TabIndex = 8;
            this.lblXmlFilePath.Text = "xmlFileFullPath:";
            // 
            // frmSystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 431);
            this.Controls.Add(this.lblXmlFilePath);
            this.Controls.Add(this.lblTextFilePath);
            this.Controls.Add(this.txtXmlFilePath);
            this.Controls.Add(this.txtTextFilePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboFileType);
            this.Controls.Add(this.label1);
            this.Name = "frmSystemSettings";
            this.Text = "SystemSettings";
            this.Load += new System.EventHandler(this.SystemInformationSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.TextBox txtXmlFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTextFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblXmlFilePath;
    }
}