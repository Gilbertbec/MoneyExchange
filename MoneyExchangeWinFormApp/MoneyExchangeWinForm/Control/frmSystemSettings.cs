namespace MoneyExchangeWinForm
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Configuration;
    using System.Windows.Forms;

    public partial class frmSystemSettings : Form
    {
        public frmSystemSettings()
        {
            InitializeComponent();
        }

        private void SystemInformationSettings_Load(object sender, EventArgs e)
        {
            cboFileType.DataSource = System.Enum.GetNames(typeof(FileType));
            cboFileType.Text = GlobalConfig.FileType.ToString();
            string textFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["textFilePath"];
            string xmlFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["xmlFilePath"];
            string csvFilePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["csvFilePath"];
            lblTextFilePath.Text = textFilePath;
            lblXmlFilePath.Text = xmlFilePath;
            lblCsvFilePath.Text = csvFilePath;
            txtTextFilePath.Text = ConfigurationManager.AppSettings["textFilePath"];
            txtXmlFilePath.Text = ConfigurationManager.AppSettings["xmlFilePath"];
            txtCsvFilePath.Text = ConfigurationManager.AppSettings["csvFilePath"];
            cboImplementationPlan.DataSource = System.Enum.GetNames(typeof(ImplementationPlan));
            cboImplementationPlan.Text = GlobalConfig.ImplementationPlan.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileType = cboFileType.Text;
            string textFilePath = txtTextFilePath.Text;
            string xmlFilePath = txtXmlFilePath.Text;
            string csvFilePath = txtXmlFilePath.Text;
            string implementationPlan = cboImplementationPlan.Text;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationManager.AppSettings.Set("FileType", fileType);
            ConfigurationManager.AppSettings.Set("textFilePath", textFilePath);
            ConfigurationManager.AppSettings.Set("xmlFilePath", xmlFilePath);
            ConfigurationManager.AppSettings.Set("csvFilePath", csvFilePath);
            ConfigurationManager.AppSettings.Set("ImplementationPlan", implementationPlan);
            GlobalConfig globalConfig = new GlobalConfig();
        }
    }
}
