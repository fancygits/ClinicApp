
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// Class to handle common validation in Forms
    /// </summary>
    public class Validator
    {

      
        /// <summary>
        /// Checks if TextBox/ComboBox objects are empty and shows error message
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsPresent(Control control)
        {
            ErrorProvider error = new ErrorProvider();
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    //MessageBox.Show(textBox.Tag.ToString() + " is a required field.", "Error!",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    error.SetError(textBox, textBox.Tag.ToString() + " is a required field.");
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.Combobox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    error.SetError(comboBox, comboBox.Tag.ToString() + " is a required field.");
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


        public static bool IsValidDate(Control control)
        {
            return true;
        }
    }
}
