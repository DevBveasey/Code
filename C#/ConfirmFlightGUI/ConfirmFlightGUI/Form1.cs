// Brandon Veasey
// 03/06/2018
// Chapter 9 – Programming Exercise 1
// Instantiate an object to display flight information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfirmFlightGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // instantiating Flight class
            Flight myFlight = new Flight();

            //convert and set data in object
            myFlight.GetAirline = nameTextBox.Text;
            myFlight.GetFlightNum = Convert.ToInt32(flightNumTextBox.Text);
            myFlight.GetRow = Convert.ToInt32(rowTextBox.Text);
            myFlight.GetSeat = Convert.ToChar(seatTextBox.Text);

            // display confirmation
            confirmationLabel.Text = " You are booked on Flight # " + myFlight.GetFlightNum + " on "
                                     + myFlight.GetAirline + " Airlines." + "\n\n" +
                                     "Your seating assignment is Row " + myFlight.GetRow + " Seat "
                                     + myFlight.GetSeat + "\n\n" + "**FLIGHT CONFIRMED**";

            // select all
            nameTextBox.SelectAll();
            flightNumTextBox.SelectAll();
            rowTextBox.SelectAll();
            seatTextBox.SelectAll();

            // set focus
            nameTextBox.Focus();
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
                nameTextBox.Clear();
                flightNumTextBox.Clear();
                rowTextBox.Clear();
                seatTextBox.Clear();
                confirmationLabel.Text = string.Empty;
                nameTextBox.Focus();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of display label
            confirmationLabel.Text = string.Empty;
        }
    }
}
