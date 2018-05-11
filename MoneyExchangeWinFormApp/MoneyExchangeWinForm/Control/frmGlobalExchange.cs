namespace MoneyExchangeWinForm
{
    using HelpLibrary;
    using MoneyExchange.BLL;
    using MoneyExchange.Data.Entities;
    using MoneyExchangeWinForm.Model;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class frmGlobalExchange : Form
    {
        GlobalExchangeModel Model = new GlobalExchangeModel();

        public frmGlobalExchange()
        {
            InitializeComponent();
        }

        private void GlobalExchange_Load(object sender, EventArgs e)
        {
            TReadService<R> exchangeRateReadService = new TReadService<R>();
            Model.ExchangeRateList = exchangeRateReadService.GetExchangeRateFromFile();

            BindcboSelectCurrency();
            rdoToTarget.Checked = true;
            lblFromSource.Text = string.Empty;
            lblToSource.Text = string.Empty;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (cboSelectCurrency.SelectedIndex == 0)
            {
                lblResult.Text = "Please select a kind of Currency";
                return;
            }

            if (cboTargetCurrency.SelectedIndex == 0)
            {
                lblResult.Text = "Please select a kind of Target Currency";
                return;
            }

            if (txtAmount.TextLength == 0)
            {
                lblResult.Text = "Please enter the amount";
                return;
            }

            Model.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

            if (rdoFromTarget.Checked)
            {
                lblResult.Text = string.Format($"{Model.Amount} {Model.TargetCurrency} = {Model.GetResult()} {Model.SourceCurrency}(s)");
            }
            else if (rdoToTarget.Checked)
            {
                lblResult.Text = string.Format($"{Model.Amount} {Model.SourceCurrency} = {Model.GetReverseResult()} {Model.TargetCurrency}(s)");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestetControls(this);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.VilidationForDecimal(sender, e);
        }

        private void cboSelectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = ((ComboBox)sender);
            if (comboBox.SelectedIndex == 0)
            { return; }

            Model.SourceCurrency = comboBox.Text;
            Model.SourceCurrencyRate = Convert.ToDecimal(comboBox.SelectedValue);
            DisplayInfo();
        }

        private void cboTargetCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = ((ComboBox)sender);
            if (comboBox.SelectedIndex == 0)
            { return; }

            Model.TargetCurrency = comboBox.Text;
            Model.TargetCurrencyRate = Convert.ToDecimal(comboBox.SelectedValue);
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            if (cboSelectCurrency.SelectedIndex == 0 || cboTargetCurrency.SelectedIndex == 0)
            {
                return;
            }
            var sourceRate = Model.SourceCurrencyRate;
            var targetRate = Model.TargetCurrencyRate;

            lblFromSource.Text = string.Format($"1 {Model.SourceCurrency} = {Model.ReverseCurrencyRate} {Model.TargetCurrency}(s)");
            lblToSource.Text = string.Format($"1 {Model.TargetCurrency} = {Model.CurrencyRate} {Model.SourceCurrency}(s)");
        }

        void BindcboSelectCurrency()
        {
            if (Model.ExchangeRateList == null)
            { return; }

            ((List<R>)Model.ExchangeRateList).Insert(0, new R(",Select a Currency..,1"));
            cboSelectCurrency.DataSource = Model.ExchangeRateList;
            cboSelectCurrency.DisplayMember = "CurrencyName";
            cboSelectCurrency.ValueMember = "Value";

            R[] rs = new R[Model.ExchangeRateList.Count];
            Array.Copy(((List<R>)Model.ExchangeRateList).ToArray(), rs, Model.ExchangeRateList.Count);

            cboTargetCurrency.DataSource = rs;
            cboTargetCurrency.DisplayMember = "CurrencyName";
            cboTargetCurrency.ValueMember = "Value";
        }

        void RestetControls(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is Label)
                {
                    if (((Label)item).Name != "lblTitle")
                    {
                        ((Label)item).Text = string.Empty;
                    }
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count == 0)
                    { return; }
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is GroupBox)
                {
                    RestetControls((GroupBox)item);
                }
            }
        }
    }
}
