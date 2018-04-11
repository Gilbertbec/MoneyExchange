using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MoneyExchange.Data.Entities;

namespace MoneyExchange.DAL
{
    public class XmlWriter<T>: IWriter<T> where T : R
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
