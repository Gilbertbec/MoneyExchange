namespace MoneyExchangeWinFormApp
{
    using HelpLibrary;
    using MoneyExchange.BLL;
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frmAdmin : Form
    {
        int CurrentIndex = 0;

        State CurrentState;

        List<ExchangeRate> ExchangeRateList;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            ExchangeRateReadService exchangeRateReadService = new ExchangeRateReadService();
            ExchangeRateList = exchangeRateReadService.GetExchangeRateFromFile();
            UpdateState(State.Loaded);
            lblPosition.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            CurrentIndex = ExchangeRateList.Count;
            lblPosition.Text = string.Format($"Current index is {CurrentIndex}");
            UpdateState(State.Adding);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExchangeRate exchangeRate = GetExchangeRateFromUI();
            if (exchangeRate == null)
            { return; }

            if (CurrentState == State.Adding)
            {
                ExchangeRateList.Add(exchangeRate);
            }
            else if (CurrentState == State.Editing)
            {
                ExchangeRateList[CurrentIndex] = exchangeRate;
            }
            CurrentIndex = ExchangeRateList.Count - 1;
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Saved);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }

            ExchangeRateList.RemoveAt(CurrentIndex);
            Reset();

            CurrentIndex = CurrentIndex > 0 ? CurrentIndex -= 1 : CurrentIndex;

            UpdateState(State.Deleted);

            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            DisplayToUI(ExchangeRateList[CurrentIndex]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Editing);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            CurrentIndex = 0;
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Browsing);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            CurrentIndex = ExchangeRateList.Count() - 1;
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Browsing);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            CurrentIndex = CurrentIndex >= 1 ? CurrentIndex -= 1 : CurrentIndex;
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Browsing);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }

            if (CurrentIndex == ExchangeRateList.Count())//when user just clicked Add button
            {
                return;
            }

            if (CurrentIndex <= ExchangeRateList.Count() - 2)
            {
                CurrentIndex += 1;
            }
            DisplayToUIAndUpdateState(ExchangeRateList[CurrentIndex], State.Browsing);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExchangeRateWriteService exchangeRateWriteService = new ExchangeRateWriteService();
            exchangeRateWriteService.WriteExchangeRateToFile(ExchangeRateList);
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.VilidationForDecimal(sender, e);
        }

        ExchangeRate GetExchangeRateFromUI()
        {
            if (!(txtName.IsNotEmpty() && txtValue.IsNotEmpty() && txtCountryName.IsNotEmpty()))
            { return null; }
            string currencyName = txtName.Text.Trim();
            decimal value = Convert.ToDecimal(txtValue.Text.Trim());
            string countryName = txtCountryName.Text.Trim();
            ExchangeRate exchangeRate = new ExchangeRate()
            {
                CountryName = countryName,
                CurrencyName = currencyName,
                Value = value
            };
            return exchangeRate;
        }

        void DisplayToUI(ExchangeRate exchangeRate)
        {
            if (ExchangeRateList.IsNullOrEmpty())
            { return; }
            txtName.Text = exchangeRate.CurrencyName;
            txtCountryName.Text = exchangeRate.CountryName;
            txtValue.Text = exchangeRate.Value.ToString();
            lblPosition.Text = string.Format($"Current index is {CurrentIndex}");
        }

        void DisplayToUIAndUpdateState(ExchangeRate exchangeRate, State state)
        {
            DisplayToUI(exchangeRate);
            UpdateState(state);
        }

        void Reset()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            lblPosition.Text = string.Empty;
            UpdateState(State.Loaded);
        }

        void UpdateState(State state)
        {
            CurrentState = state;
            switch (CurrentState)
            {
                case State.Adding:
                case State.Editing:
                    btnSave.Enabled = txtCountryName.Enabled = txtName.Enabled = txtValue.Enabled = true;
                    break;
                case State.Loaded:
                case State.Saved:
                case State.Deleted:
                case State.Browsing:
                    btnSave.Enabled = txtCountryName.Enabled = txtName.Enabled = txtValue.Enabled = false;
                    break;
            }
        }
    }
}
