// Brandon Veasey
// 01/16/2018
// Chapter 3 – Programming Exercise 1
// Miles to Feet Conversion GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToFeetGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // constant declaration
            const int FEET_IN_MILES = 5280;

            //variable declaration
            double distanceInMiles = 0.0;
            double distanceInFeet = 0.0;

            // capture user imput and convert string to double
            distanceInMiles = Convert.ToDouble(milesTextBox.Text);

            //calc distance in feet
            distanceInFeet = distanceInMiles * FEET_IN_MILES;

            // display results to user
            displayLabel.Text = distanceInMiles + " miles is " + distanceInFeet + " feet.";

            //set focus to the miles textbox
            milesTextBox.Focus();

            // select all text 
            milesTextBox.SelectAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit request message box and determine if YES or NO is clicked
            if(MessageBox.Show("Select Yes to Comfirm Exit\nSelect NO to Resume", "Exit Request", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                // Yes clicked - terminate app
                Close();
            }else
            {
                // No clicked - clear interface and set focus
                milesTextBox.Clear();
                displayLabel.Text = string.Empty;
                milesTextBox.Clear();
            }
        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of displayLabel
            displayLabel.Text = string.Empty;
        }
    }
}
