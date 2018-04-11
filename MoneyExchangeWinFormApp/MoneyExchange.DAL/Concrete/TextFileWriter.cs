namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;
    using System.IO;

    public class TextFileWriter<T> : IWriter<T> where T : R
    {
        public void WriteToFile(ICollection<T> collection, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var item in collection)
                {
                    var x = item as R;
                    string line = string.Format($"{x.CountryName},{x.CurrencyName},{x.Value}");
                    sw.WriteLine(line);
                }
            }
        }
    }
}
