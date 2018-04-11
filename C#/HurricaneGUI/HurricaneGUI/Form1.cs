// Brandon Veasey
// 01/23/2018
// Chapter 4 – Programming Exercise 2
// Determine Hurricane Category – Based on Wind Speeds

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurricaneGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // declare constants
            const string notMsg = "Not a Hurricane";

            // delcare variables
            int windSpeed;

            // capture user imput and convert string to int
            windSpeed = Convert.ToInt32(speedTextBox.Text);

            // find clasification
            if(windSpeed >= 157)
            {
                // wind speeds qualify as a cat 5
                classLabel.Text = "Category 5 Hurricane";
            }
            else if(windSpeed >= 130)
            {
                // wind speeds qualify as a cat 4
                classLabel.Text = "Category 4 Hurricane";
            }
            else if(windSpeed >= 111)
            {
                // wind speeds qualify as a cat 3
                classLabel.Text = "Category 3 Hurricane";
            }
            else if(windSpeed >= 96)
            {
                // wind speeds qualify as a cat 2
                classLabel.Text = "Category 2 Hurricane";
            }
            else if(windSpeed >= 74)
            {
                // wind speeds qualify as a cat 1
                classLabel.Text = "Category 1 Hurricane";
            }
            else
            {
                // wind speeds do not qualify as a Hurricane
                classLabel.Text = notMsg;
            }

            // set focus
            speedTextBox.Focus();

            // select all text
            speedTextBox.SelectAll();
        }

        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of classLabel
            classLabel.Text = string.Empty;
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
                speedTextBox.Clear();
                classLabel.Text = string.Empty;
                speedTextBox.Focus();
            }
        }
    }
}
