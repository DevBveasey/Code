// Brandon Veasey
// 02/15/2018
// Chapter 7 – Programming Exercise 3
// Collect number of quarts from the user. Calculate and display the conversion from quarts to 
// liters.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartsToLitersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // define and initilize constants
            const double rate = 0.946353;

            // define variable and store user input
            double quart = Convert.ToDouble(quartTextBox.Text);

            // display converted quarts to liters
            convertedLabel.Text = quart.ToString() + " quarts is " + CalcLiters(rate, quart).ToString("F3") + " liters.";

            // set focus
            quartTextBox.Focus();

            // select all
            quartTextBox.SelectAll();
        }

        private void quartTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear convertedLabel
            convertedLabel.Text = string.Empty;
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
                quartTextBox.Clear();
                convertedLabel.Text = string.Empty;
                quartTextBox.Focus();
            }
        }

        // ----- Lower level method CalcLiters ----- 
        // method that calculates the conversion to liters
        // passes the quarts value entered by the user and the conversion rate as arguments
        private double CalcLiters(double rate, double quart)
        {
            // declare variable to store calculated liters
            double liters;

            // calculate liters
            liters = quart * rate;

            // return the value of calculated liters to be displayed
            return liters;
        }
    }
}
