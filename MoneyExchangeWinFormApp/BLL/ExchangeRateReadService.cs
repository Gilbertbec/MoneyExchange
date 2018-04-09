namespace MoneyExchange.BLL
{
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;
    using HelpLibrary;
    using System.Windows.Forms;

    public class ExchangeRateReadService
    {
        List<ExchangeRate> ExchangeRateList;
        string s = string.Empty;

        public List<ExchangeRate> GetExchangeRateFromFile()
        {
            string conditionString = GlobalConfig.fileType.ToString();
            List<ExchangeRate> exchangeRateList = ReflactorHelper.InvokeMethodValueByAttributeNameForExchangeRateList("ExchangeRateReadService.GetExchangeRateFromFile", conditionString, "MoneyExchange.BLL.ExchangeRateReadService", "MoneyExchange.BLL");
            return exchangeRateList;
        }

        [Condition("ExchangeRateReadService.GetExchangeRateFromFile", "Text")]
        public List<ExchangeRate> GetExchangeRateFromTextFile()
        {
            IExchangeRateReader txtFileReader = new ExchangeRateTextFileReader();
            ExchangeRateList = txtFileReader.ReadFromFile(GlobalConfig.textFilePath);
            return ExchangeRateList;
        }

        [Condition("ExchangeRateReadService.GetExchangeRateFromFile", "Xml")]
        public List<ExchangeRate> GetExchangeRateFromXmlFile()
        {
            IExchangeRateReader txtFileReader = new ExchangeRateXmlReader();
            ExchangeRateList = txtFileReader.ReadFromFile(GlobalConfig.xmlFilePath);
            return ExchangeRateList;
        }

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
                    IExchangeRateReader XmlReader = new ExchangeRateXmlReader();
                    ExchangeRateList = XmlReader.ReadFromFile(filePath);
                    break;
            }
            return ExchangeRateList;
        }
    }
}