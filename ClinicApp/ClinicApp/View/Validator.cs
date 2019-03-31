
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
        /// Checks if TextBox/ComboBox objects are empty and shows error message
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsPresent(Control control, ErrorProvider error)
        {
            //ErrorProvider error = new ErrorProvider();
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    error.SetError(textBox, textBox.Tag.ToString() + " is a required field.");
                    textBox.Focus();
                    return false;
                }
                else
                {
                    error.SetError(textBox, "");
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    error.SetError(comboBox, comboBox.Tag.ToString() + " is a required field.");
                    return false;
                }
                else
                {
                    error.SetError(comboBox, "");
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.RichTextBox")
            {
                
                RichTextBox richTextBox = (RichTextBox)control;
                if (richTextBox.Text == "")
                {
                    error.SetError(richTextBox, richTextBox.Tag.ToString() + " is a required field.");
                    richTextBox.Focus();
                    return false;
                }
                else
                {
                    error.SetError(richTextBox, "");
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
            {
                MaskedTextBox maskedTextBox = (MaskedTextBox)control;
                if (!maskedTextBox.MaskFull)
                {
                    error.SetError(maskedTextBox, maskedTextBox.Tag.ToString() + " is a required field.");
                    maskedTextBox.Focus();
                    return false;
                }
                else
                {
                    error.SetError(maskedTextBox, "");
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks a DateTimePicker field if it's between allowable dates
        /// </summary>
        /// <param name="control">The control, it better be a DateTimePicker</param>
        /// <param name="minDate">The minimum allowable date</param>
        /// <param name="maxDate">The maximum allowable date</param>
        /// <param name="error">An ErrorProvider to communicate validation through</param>
        /// <returns></returns>
        public static bool IsValidDate(Control control, DateTime minDate, DateTime maxDate, ErrorProvider error)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
            {
                DateTimePicker dateTimePicker = (DateTimePicker)control;
                if (dateTimePicker.Value < minDate || dateTimePicker.Value > maxDate)
                {
                    error.SetError(dateTimePicker, dateTimePicker.Tag.ToString() + " is outside the allowable range.");
                    dateTimePicker.Focus();
                    return false;
                }
                else
                {
                    error.SetError(dateTimePicker, "");
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a textbox contains an integer
        /// </summary>
        /// <param name="textbox">The field to validate</param>
        /// <param name="error">The error provider to communicate through</param>
        /// <returns>True if it is an integer</returns>
        public static bool IsInt32(TextBox textbox, ErrorProvider error)
        {
            try
            {
                Convert.ToInt32(textbox.Text);
                error.SetError(textbox, "");
                return true;
            }
            catch (FormatException)
            {
                error.SetError(textbox, textbox.Tag.ToString() + " must be an integer.");
                return false;
            }
        }

        /// <summary>
        /// Checks if a textbox contains an decimal
        /// </summary>
        /// <param name="textbox">The field to validate</param>
        /// <param name="error">The error provider to communicate through</param>
        /// <returns>True if it is an decimal</returns>
        public static bool IsDecimal(TextBox textbox, ErrorProvider error)
        {
            try
            {
                Convert.ToDecimal(textbox.Text);
                error.SetError(textbox, "");
                return true;
            }
            catch (FormatException)
            {
                error.SetError(textbox, textbox.Tag.ToString() + " must be an decimal value.");
                return false;
            }
        }
    }
}
