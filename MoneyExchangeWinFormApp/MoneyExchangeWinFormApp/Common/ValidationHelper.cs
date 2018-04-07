using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyExchangeWinFormApp
{
    public static class ValidationHelper
    {
        public static void VilidationForDecimal(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.')) ||
                (((TextBox)sender).Text.Trim().Contains('.')) && (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validation
        /// </summary>
        /// <returns></returns>
        #region
        [Obsolete("Use Extension method: IsNotEmpty in ExtentionHelper instead")]
        public static bool ValidateInput(Form form, ErrorProvider errorProvider, params TextBox[] textBoxs)
        {
            bool isValidated = true;
            if (textBoxs.Length > 0)
            {
                foreach (Control control in form.Controls)
                {
                    foreach (TextBox textBox in textBoxs)
                    {
                        if (control is TextBox && control == textBox && (((TextBox)control).TextLength == 0))
                        {
                            errorProvider.SetError(control, "Input can not be empty.");
                            isValidated = false;
                        }
                        else
                        {
                            errorProvider.SetError(control, null);
                        }
                    }
                }
            }

            return isValidated;
        }
        #endregion
    }
}