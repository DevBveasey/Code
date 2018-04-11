// Brandon Veasey
// 02/01/2018
// Chapter 5 – Programming Exercise 4
// Increase a base price by percentages 10 through 20.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncreaseGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear increaseLabel when user changes contents of priceTextBox
            increaseLabel.Text = string.Empty;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double rate = 0.0;
            double price = 0.0;
            double newPrice = 0.0;
            string displayMessage = "";

            // capture user imput and convert string to double
            price = Convert.ToDouble(priceTextBox.Text);

            for(int count = 10; count <= 20; count++)
            {
                // calculate rate
                rate = count / 100.0;

                // calculate newPrice
                newPrice =  price + (price * rate);

                // create display msg
                displayMessage += count.ToString() + " % Increase ---> " + newPrice.ToString("c") + "\r\n";
            }

            // display results
            increaseLabel.Text = displayMessage;

            // select all
            priceTextBox.SelectAll();

            // set focus
            priceTextBox.Focus();

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
                increaseLabel.Text = string.Empty;
                priceTextBox.Focus();
            }
        }
    }
}
