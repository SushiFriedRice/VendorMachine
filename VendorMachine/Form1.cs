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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListPay.CheckedItems.Contains("Credit Card"))
            {
                // Open Credit Card form
                CreditForm ccForm = new CreditForm();
                ccForm.Show();
            }
            else if (checkedListPay.CheckedItems.Contains("QR Code"))
            {
                // Open QR code form
                QrForm qrForm = new QrForm();
                qrForm.Show();
            }
        }
    }
}
