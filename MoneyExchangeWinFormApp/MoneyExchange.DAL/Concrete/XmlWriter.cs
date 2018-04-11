namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class XmlWriter<T> : IWriter<T> where T : R
    {
        public void WriteToFile(ICollection<T> collection, string filePath)
        {
            XElement xml = new XElement("Currencies",
                        from er in collection
                        select new XElement("Currency",
                            new XAttribute("CountryName", er.CountryName),
                            new XElement("CurrencyName", er.CurrencyName),
                            new XElement("Value", er.Value)));

            xml.Save(filePath);
        }
    }
}
