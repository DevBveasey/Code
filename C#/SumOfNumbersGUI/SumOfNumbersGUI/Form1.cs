// Brandon Veasey
// 01/30/2018
// Chapter 5 – Programming Exercise 3
// Sum the numbers from 1 to a number entered by the user

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void integerTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear display label when user changes input
            dspSumLabel.Text = string.Empty;
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int integer = 0;
            int count = 0;
            int sum = 0;

            // capture user imput and convert string to double
            integer = Convert.ToInt32(integerTextBox.Text);

            // calculate the sum of numbers
            while(count <= integer)
            {
                sum += count;
                count++;
            }

            // display sum message
            dspSumLabel.Text = "The sum of the numbers 1 to " + integer.ToString() + " is " + sum.ToString();

            // set Focus
            integerTextBox.Focus();

            // select all
            integerTextBox.SelectAll();

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
                // Not clicked - clear interface and set focus
                integerTextBox.Clear();
                dspSumLabel.Text = string.Empty;
                integerTextBox.Focus();
            }
        }
    }
}
