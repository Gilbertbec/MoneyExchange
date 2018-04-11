namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class XmlReader<T> : IReader<T> where T : R, new()
    {
        List<T> List;

        public ICollection<T> ReadFromFile(string filePath)
        {
            XDocument doc = XDocument.Load(filePath);
            var query = from xElement in doc.Descendants("Currency")
                        select new T
                        {
                            CountryName = xElement.Attribute("CountryName").Value,
                            CurrencyName = xElement.Element("CurrencyName").Value,
                            Value = Convert.ToDecimal(xElement.Element("Value").Value)
                        };
            return List = query.ToList();
        }
    }
}
