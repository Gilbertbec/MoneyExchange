using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyExchangeWinFormApp
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmAdmin frmAdmin = new frmAdmin();
			frmAdmin.MdiParent = this;
			frmAdmin.StartPosition = FormStartPosition.CenterParent;
			frmAdmin.Show();
		}

		private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmChange frmChange = new frmChange();
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
    }
}
