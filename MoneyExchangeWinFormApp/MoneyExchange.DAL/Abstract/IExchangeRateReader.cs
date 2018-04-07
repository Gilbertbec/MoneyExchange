namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public interface IExchangeRateReader
    {
        List<ExchangeRate> ReadFromFile(string filePath);
    }
}
