namespace MoneyExchange.BLL
{
    using MoneyExchange.DAL;
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public class TWriteService<T> where T : R
    {
        public void WriteExchangeRateToFile(ICollection<T> collection)
        {
            FileType fileType = GlobalConfig.FileType;
            string filePath = GlobalConfig.GetFilePathByFileType(fileType);
            WriteExchangeRateToFile(collection, fileType, filePath);
        }

        public void WriteExchangeRateToFile(ICollection<T> collection, FileType fileType, string filePath)
        {
            switch (fileType)
            {
                case FileType.Csv:
                case FileType.Text:
                    IWriter<T> textFileWriter = new TextFileWriter<T>();
                    textFileWriter.WriteToFile(collection, filePath);
                    break;
                case FileType.Xml:
                    IWriter<T> xmlWriter = new XmlWriter<T>();
                    xmlWriter.WriteToFile(collection, filePath);
                    break;
            }
        }
    }
}
