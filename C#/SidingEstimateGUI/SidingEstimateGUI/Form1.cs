// Brandon Veasey
// 02/15/2018
// Chapter 7 – Programming Exercise 1
// Calculate cost of vinyl siding

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidingEstimateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // declare variables and store user input
            double length = Convert.ToDouble(lengthTextBox.Text);
            double depth = Convert.ToDouble(depthTextBox.Text);
            double cost = Convert.ToDouble(costTextBox.Text);

            // display cost message with calculated total from CalcCost()
           messageLabel.Text = "Cost of siding is " + CalcCost(length, depth, cost).ToString("C");

            // set Focus
           lengthTextBox.Focus();

            // select all
           lengthTextBox.SelectAll();
           depthTextBox.SelectAll();
           costTextBox.SelectAll();
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
                lengthTextBox.Clear();
                depthTextBox.Clear();
                costTextBox.Clear();
                messageLabel.Text = string.Empty;
                lengthTextBox.Focus();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display message
            messageLabel.Text = string.Empty;
        }

        // ----- lower level method CalcCost -----
        // calculate the cost of the siding
        // accepts three double type arguments, returns one double type 
        private static double CalcCost(double length, double depth, double cost)
        {
            // declare and initilize total to 0
            double total = 0;

            // calculate total cost
            total = (length * depth) * cost;

            // return calculated total
            return total;
        }
    }
}
