using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMachine
{
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for confirming your information");

            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
