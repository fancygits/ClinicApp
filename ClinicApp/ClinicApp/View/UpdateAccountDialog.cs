using ClinicApp.Controller;
using ClinicApp.Model;
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// Defines the UpdateAccountDialog Form
    /// </summary>
    public partial class UpdateAccountDialog : Form
    {
        private Credential currentCredetials;
        private Credential newCredentials;
        private NurseController nurseController;
        private Nurse nurse;

        /// <summary>
        /// Constructs a new UpdateAccountDialog and populates the fields with a Person
        /// </summary>
        /// <param name="nurse">The Nurse to update</param>
        public UpdateAccountDialog(Nurse nurse)
        {
            this.nurse = nurse;
            InitializeComponent();
            nurseBindingSource.Add(nurse);
        }

        private void UpdateCredentials()
        {

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
    }
}
