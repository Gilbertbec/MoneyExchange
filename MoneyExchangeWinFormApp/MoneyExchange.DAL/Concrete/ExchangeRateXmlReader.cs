using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MoneyExchange.Data.Entities;

namespace MoneyExchange.DAL
{
    public class ExchangeRateXmlReader : IExchangeRateReader
    {
        List<ExchangeRate> exchangeRates;
        public List<ExchangeRate> ReadFromFile(string filePath)
        {
            XDocument doc = XDocument.Load(filePath);
            var exchangeRates = from xElement in doc.Descendants("Currency")
                        select new ExchangeRate
                        {
                            CountryName = xElement.Attribute("CountryName").Value,
                            CurrencyName = xElement.Element("CurrencyName").Value,
                            Value = Convert.ToDecimal(xElement.Element("Value").Value)
                        };
            return exchangeRates.ToList();
        }
    }
}
