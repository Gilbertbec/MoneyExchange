namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;
    using System.IO;

    public class ExchangeRateTextFileWriter : IExchangeRateWriter
    {
        public void WriteToFile(List<ExchangeRate> exchangeRateList, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                exchangeRateList.ForEach(x =>
                {
                    string line = string.Format($"{x.CountryName},{x.CurrencyName},{x.Value}");
                    sw.WriteLine(line);
                });
            }
        }
    }
}
