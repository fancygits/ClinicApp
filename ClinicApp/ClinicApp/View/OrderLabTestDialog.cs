using System.Windows.Forms;

namespace ClinicApp.View
{

    /// <summary>
    /// Parent Form for OrderLabTestUC
    /// </summary>
    public partial class OrderLabTestDialog : Form
    {
        private static OrderLabTestDialog instance = null;

        /// <summary>
        /// Constructor for the Form
        /// </summary>
        public OrderLabTestDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Singleton Instance for the Form (allows access to UC)
        /// </summary>
        /// <returns></returns>
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
