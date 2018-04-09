using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace MoneyExchange.Data.Entities
{
	public class GlobalConfig
	{
        public static string textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];
        public static string xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];
        public static string s = ConfigurationManager.AppSettings["FileType"];
        public static FileType fileType = (FileType)Enum.Parse(typeof(FileType), s);

        public GlobalConfig()
        {
            textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];
            xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];
            s = ConfigurationManager.AppSettings["FileType"];
            fileType = (FileType)Enum.Parse(typeof(FileType), s);
        }
    }
}
