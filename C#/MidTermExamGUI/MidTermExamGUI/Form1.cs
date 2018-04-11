// Brandon Veasey
// 02/15/2018
// Visual Programming Midterm Exam
// Collect number of drawers and wood type from user. Calculate and display the cost of a
// custom desk based on the number of drawers and type of wood.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermExamGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare Global constants
        const double PINE_DESK = 150.00;
        const double OAK_DESK = 175.00;
        const double MAHOGANY_DESK = 225.00;
        const double SURCHARGE = 25.00;

        private void quoteButton_Click(object sender, EventArgs e)
        {
            // declare variables
            int numDrawers;
            char woodType;
            double total;

            // call GetNumDrawers storing returned int as numDrawers
            numDrawers = GetNumDrawers();

            // call GetWoodType storing returned char as woodType
            woodType = GetWoodType();

            // call CalcCost storing returned double as total
            total = CalcCost(woodType, numDrawers);

            // call DspCostInfo to display full quote message to user
            DspCostInfo(woodType, numDrawers, total);

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
                drawerTextBox.Clear();
                typeTextBox.Clear();
                quoteDisplayLabel.Text = string.Empty;
                drawerTextBox.Focus();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display label
            quoteDisplayLabel.Text = string.Empty;
        }

        // ----- Lower Level Method GetNumDrawers -----
        // collects and returns the number of drawers to the caller of this method
        // accepts no arguments
        public int GetNumDrawers()
        {
            // declare variables
            int numDrawers = 0;

            // capture and convert user input
            numDrawers = Convert.ToInt32(drawerTextBox.Text);
           
            return numDrawers;
        }

        // ----- Lower Level Method GetWoodType -----
        // collects and returns the type of wood to the caller of this method
        // accepts no arguments

        public char GetWoodType()
        {
            // declare variables
            char woodType;

            // capture and convert user input
            woodType = Convert.ToChar(typeTextBox.Text);

            return woodType;
        }

        // ----- Lower Level Method CalcCost -----
        // calculates and returns cost of the desk
        // accepts Two arguments
        public double CalcCost(char woodType, int numDrawers)
        {
            // declare variables
            double total;
            double woodCost;

            // set wood type full name
            switch (woodType)
            {
                case 'P':
                    woodCost = PINE_DESK;
                    break;
                case 'O':
                    woodCost = OAK_DESK;
                    break;
                default:
                    woodCost = MAHOGANY_DESK;
                    break;
            }

            // calc total
            total = woodCost + (numDrawers * SURCHARGE);

            return total;
        }

        // ----- Lower Level Method DspCostInfo -----
        // displays itimized cost infomation 
        // accepts three arguments 
        public void DspCostInfo(char woodType, int numDrawers, double total)
        {
            // declare variables
            string woodName = "";
            double drawerCost = 0.0;
            double woodCost;

            if( numDrawers < 0)
            {// invalid number of drawers
                // display error msg box 
                MessageBox.Show("INVALID NUMBER OF DRAWERS ENTERED \r\nCannot be a negative number \r\n\r\nPlease try again! ", "Data Entry Error", MessageBoxButtons.OK);

                // set focus
                drawerTextBox.Focus();

                // select all
                drawerTextBox.SelectAll();
            }
            else if(woodType != 'P' && woodType != 'O' && woodType != 'M')
            {// invalid wood type
                // display error msg box 
                MessageBox.Show("INVALID WOOD TYPE ENTERED \r\n Must be P, O, or M \r\n\r\n Please try again! ", "Data Entry Error", MessageBoxButtons.OK);
                
                // set focus
                typeTextBox.Focus();

                // select all
                typeTextBox.SelectAll();
            }
            else 
            {// data is valid
                // set wood type full name
                switch (woodType)
                {
                    case 'P':
                        woodName = "Pine";
                        woodCost = PINE_DESK;
                        break;
                    case 'O':
                        woodName = "Oak";
                        woodCost = OAK_DESK;
                        break;
                    default:
                        woodName = "Mahogany";
                        woodCost = MAHOGANY_DESK;
                        break;
                }

                // calculate draw cost
                drawerCost = numDrawers * SURCHARGE;

                // display quote message
                quoteDisplayLabel.Text = "WOOD TYPE: " + woodName.ToString() + "\r\n" +
                    "Cost ....................... " + woodCost.ToString("f2") + "\r\n" + "\r\n" +
                    "Drawers: " + numDrawers.ToString() + "\r\n" +
                    "Cost ....................... " + drawerCost.ToString("f2") + "\r\n" + "\r\n" +
                    "Total Cost ................ " + total.ToString("c");

                // set focus
                drawerTextBox.Focus();

                // select all
                drawerTextBox.SelectAll();
                typeTextBox.SelectAll();
            }// end if else-if

        }

        private void showTypesButton_Click(object sender, EventArgs e)
        {
            // display error msg box 
            MessageBox.Show("P---> PINE\r\nO---> OAK\r\nM---> MAHOGANY", "Wood Types", MessageBoxButtons.OK);

            // select all and set focus
            typeTextBox.SelectAll();
            typeTextBox.Focus();
        }
    }
}
