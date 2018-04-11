// Brandon Veasey
// 01/25/2018
// Chapter 4 – Programming Exercise 4
// Discount a price based on user entries. Calculates and displays discounted price and savings 
// amount

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountGUI
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
            double price = 0.0;
            double rate = 0.0;
            double discountedPrice = 0.0;
            double savings = 0.0;

            // capture user imput and convert string to double
            price = Convert.ToDouble(priceTextBox.Text);
            rate = (Convert.ToDouble(rateTextBox.Text)) / 100;

            // check for invalid price
            if (price > 0)
            {
                if (rate > 0)
                {
                    // calc discounted price 
                    discountedPrice = price - (price * rate);

                    // calc savings
                    savings = price - discountedPrice;

                    // display results to user
                    discountLabel.Text = discountedPrice.ToString("C");
                    savingsLabel.Text = savings.ToString("C");

                    //set focus to the price textbox
                    priceTextBox.Focus();

                    // select all text 
                    priceTextBox.SelectAll();
                    rateTextBox.SelectAll();
                }
                else
                {
                    // display error msg
                    MessageBox.Show("Rate figure must be greater than zero (0)", "Data Entry Error", MessageBoxButtons.OK);

                    // set focus to the price textbox
                    rateTextBox.Focus();

                    // select all text 
                    priceTextBox.SelectAll();
                    rateTextBox.SelectAll();
                }
            }
            else
            {
                // display error msg
                MessageBox.Show("Price figure must be greater than zero (0)", "Data Entry Error", MessageBoxButtons.OK);

                // set focus to the price textbox
                priceTextBox.Focus();

                // select all text 
                priceTextBox.SelectAll();
                rateTextBox.SelectAll();
            }
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
                discountLabel.Text = string.Empty;
                savingsLabel.Text = string.Empty;
                priceTextBox.Focus();
                priceTextBox.SelectAll();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display labels
            discountLabel.Text = string.Empty;
            savingsLabel.Text = string.Empty;
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display labels
            discountLabel.Text = string.Empty;
            savingsLabel.Text = string.Empty;
        }
    }
}
