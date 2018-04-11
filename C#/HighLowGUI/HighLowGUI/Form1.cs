// Brandon Veasey
// 01/25/2018
// Chapter 4 – Programming Exercise 3
// Determine high and low numbers based on user entries

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighLowGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineButton_Click(object sender, EventArgs e)
        {
            // declare variables
            double intOne;
            double intTwo;
            double intThree;

            // capture user imput and convert string to double
            intOne = Convert.ToDouble(intOneTextBox.Text);
            intTwo = Convert.ToDouble(intTwoTextBox.Text);
            intThree = Convert.ToDouble(intThreeTextBox.Text);

            // find largest number and display to user
            highLabel.Text = Convert.ToString(Math.Max(Math.Max(intOne, intTwo), intThree));

            // find smallest number and display to user
            lowLabel.Text = Convert.ToString(Math.Min(Math.Min(intOne, intTwo), intThree));

            //set focus
            intOneTextBox.Focus();

            // select all text 
            intOneTextBox.SelectAll();
            intTwoTextBox.SelectAll();
            intThreeTextBox.SelectAll();
        }

        private void int_TextChanged(object sender, EventArgs e)
        {
           // clear contents of display Labels
           highLabel.Text = string.Empty;
           lowLabel.Text = string.Empty;
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
                intOneTextBox.Clear();
                intTwoTextBox.Clear();
                intThreeTextBox.Clear();
                highLabel.Text = string.Empty;
                lowLabel.Text = string.Empty;
                intOneTextBox.Focus();
            }
        }
    }
}
