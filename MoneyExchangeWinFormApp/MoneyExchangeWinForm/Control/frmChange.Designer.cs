namespace MoneyExchangeWinForm
{
	partial class frmMoneyChange
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboSelectCurrency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFromDollar = new System.Windows.Forms.RadioButton();
            this.rdoToDollar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToDollar = new System.Windows.Forms.Label();
            this.lblFromDollar = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(324, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(504, 71);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Money Exchange";
            // 
            // cboSelectCurrency
            // 
            this.cboSelectCurrency.FormattingEnabled = true;
            this.cboSelectCurrency.Location = new System.Drawing.Point(149, 153);
            this.cboSelectCurrency.Name = "cboSelectCurrency";
            this.cboSelectCurrency.Size = new System.Drawing.Size(300, 33);
            this.cboSelectCurrency.TabIndex = 1;
            this.cboSelectCurrency.SelectedIndexChanged += new System.EventHandler(this.cboSelectCurrency_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(727, 153);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 31);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFromDollar);
            this.groupBox1.Controls.Add(this.rdoToDollar);
            this.groupBox1.Location = new System.Drawing.Point(149, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exchange:";
            // 
            // rdoFromDollar
            // 
            this.rdoFromDollar.AutoSize = true;
            this.rdoFromDollar.Location = new System.Drawing.Point(61, 99);
            this.rdoFromDollar.Name = "rdoFromDollar";
            this.rdoFromDollar.Size = new System.Drawing.Size(154, 29);
            this.rdoFromDollar.TabIndex = 0;
            this.rdoFromDollar.TabStop = true;
            this.rdoFromDollar.Text = "From Dollar";
            this.rdoFromDollar.UseVisualStyleBackColor = true;
            // 
            // rdoToDollar
            // 
            this.rdoToDollar.AutoSize = true;
            this.rdoToDollar.Location = new System.Drawing.Point(61, 44);
            this.rdoToDollar.Name = "rdoToDollar";
            this.rdoToDollar.Size = new System.Drawing.Size(130, 29);
            this.rdoToDollar.TabIndex = 0;
            this.rdoToDollar.TabStop = true;
            this.rdoToDollar.Text = "To Dollar";
            this.rdoToDollar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToDollar);
            this.groupBox2.Controls.Add(this.lblFromDollar);
            this.groupBox2.Location = new System.Drawing.Point(629, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency Information:";
            // 
            // lblToDollar
            // 
            this.lblToDollar.AutoSize = true;
            this.lblToDollar.Location = new System.Drawing.Point(50, 101);
            this.lblToDollar.Name = "lblToDollar";
            this.lblToDollar.Size = new System.Drawing.Size(115, 25);
            this.lblToDollar.TabIndex = 1;
            this.lblToDollar.Text = "lblToDollar";
            // 
            // lblFromDollar
            // 
            this.lblFromDollar.AutoSize = true;
            this.lblFromDollar.Location = new System.Drawing.Point(50, 44);
            this.lblFromDollar.Name = "lblFromDollar";
            this.lblFromDollar.Size = new System.Drawing.Size(139, 25);
            this.lblFromDollar.TabIndex = 0;
            this.lblFromDollar.Text = "lblFromDollar";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(225, 599);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(192, 38);
            this.btnExchange.TabIndex = 6;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(500, 599);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(782, 599);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(192, 38);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Location = new System.Drawing.Point(249, 698);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 100);
            this.groupBox3.TabIndex = 7;
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
            // frmMoneyChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 829);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSelectCurrency);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMoneyChange";
            this.Text = "Money Exchange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ComboBox cboSelectCurrency;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoFromDollar;
		private System.Windows.Forms.RadioButton rdoToDollar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblToDollar;
		private System.Windows.Forms.Label lblFromDollar;
		private System.Windows.Forms.Button btnExchange;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblResult;
	}
}

