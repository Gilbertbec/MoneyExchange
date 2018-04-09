namespace MoneyExchange.BLL
{
    using HelpLibrary;
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public class ExchangeRateWriteService
    {
        public void WriteExchangeRateToFile(List<ExchangeRate> ExchangeRateList)
        {
            string conditionString = GlobalConfig.fileType.ToString();
            ReflactorHelper.InvokeMethodValueByAttributeNameWithParameter("ExchangeRateReadService.WriteExchangeRateToFile", conditionString, "MoneyExchange.BLL.ExchangeRateWriteService", "MoneyExchange.BLL", ExchangeRateList);
        }

        [Condition("ExchangeRateReadService.WriteExchangeRateToFile", "Text")]
        public void WriteExchangeRateToTextFile(List<ExchangeRate> ExchangeRateList)
        {
            IExchangeRateWriter textFileWriter = new ExchangeRateTextFileWriter();
            textFileWriter.WriteToFile(ExchangeRateList, GlobalConfig.textFilePath);
        }

        [Condition("ExchangeRateReadService.WriteExchangeRateToFile", "Xml")]
        public void WriteExchangeRateToXmlFile(List<ExchangeRate> ExchangeRateList)
        {
            IExchangeRateWriter xmlWriter = new DAL.ExchangeRateXmlWriter();
            xmlWriter.WriteToFile(ExchangeRateList, GlobalConfig.xmlFilePath);
        }

        public void WriteExchangeRateToFile(List<ExchangeRate> ExchangeRateList, FileType fileType)
        {
            string filePath = string.Empty;
            switch (fileType)
            {
                case FileType.Text:
                    filePath = GlobalConfig.textFilePath;
                    break;
                case FileType.Xml:
                    filePath = GlobalConfig.xmlFilePath;
                    break;
            }
            WriteExchangeRateToFile(ExchangeRateList, fileType, filePath);
        }

        public void WriteExchangeRateToFile(List<ExchangeRate> ExchangeRateList, FileType fileType, string filePath)
        {
            switch (fileType)
            {
                case FileType.Text:
                    IExchangeRateWriter textFileWriter = new ExchangeRateTextFileWriter();
                    textFileWriter.WriteToFile(ExchangeRateList, filePath);
                    break;
                case FileType.Xml:
                    IExchangeRateWriter xmlWriter = new DAL.ExchangeRateXmlWriter();
                    xmlWriter.WriteToFile(ExchangeRateList, filePath);
                    break;
            }
        }
    }
}
