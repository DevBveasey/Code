// Brandon Veasey
// 02/08/2018
// Chapter 6 – Programming Exercise 1
// Collect ten integer values from the user storing each in an array. Display the array values in  // the order they were entered, reverse order, and sorted (ascending) order.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Global array
        int[] values = new int[10];

        // Global variable
        int counter = 0;
        string dspText = "";

        private void writeButton_Click(object sender, EventArgs e)
        {
            // checks for a full array 
            if(counter < values.Length)
            {
                // capture user imput and convert string to double
                values[counter] = Convert.ToInt32(valuesTextBox.Text);
                counter++;

                // clear textbox
                valuesTextBox.Clear();

                //set Focus
                valuesTextBox.Focus();
            }
            else
            {
                // display exit request message box and determine if YES or NO is clicked
                if (MessageBox.Show("Array if Full - Click OK to Close", "Array Capacity Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    // OK clicked - set focus
                    entryButton.Focus();

                    // clear textbox
                    valuesTextBox.Clear();
                }
            }
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            // display each entry in the order it was entered
            foreach(int value in values)
            {
                entryLabel.Text += value.ToString() + "\r\n";
            }

            // Set focus to reverse order button
            reverseButton.Focus();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            // reverse array order
            Array.Reverse(values);

            // display each entry in the reverse order it was entered
            foreach (int value in values)
            {
                reverseLabel.Text += value.ToString() + "\r\n";
            }

            // Set focus to sort order button
            sortButton.Focus();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // sort array order
            Array.Sort(values);

            // display each entry in accending order
            foreach (int value in values)
            {
                sortLabel.Text += value.ToString() + "\r\n";
            }

            // Set focus to sort order button
            exitButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit request message box and determine if YES or NO is clicked
            if (MessageBox.Show("Click OK to Close", "Exit Request", MessageBoxButtons.OK) == DialogResult.OK)
            {
                // OK clicked - terminate app
                Close();
            }
        }
    }
}
