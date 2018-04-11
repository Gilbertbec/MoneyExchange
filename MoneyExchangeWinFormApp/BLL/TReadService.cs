namespace MoneyExchange.BLL
{
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public class TReadService<T> where T : R, new()
    {
        ICollection<T> Collection;

        string s = string.Empty;

        public ICollection<T> GetExchangeRateFromFile()
        {
            string path = string.Empty;
            FileType fileType = GlobalConfig.FileType;

            switch (fileType)
            {
                case FileType.Text:
                    path = GlobalConfig.TextFilePath;
                    break;
                case FileType.Xml:
                    path = GlobalConfig.XmlFilePath;
                    break;
            }
            Collection = GetExchangeRateFromFile(fileType, path);
            return Collection;
        }

        public ICollection<T> GetExchangeRateFromFile(FileType fileType, string filePath)
        {
            switch (fileType)
            {
                case FileType.Text:
                    IReader<T> txtFileReader = new TextFileReader<T>();
                    Collection = txtFileReader.ReadFromFile(filePath);
                    break;
                case FileType.Xml:
                    IReader<T> XmlReader = new XmlReader<T>();
                    Collection = XmlReader.ReadFromFile(filePath);
                    break;
            }
            return Collection;
        }
    }
}
