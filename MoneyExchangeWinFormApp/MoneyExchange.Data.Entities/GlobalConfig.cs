namespace MoneyExchange.Data.Entities
{
    using System;
    using System.Configuration;

    public class GlobalConfig
    {
        private static string strFileType = ConfigurationManager.AppSettings["FileType"];

        private static FileType fileType = (FileType)Enum.Parse(typeof(FileType), strFileType);

        private static string textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];

        private static string xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];

        private static string csvFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["csvFilePath"];

        private static string strImplementationPlan = ConfigurationManager.AppSettings["ImplementationPlan"];

        private static ImplementationPlan implementationPlan = (ImplementationPlan)Enum.Parse(typeof(ImplementationPlan), strImplementationPlan);

        public GlobalConfig()
        {
            strFileType = ConfigurationManager.AppSettings["FileType"];
            fileType = (FileType)Enum.Parse(typeof(FileType), strFileType);
            textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];
            xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];
            strImplementationPlan = ConfigurationManager.AppSettings["ImplementationPlan"];
            implementationPlan = (ImplementationPlan)Enum.Parse(typeof(ImplementationPlan), strImplementationPlan);
        }

        public static FileType FileType => fileType;

        public static string TextFilePath => textFilePath;

        public static string XmlFilePath => xmlFilePath;

        public static string CsvFilePath => csvFilePath;

        public static ImplementationPlan ImplementationPlan => implementationPlan;

        public static string GetFilePathByFileType(FileType fileType)
        {
            string filePath = string.Empty;
            switch (fileType)
            {
                case FileType.Text:
                    filePath = GlobalConfig.TextFilePath;
                    break;
                case FileType.Xml:
                    filePath = GlobalConfig.XmlFilePath;
                    break;
                case FileType.Csv:
                    filePath = GlobalConfig.CsvFilePath;
                    break;
            }
            return filePath;
        }
    }
}
