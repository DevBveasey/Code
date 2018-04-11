// Brandon Veasey
// 01/18/2018
// Chapter 3 – Programming Exercise 2
// Project Sales Increase GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedSalesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void findSalesButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double northCurrent = 0;
            double southCurrent = 0;
            double northProjected = 0;
            double southProjected = 0;

            //declare constants
            const double SALES_INCREASE = .12;

            // capture user imput and convert string to double
            northCurrent = Convert.ToDouble(currentNorthTextBox.Text);
            southCurrent = Convert.ToDouble(currentSouthTextBox.Text);

            //calc projected sales
            northProjected = northCurrent + (northCurrent * SALES_INCREASE);
            southProjected = southCurrent + (southCurrent * SALES_INCREASE);

            // display results to user
            projectedNorthLabel.Text = northProjected.ToString("C");
            projectedSouthLabel.Text = southProjected.ToString("C");

            //set focus to the miles textbox
            currentNorthTextBox.Focus();

            // select all text 
            currentNorthTextBox.SelectAll();
            currentSouthTextBox.SelectAll();
        }

        private void currentNorthTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of projectedNorthLabel
            projectedNorthLabel.Text = string.Empty;

            // clear contents of projectedSouthLabel
            projectedSouthLabel.Text = string.Empty;
        }

        private void currentSouthTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of projectedSouthLabel
            projectedSouthLabel.Text = string.Empty;

            // clear contents of projectedNorthLabel
            projectedNorthLabel.Text = string.Empty;
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
                currentNorthTextBox.Clear();
                projectedNorthLabel.Text = string.Empty;
                projectedSouthLabel.Text = string.Empty;
                currentSouthTextBox.Clear();

                //set focus to the miles textbox
                currentNorthTextBox.Focus();
            }
        }

       
    }
}
