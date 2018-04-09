namespace MoneyExchangeWinFormApp
{
    using HelpLibrary;
    using MoneyExchange.BLL;
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class frmChange : Form
    {
        string Currency;

        decimal CurrencyRate;

        decimal ReverseCurrencyRate;

        List<ExchangeRate> ExchangeRateList;

        public frmChange()
        {
            InitializeComponent();
        }

        //ExchangeRateReadService exchangeRateReadService { get; set; }
        private void frmChange_Load(object sender, EventArgs e)
        {
            ExchangeRateReadService exchangeRateReadService = new ExchangeRateReadService();
            ExchangeRateList = exchangeRateReadService.GetExchangeRateFromFile(GlobalConfig.fileType);

            BindcboSelectCurrency();
            rdoToDollar.Checked = true;
            lblFromDollar.Text = string.Empty;
            lblToDollar.Text = string.Empty;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (cboSelectCurrency.SelectedIndex == 0)
            {
                lblResult.Text = "Please select a kind of Currency";
                return;
            }

            if (txtAmount.TextLength == 0)
            {
                lblResult.Text = "Please enter the amount";
                return;
            }

            decimal amount = Convert.ToDecimal(txtAmount.Text.Trim());

            decimal result;
            if (rdoFromDollar.Checked)
            {
                result = amount * CurrencyRate;
                lblResult.Text = string.Format($"{amount} US Dollar = {result} {Currency}(s)");
            }
            else if (rdoToDollar.Checked)
            {
                result = amount * ReverseCurrencyRate;
                lblResult.Text = string.Format($"{amount} {Currency} = {result} US Dollar(s)");
            }
        }

        private void cboSelectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = ((ComboBox)sender);
            if (comboBox.SelectedIndex == 0)
            { return; }
            Currency = comboBox.Text;
            CurrencyRate = Convert.ToDecimal(comboBox.SelectedValue);
            lblFromDollar.Text = string.Format($"1 US Dollar = {CurrencyRate} {Currency}(s)");

            decimal decimalValue = Convert.ToDecimal(CurrencyRate);
            ReverseCurrencyRate = Math.Round(1 / decimalValue, 4);
            lblToDollar.Text = string.Format($"1 {Currency} = {ReverseCurrencyRate} US Dollar(s)");
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

        void BindcboSelectCurrency()
        {
            if (ExchangeRateList == null)
            { return; }

            ExchangeRateList.Insert(0, new ExchangeRate(",Select a Currency..,1"));
            cboSelectCurrency.DataSource = ExchangeRateList;
            cboSelectCurrency.DisplayMember = "CurrencyName";
            cboSelectCurrency.ValueMember = "Value";
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
