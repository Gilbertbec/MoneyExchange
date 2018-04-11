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

        public static ImplementationPlan ImplementationPlan => implementationPlan;
    }
}
