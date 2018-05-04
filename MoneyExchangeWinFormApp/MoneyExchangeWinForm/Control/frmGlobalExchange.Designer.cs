namespace MoneyExchangeWinForm
{
    partial class frmGlobalExchange
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToSource = new System.Windows.Forms.Label();
            this.lblFromSource = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFromTarget = new System.Windows.Forms.RadioButton();
            this.rdoToTarget = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectCurrency = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTargetCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Location = new System.Drawing.Point(286, 721);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exchange Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblResult.Location = new System.Drawing.Point(105, 48);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(819, 622);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(192, 38);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(537, 622);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 38);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(262, 622);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(192, 38);
            this.btnExchange.TabIndex = 16;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToSource);
            this.groupBox2.Controls.Add(this.lblFromSource);
            this.groupBox2.Location = new System.Drawing.Point(666, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 181);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency Information:";
            // 
            // lblToSource
            // 
            this.lblToSource.AutoSize = true;
            this.lblToSource.Location = new System.Drawing.Point(50, 101);
            this.lblToSource.Name = "lblToSource";
            this.lblToSource.Size = new System.Drawing.Size(121, 25);
            this.lblToSource.TabIndex = 1;
            this.lblToSource.Text = "lblToTarget";
            // 
            // lblFromSource
            // 
            this.lblFromSource.AutoSize = true;
            this.lblFromSource.Location = new System.Drawing.Point(50, 44);
            this.lblFromSource.Name = "lblFromSource";
            this.lblFromSource.Size = new System.Drawing.Size(151, 25);
            this.lblFromSource.TabIndex = 0;
            this.lblFromSource.Text = "lblFromSource";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFromTarget);
            this.groupBox1.Controls.Add(this.rdoToTarget);
            this.groupBox1.Location = new System.Drawing.Point(298, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exchange:";
            // 
            // rdoFromTarget
            // 
            this.rdoFromTarget.AutoSize = true;
            this.rdoFromTarget.Location = new System.Drawing.Point(61, 99);
            this.rdoFromTarget.Name = "rdoFromTarget";
            this.rdoFromTarget.Size = new System.Drawing.Size(160, 29);
            this.rdoFromTarget.TabIndex = 0;
            this.rdoFromTarget.TabStop = true;
            this.rdoFromTarget.Text = "From Target";
            this.rdoFromTarget.UseVisualStyleBackColor = true;
            // 
            // rdoToTarget
            // 
            this.rdoToTarget.AutoSize = true;
            this.rdoToTarget.Location = new System.Drawing.Point(61, 44);
            this.rdoToTarget.Name = "rdoToTarget";
            this.rdoToTarget.Size = new System.Drawing.Size(136, 29);
            this.rdoToTarget.TabIndex = 0;
            this.rdoToTarget.TabStop = true;
            this.rdoToTarget.Text = "To Target";
            this.rdoToTarget.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(808, 251);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 31);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount:";
            // 
            // cboSelectCurrency
            // 
            this.cboSelectCurrency.FormattingEnabled = true;
            this.cboSelectCurrency.Location = new System.Drawing.Point(298, 251);
            this.cboSelectCurrency.Name = "cboSelectCurrency";
            this.cboSelectCurrency.Size = new System.Drawing.Size(300, 33);
            this.cboSelectCurrency.TabIndex = 9;
            this.cboSelectCurrency.SelectedIndexChanged += new System.EventHandler(this.cboSelectCurrency_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(313, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(698, 71);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Global Money Exchange";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Source Currency";
            // 
            // cboTargetCurrency
            // 
            this.cboTargetCurrency.FormattingEnabled = true;
            this.cboTargetCurrency.Location = new System.Drawing.Point(298, 310);
            this.cboTargetCurrency.Name = "cboTargetCurrency";
            this.cboTargetCurrency.Size = new System.Drawing.Size(300, 33);
            this.cboTargetCurrency.TabIndex = 9;
            this.cboTargetCurrency.SelectedIndexChanged += new System.EventHandler(this.cboTargetCurrency_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Target Currency";
            // 
            // frmGlobalExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 951);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTargetCurrency);
            this.Controls.Add(this.cboSelectCurrency);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmGlobalExchange";
            this.Text = "GlobalExchange";
            this.Load += new System.EventHandler(this.GlobalExchange_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToSource;
        private System.Windows.Forms.Label lblFromSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFromTarget;
        private System.Windows.Forms.RadioButton rdoToTarget;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSelectCurrency;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTargetCurrency;
        private System.Windows.Forms.Label label3;
    }
}