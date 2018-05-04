using MoneyExchange.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeWinForm.Model
{
    class GlobalExchangeModel
    {
        public string SourceCurrency { get; set; }

        public decimal SourceCurrencyRate { get; set; }

        public string TargetCurrency { get; set; }

        public decimal TargetCurrencyRate { get; set; }

        public decimal CurrencyRate => Math.Round(SourceCurrencyRate/ TargetCurrencyRate, 4);

        public decimal ReverseCurrencyRate => Math.Round(TargetCurrencyRate / SourceCurrencyRate, 4);

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
