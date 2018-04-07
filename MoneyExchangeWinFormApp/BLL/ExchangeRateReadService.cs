namespace MoneyExchange.BLL
{
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public class ExchangeRateReadService
    {
        List<ExchangeRate> ExchangeRateList;

        public List<ExchangeRate> GetExchangeRateFromFile(FileType fileType)
        {
            string path = string.Empty;
            switch (fileType)
            {
                case FileType.Text:
                    path = GlobalConfig.textFilePath;
                    break;
                case FileType.Xml:
                    path = GlobalConfig.xmlFilePath;
                    break;
            }
            ExchangeRateList = GetExchangeRateFromFile(fileType, path);
            return ExchangeRateList;
        }

        public List<ExchangeRate> GetExchangeRateFromFile(FileType fileType, string filePath)
        {
            switch (fileType)
            {
                case FileType.Text:
                    IExchangeRateReader txtFileReader = new ExchangeRateTextFileReader();
                    ExchangeRateList = txtFileReader.ReadFromFile(filePath);
                    break;
                case FileType.Xml:
                    IExchangeRateReader XmlReader = new DAL.ExchangeRateXmlReader();
                    ExchangeRateList = XmlReader.ReadFromFile(filePath);
                    break;
            }
            return ExchangeRateList;
        }
    }
}
