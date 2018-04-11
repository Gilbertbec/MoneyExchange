namespace MoneyExchangeWinForm.Model
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;

    class MoneyChangeModel
    {
        public string Currency { get; set; }

        public decimal CurrencyRate { get; set; }

        public decimal ReverseCurrencyRate => Math.Round(1 / CurrencyRate, 4);

        public decimal Amount { get; set; }

        public ICollection<R> ExchangeRateList { get; set; }

        public decimal GetResult()
        {
            return CurrencyRate * Amount;
        }

        public decimal GetReverseResult()
        {
            return ReverseCurrencyRate * Amount;
        }
    }
}
