
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
    }
}
