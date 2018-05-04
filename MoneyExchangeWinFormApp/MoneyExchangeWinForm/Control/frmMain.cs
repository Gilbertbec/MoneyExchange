namespace MoneyExchangeWinForm
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class frmMain : Form
    {
        public static R[] r = new R[GlobalConfig.SizeOfArray];

        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdmin<R> frmAdmin = new frmAdmin<R>();
            frmAdmin.MdiParent = this;
            frmAdmin.StartPosition = FormStartPosition.CenterScreen;
            frmAdmin.Show();
        }

        private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMoneyChange frmChange = new frmMoneyChange();
            frmChange.MdiParent = this;
            frmChange.StartPosition = FormStartPosition.CenterScreen;
            frmChange.Show();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSystemSettings frmSystemSettings = new frmSystemSettings();
            frmSystemSettings.MdiParent = this;
            frmSystemSettings.StartPosition = FormStartPosition.CenterScreen;
            frmSystemSettings.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGlobalExchange frmGlobalExchange = new frmGlobalExchange();
            frmGlobalExchange.MdiParent = this;
            frmGlobalExchange.StartPosition = FormStartPosition.CenterScreen;
            frmGlobalExchange.Show();
        }
    }
}
