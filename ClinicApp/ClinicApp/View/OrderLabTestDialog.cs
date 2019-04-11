using System.Windows.Forms;

namespace ClinicApp.View
{
    public partial class OrderLabTestDialog : Form
    {
        private static OrderLabTestDialog instance = null;
        public OrderLabTestDialog()
        {
            InitializeComponent();
        }

        public static OrderLabTestDialog Instance()
        {
            if (instance == null)
            {
                instance = new OrderLabTestDialog();
            }
            return instance;
        }
    }
}
