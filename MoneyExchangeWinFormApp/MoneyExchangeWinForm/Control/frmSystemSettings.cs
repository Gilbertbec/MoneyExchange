using MoneyExchange.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyExchangeWinFormApp
{
    public partial class frmSystemSettings : Form
    {
        public frmSystemSettings()
        {
            InitializeComponent();
        }

        private void SystemInformationSettings_Load(object sender, EventArgs e)
        {
            cboFileType.DataSource = System.Enum.GetNames(typeof(FileType));
            cboFileType.Text = GlobalConfig.fileType.ToString();
            string textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];
            string xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];
            lblTextFilePath.Text = textFilePath;
            lblXmlFilePath.Text = xmlFilePath;
            txtTextFilePath.Text = ConfigurationManager.AppSettings["textFilePath"];
            txtXmlFilePath.Text = ConfigurationManager.AppSettings["xmlFilePath"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileType = cboFileType.Text;
            string textFilePath = txtTextFilePath.Text;
            string xmlFilePath = txtXmlFilePath.Text;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FileType"].Value = fileType;
            config.AppSettings.Settings["textFilePath"].Value = textFilePath;
            config.AppSettings.Settings["xmlFilePath"].Value = xmlFilePath;

            ConfigurationManager.AppSettings.Set("FileType", fileType);
            ConfigurationManager.AppSettings.Set("textFilePath", textFilePath);
            ConfigurationManager.AppSettings.Set("xmlFilePath", xmlFilePath);
            config.Save(ConfigurationSaveMode.Modified);
            GlobalConfig globalConfig = new GlobalConfig();
        }
    }
}
