// Brandon Veasey
// 01/25/2018
// Chapter 4 – Programming Exercise 1
// Collect GPA and test score from user. Determine and display college admission acceptance or 
// rejection based on these entries.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void checkButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double gpa = 0.0;
            double score = 0.0;

            // capture user imput and convert string to double
            gpa = Convert.ToDouble(gpaTextBox.Text);
            score = Convert.ToDouble(scoreTextBox.Text);

            if(gpa >= 3.0 && score >= 60)
            {
                // display accepted msg
                acceptLabel.Text = "Application Accepted";
            }else if(gpa <= 3.0 && score >= 80)
            {
                // display accepted msg
                acceptLabel.Text = "Application Accepted";
            }
            else
            {
                // display not accepted msg
                acceptLabel.Text = "Application Rejected";
            }

            // set Focus
            gpaTextBox.Focus();

            // select all
            gpaTextBox.SelectAll();
            scoreTextBox.SelectAll();
        }

        private void scoreTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of acceptLabel
            acceptLabel.Text = string.Empty;
        }
        private void gpaTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of acceptLabel
            acceptLabel.Text = string.Empty;
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
                gpaTextBox.Clear();
                scoreTextBox.Clear();
                acceptLabel.Text = string.Empty;
                gpaTextBox.Focus();
            }
        }
    }
}
