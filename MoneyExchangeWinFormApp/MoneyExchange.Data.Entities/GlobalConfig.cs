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
        public static FileType fileType = FileType.Xml;
        //public static string s =  ConfigurationManager.AppSettings["FileType"];
        //System.Windows.Forms.MessageBox.Show("s");
        //public static int i = Convert.ToInt32(s);
        //public static FileType ft = (FileType)i;
        //public static FileType fileType = ft;
        //public static FileType fileType = (FileType)Convert.ToInt32(ConfigurationManager.AppSettings["FileType"]);
    }
}
