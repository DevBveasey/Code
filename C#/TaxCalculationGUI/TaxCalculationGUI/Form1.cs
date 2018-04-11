// Brandon Veasey
// 02/08/2018
// Chapter 8 – Programming Exercise 1
// Tax amount calculations

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calcButton_Click(object sender, EventArgs e)
        {
            // declare variables
            int rateInt = 0;
            double rateDouble = 0.00;
            double price = 0.00;

            // Capture user data
            price = Convert.ToDouble(priceTextBox.Text);
            rateInt = Convert.ToInt32(rateTextBox.Text);
            rateDouble = Convert.ToDouble(rateTextBox.Text);

            // call lower level functions
            ComputeTax(price, rateDouble);
            ComputeTax(price, rateInt);

            // select all
            priceTextBox.SelectAll();
            rateTextBox.SelectAll();

            // set focus
            priceTextBox.Focus();
        }

        // ----- Lower Level Method ComputeTax -----
        // calculate and display the tax amount
        // accepts two arguments, both a double type called price and rate
        public void ComputeTax(double price, double rate)
        {
            dspTaxLabel.Text = (rate / 100).ToString() + " tax on " + price.ToString("n2") + " is " + (price * (rate / 100)).ToString("C") + "\r\n";
        }

        // ----- Lower Level Method ComputeTax -----
        // calculate and display the tax amount
        // accepts two arguments, a double type called price and one integer type called rate
        public void ComputeTax(double price, int rate)
        {
            dspTaxLabel.Text += (rate / 100.0).ToString("p") + " tax on " + price.ToString("n2") + " is " + (price * (rate / 100.0)).ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit request message box and determine if YES or NO is clicked
            if (MessageBox.Show("Select Yes to Comfirm Exit\nSelect NO to Resume", "Exit Request", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Yes clicked - terminate app
                Close();
            }
            else
            {
                // No clicked - clear interface and set focus
                priceTextBox.Clear();
                rateTextBox.Clear();
                dspTaxLabel.Text = string.Empty;
                priceTextBox.Focus();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Clear dspTaxLabel
            dspTaxLabel.Text = string.Empty;
        }
    }
}
