using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyExchangeWinFormApp
{
    public static class ExtentionHelper
    {
        /// <summary>
        /// Determines whether the collection is null or contains no elements.
        /// </summary>
        /// <typeparam name="T">The IEnumerable type.</typeparam>
        /// <param name="enumerable">The enumerable, which may be null or empty.</param>
        /// <returns>
        ///     <c>true</c> if the IEnumerable is null or empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }
            /* If this is a list, use the Count property for efficiency. 
             * The Count property is O(1) while IEnumerable.Count() is O(N). */
            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count == 0;
            }
            return !enumerable.Any();
        }

        static ErrorProvider errorProvider = new ErrorProvider();
        public static bool IsNotEmpty(this TextBox textBox)
        {
            bool isValidated;
            errorProvider.SetError(textBox, null);
            if (textBox.TextLength == 0)
            {
                errorProvider.SetError(textBox, "Input can not be empty.");
                isValidated = false;
            }
            else
            {
                errorProvider.SetError(textBox, null);
                isValidated = true;
            }

            return isValidated;
        }
    }
}
