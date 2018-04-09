namespace HelpLibrary
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

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
    }
}
