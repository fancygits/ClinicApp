using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Controller;

namespace ClinicApp.View
{
    public partial class TestEncryption : Form
    {
        public TestEncryption()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            this.label1.Text = Security.Hash(this.textBox1.Text);
        }
    }
}
