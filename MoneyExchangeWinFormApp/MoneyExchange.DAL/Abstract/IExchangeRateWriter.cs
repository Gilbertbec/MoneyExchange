namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public interface IExchangeRateWriter
    {
        void WriteToFile(List<ExchangeRate> exchangeRateList, string filePath);
    }
}
