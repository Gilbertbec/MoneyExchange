namespace MoneyExchange.Data.Entities
{
    using System;
    using System.Text;

    public class ExchangeRate
    {
        public ExchangeRate()
        {
        }

        public ExchangeRate(string formatedstrExchangeRate)//the fomatedStr should like [CountryName],[CurrencyName],[Value],
        {
            var exchangeRateByArray = formatedstrExchangeRate.Split(',');
            CountryName = exchangeRateByArray[0];
            CurrencyName = exchangeRateByArray[1];
            Value = Convert.ToDecimal(exchangeRateByArray[2]);
        }

        public string CountryName { get; set; }

        public string CurrencyName { get; set; }

        public decimal Value { get; set; }

        public override string ToString()
        {
            StringBuilder sbResult = new StringBuilder();
            sbResult = sbResult.Append(CountryName)
                .Append(",").Append(CurrencyName)
                .Append(",").Append(Value);
            return sbResult.ToString();
        }
    }
}
