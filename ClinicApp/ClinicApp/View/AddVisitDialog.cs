using System.Windows.Forms;
namespace ClinicApp.View
{

    public partial class AddVisitDialog : Form
    {
        private static AddVisitDialog instance = null;

        public AddVisitDialog()
        {
            InitializeComponent();
        }

        public static AddVisitDialog Instance()
        {
            if (instance == null)
            {
                instance = new AddVisitDialog();
            }
            return instance;
        }
    }
}
