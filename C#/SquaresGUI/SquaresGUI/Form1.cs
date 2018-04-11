// Brandon Veasey
// 03/06/2018
// Chapter 9 – Programming Exercise 2
// Instantiate an array of square objects to display the area of each square

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquaresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // instantiates a array of 9 objects
            // passing the value of length
            Square[] squareArray = new Square[9];
            for(int i = 0; i < squareArray.Length; ++i)
            {
                squareArray[i] = new Square(i+1);
            }

            // display squares msg
            for(int i = 0; i < squareArray.Length; ++i)
            {
                displayLabel.Text += "The area of a " + squareArray[i].GetSide + " by " + squareArray[i].GetSide +
                                    " square is " + squareArray[i].GetArea + "\n";
            }

            // set focus
            exitButton.Focus();


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
                displayLabel.Text = string.Empty;
                displayButton.Focus();
            }
        }
    }
}
