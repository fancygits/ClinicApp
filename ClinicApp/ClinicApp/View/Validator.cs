
using System;
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

        /// <summary>
        /// Checks DateTimePicker to make sure it's not a past date
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsFuture(Control control)
        {
            ErrorProvider error = new ErrorProvider();
            if (control.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
            {
                DateTimePicker dateTimePicker = (DateTimePicker)control;
                if (dateTimePicker.Value <= DateTime.Now)
                {
                    error.SetError(dateTimePicker, dateTimePicker.Tag.ToString() + " is not a future date.");
                    dateTimePicker.Focus();
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
