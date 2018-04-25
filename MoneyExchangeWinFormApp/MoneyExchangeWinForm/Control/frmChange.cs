namespace MoneyExchangeWinForm
{
    using HelpLibrary;
    using MoneyExchange.BLL;
    using MoneyExchange.Data.Entities;
    using MoneyExchangeWinForm.Model;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class frmMoneyChange : Form
    {
        MoneyChangeModel McModel = new MoneyChangeModel();

        public frmMoneyChange()
        {
            InitializeComponent();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            TReadService<R> exchangeRateReadService = new TReadService<R>();
            McModel.ExchangeRateList = exchangeRateReadService.GetExchangeRateFromFile();

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

            McModel.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

            if (rdoFromDollar.Checked)
            {
                lblResult.Text = string.Format($"{McModel.Amount} US Dollar = {McModel.GetResult()} {McModel.Currency}(s)");
            }
            else if (rdoToDollar.Checked)
            {
                lblResult.Text = string.Format($"{McModel.Amount} {McModel.Currency} = {McModel.GetReverseResult()} US Dollar(s)");
            }
        }

        private void cboSelectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = ((ComboBox)sender);
            if (comboBox.SelectedIndex == 0)
            { return; }

            McModel.Currency = comboBox.Text;
            McModel.CurrencyRate = Convert.ToDecimal(comboBox.SelectedValue);
            lblFromDollar.Text = string.Format($"1 US Dollar = {McModel.CurrencyRate} {McModel.Currency}(s)");
            lblToDollar.Text = string.Format($"1 {McModel.Currency} = {McModel.ReverseCurrencyRate} US Dollar(s)");
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
            if (McModel.ExchangeRateList == null)
            { return; }

            ((List<R>)McModel.ExchangeRateList).Insert(0, new R(",Select a Currency..,1"));
            cboSelectCurrency.DataSource = McModel.ExchangeRateList;
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
