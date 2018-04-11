// Brandon Veasey
// 01/30/2018
// Chapter 5 – Programming Exercise 2
// Display integers from 1 to 20 and their squared value

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableOfSquaresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // declare and initilice constant
            const int LIMIT = 20;

            // for numbers 1-20 display calculated squared message
            int num = 1;// declare int for counting 1-20
            while(num <= LIMIT)
            {
                //  display and calculate squared num
                numLabel.Text += Convert.ToString(num) + " * " + Convert.ToString(num) + " = " + Convert.ToString(Math.Pow(num, 2)) + "\r\n";
                num++;
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
                numLabel.Text = string.Empty;
                displayButton.Focus();
            }
        }
    }
}
