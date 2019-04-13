using ClinicApp.Model;
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// Defines the UpdateAccountDialog Form
    /// </summary>
    public partial class ResetPasswordDialog : Form
    {
        public Credential newCredential;
        public Nurse nurse;

        /// <summary>
        /// Constructs a new UpdateAccountDialog and populates the fields with a Person
        /// </summary>
        /// <param name="nurse">The Nurse to update</param>
        public ResetPasswordDialog(Nurse nurse)
        {
            this.nurse = nurse;
            newCredential.Username = nurse.Username;
            newCredential.Role = "nurse";
            InitializeComponent();
        }

        private void UpdateCredentials()
        {
            if (ValidateFields())
            {
                newCredential.Password = newPasswordTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void updateCredentialsButton_Click(object sender, System.EventArgs e)
        {
            UpdateCredentials();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateFields()
        {
            return Validator.IsPresent(newPasswordTextBox, errorProvider) &&
                   Validator.IsPresent(confirmPasswordTextBox, errorProvider) &&
                   Validator.FieldsMatch(newPasswordTextBox, confirmPasswordTextBox, errorProvider);
        }
    }
}
