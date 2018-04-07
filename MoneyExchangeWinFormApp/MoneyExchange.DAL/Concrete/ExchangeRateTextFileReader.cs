namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;
    using System.IO;

    public class ExchangeRateTextFileReader : IExchangeRateReader
    {
        public List<ExchangeRate> ReadFromFile(string filePath)
        {
            List<ExchangeRate> exchangeRateList = new List<ExchangeRate>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ExchangeRate exchangeRate = new ExchangeRate(line);
                        exchangeRateList.Add(exchangeRate);
                    }
                }
            }
            return exchangeRateList;
        }
    }
}
