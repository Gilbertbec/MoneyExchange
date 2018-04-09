namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class ExchangeRateXmlReader : IExchangeRateReader
    {
        List<ExchangeRate> exchangeRates;

        public List<ExchangeRate> ReadFromFile(string filePath)
        {
            XDocument doc = XDocument.Load(filePath);
            var query = from xElement in doc.Descendants("Currency")
                        select new ExchangeRate
                        {
                            CountryName = xElement.Attribute("CountryName").Value,
                            CurrencyName = xElement.Element("CurrencyName").Value,
                            Value = Convert.ToDecimal(xElement.Element("Value").Value)
                        };
            return exchangeRates = query.ToList();
        }
    }
}
