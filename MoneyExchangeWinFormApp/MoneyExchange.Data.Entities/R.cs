namespace MoneyExchange.Data.Entities
{
    public class R : ExchangeRate
    {
        public R() :
            base()
        { }

        public R(string formatedstrExchangeRate) ://the fomatedStr should like [CountryName],[CurrencyName],[Value]
            base(formatedstrExchangeRate)
        {
        }
    }
}
