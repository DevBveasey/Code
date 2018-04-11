// Brandon Veasey
// 02/08/2018
// Chapter 6 – Programming Exercise 3
// Determine if zip code is in delivery area and display associated delivery charge

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryChargesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // declare arrays and initilize them
            string[] zips = { "19947", "19963", "19950", "19933", "19973", "19968", "19971", "19953", "19974", "19955"};
            double[] charges = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00, 5.25, 5.75, 6.10, 10.00};

            // declare variable and capture user input
            string zipCode = zipTextBox.Text;

            // declare count
            int count = -1;

            // loop through the array
            for(int i= 0; i < zips.Length; i++)
            {
                if (zipCode == zips[i])
                {
                    // set count to zipcode index
                    count = i;

                    // stop searching
                    i = zips.Length;
                }
            }

            // display msg to user
            if(count >= 0)
            {
                // zip code found
                deliveryLabel.Text = "OK to Deliver to " + zips[count].ToString() + ".\r\n Cost of Delivery is " + charges[count].ToString("C") + ".";
            }else
            {
                // zip code not found
                deliveryLabel.Text = "Sorry - No Delivery to " + zipCode.ToString() + ".";
            }

            // set focus and select all
            zipTextBox.Focus();
            zipTextBox.SelectAll();


        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear interface
            deliveryLabel.Text = string.Empty;
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
                zipTextBox.Clear();
                deliveryLabel.Text = string.Empty;

                // set focus
                zipTextBox.Focus();
            }
        }
    }
}
