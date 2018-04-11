// Brandon Veasey
// 01/30/2018
// Chapter 5 – Programming Exercise 1
// Display odd numbers from 1 to 99

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddNumbersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showNumButton_Click(object sender, EventArgs e)
        {
            // declare and initilize constant
            const int LIMIT = 100;

            // initilize num as 1 and display all numbers between 0-100
            for(int num = 1; num < LIMIT; num++)
            {
                numLabel.Text += num + " ";// idsplay msg of numbers
                num++; // increment num
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
                showNumButton.Focus();
            }
        }
    }
}
