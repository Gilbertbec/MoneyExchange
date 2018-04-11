namespace MoneyExchange.BLL
{
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public class TWriteService<T> where T : R
    {
        public void WriteExchangeRateToFile(ICollection<T> collection)
        {
            string filePath = string.Empty;
            FileType fileType = GlobalConfig.fileType;
            switch (fileType)
            {
                case FileType.Text:
                    filePath = GlobalConfig.textFilePath;
                    break;
                case FileType.Xml:
                    filePath = GlobalConfig.xmlFilePath;
                    break;
            }
            WriteExchangeRateToFile(collection, fileType, filePath);
        }

        public void WriteExchangeRateToFile(ICollection<T> ExchangeRateList, FileType fileType, string filePath)
        {
            switch (fileType)
            {
                case FileType.Text:
                    IWriter<T> textFileWriter = new TextFileWriter<T>();
                    textFileWriter.WriteToFile(ExchangeRateList, filePath);
                    break;
                case FileType.Xml:
                    IWriter<T> xmlWriter = new XmlWriter<T>();
                    xmlWriter.WriteToFile(ExchangeRateList, filePath);
                    break;
            }
        }
    }
}
