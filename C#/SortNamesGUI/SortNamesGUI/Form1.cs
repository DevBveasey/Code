// Brandon Veasey
// 03/01/2018
// Chapter 8 – Programming Exercise 2
// Collect and sort first names

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SortNamesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            // declare variables
            int number = Convert.ToInt32(numNamesTextBox.Text);

            // determine how many names are to be entered
            if(number == 2 || number == 5 || number == 10)
            {
                //declare string array with user entered elements
                string[] namesArray = new string[number];

                // begin loop to get names
                for(int i = 0; i < number; i++)
                {
                    // call lower level method asigning returned value
                    namesArray[i] = InputNames();
                }// end for loop
             
                // Clear textbox
                numNamesTextBox.Clear();

                // call lower level method to display and sort array
                SortAndDisplayNames(namesArray);

                // call lower level method to display count msg
                DisplayCount(number);
            }

            // select all and set focus
            numNamesTextBox.SelectAll();
            numNamesTextBox.Focus();
        }

        // ----- Lower Level Method InputNames -----
        // Displays prompt for user to enter a name
        // Accepts no Arguments
        public string InputNames()
        {
            // declare variables
            string name;

            // present input box fo ruser data entry
            name = Microsoft.VisualBasic.Interaction.InputBox("Enter a Name", "Name Data Entry", "", -1, -1);

            // return user input
            return name;
        }

        // ----- Lower Level Method SortAndDisplayNames -----
        // displays the sorted names
        // accepts one argument string type array
        public void SortAndDisplayNames(params string[] namesArray)
        {
            // sort array order
            Array.Sort(namesArray);

            // display each entry in accending order
            for (int i = 0; i < namesArray.Length; i++)
            {
                // display name with a new line
                namesDisplayLabel.Text += namesArray[i] + "\n";
            }
        }

        // ----- Lower Level Method DisplayCount -----
        // displays the number of names
        // accepts one argument int type count
        public void DisplayCount(int count)
        {
            // display number of names msg
            namesDisplayLabel.Text += "\n\nNumber of Names ---> " + count;
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
                numNamesTextBox.Clear();
                namesDisplayLabel.Text = String.Empty;
                numNamesTextBox.Focus();
            }
        }

        private void numNamesTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display label
            namesDisplayLabel.Text = String.Empty;
        }
    }
}
