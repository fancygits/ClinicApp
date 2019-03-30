
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// Class to handle common validation in Forms
    /// </summary>
    public class Validator
    {

        /// <summary>
        /// Checks if TextBox objects are empty and shows error message
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    //MessageBox.Show(textBox.Tag.ToString() + " is a required field.", "Error!",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorProvider error = new ErrorProvider();
                    error.SetError(textBox, textBox.Tag.ToString() + " is a required field.");
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.RichTextBox")
            {
                
                RichTextBox richTextBox = (RichTextBox)control;
                if (richTextBox.Text == "")
                {
                    MessageBox.Show(richTextBox.Tag.ToString() + " is a required field.", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
