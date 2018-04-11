// Brandon Veasey
// 02/13/2018
// Chapter 7 – Programming Exercise 2
// Generate a multiplication table

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            // declare variable and store user input
            int num = Convert.ToInt32(intTextBox.Text);

            // call lower level method to handle mutiplication and displaying of user entered data
            MultTable(num);

            // set focus
            intTextBox.Focus();

            // select all
            intTextBox.SelectAll();
        }

        private void intTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of dspLabel
            dspLabel.Text = string.Empty;
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
               intTextBox.Clear();
               dspLabel.Text = string.Empty;
               intTextBox.Focus();
            }
        }
        // ----- lower level method MultTable ----- 
        // performs the appropriate multiplications and displays the results to the user
        // accepts one argument int num
        public void MultTable(int num)
        {
            // clear string before writing new data
            dspLabel.Text = string.Empty;

            // writes msg to dsplabel 
            for ( int x = 2; x < 10; x++)
            {
                // calculate total
                int total = num * x;

                //declare string for holding calculated msg
                dspLabel.Text += num.ToString() + " * " + x + " = " + total.ToString() + "\n\r";
            }
            
        }
    }
}
