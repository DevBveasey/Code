// Brandon Veasey
// 03/20/2018
// Chapter 10 – Programming Exercise 1
// View invoice information for service companies

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dspButton_Click(object sender, EventArgs e)
        {
            // delcare constants
            const int SIZE = 4;

            // declear variables
            string companyName = invoiceTextBox.Text;
            int index = -1;

            // declare arrays and initilize them
            string[] companyNames = new string[SIZE] { "ENERGY ELECTRIC CO-OP", "TEARDROP WATER SUPPLY", "RIVAL MORTGAGE ASSOCIATES", "PRO-TEC INSURANCE GROUP" };
            double[] amountsDue = new double[SIZE] { 175.75, 125.25, 750.50, 400.00 };
            int[] overdueDays = new int[SIZE] { 0, 30, 0, 60};

            // instantiate objects
            Invoice invoice = new Invoice();
            OverdueInvoice overdueInvoice = new OverdueInvoice();

            // find index of user entered company
            for(int i = 0; i < SIZE; i++ )
            {
                if(companyName == companyNames[i])
                {
                    index = i;
                    i = SIZE;
                }
            }

            // deterimine if company is a valid company name
            if(index >= 0 )
            {
                // valid company name found
                if(overdueDays[index] > 0)
                {
                    // is overdue
                    // set daysOverdue, amountDue and CompanyName 
                    overdueInvoice.AmountDue = amountsDue[index];
                    overdueInvoice.CompanyName = companyNames[index];
                    overdueInvoice.DaysOverdue = overdueDays[index];

                    // display results and set alignmnet
                    displayLabel.TextAlign = ContentAlignment.TopLeft;
                    displayLabel.Text = overdueInvoice.ToString();
                }
                else
                {
                    // not over due
                    // set amountDue and CompanyName 
                    invoice.AmountDue = amountsDue[index];
                    invoice.CompanyName = companyNames[index];

                    // display results
                    displayLabel.TextAlign = ContentAlignment.TopLeft;
                    displayLabel.Text = invoice.ToString();
                }
            }
            else
            {
                // not a valid company
                displayLabel.TextAlign = ContentAlignment.MiddleCenter;
                displayLabel.Text = "INVALID ENTRY\nPlease Try Again!";
            }

            // select all and set focus
            invoiceTextBox.SelectAll();
            invoiceTextBox.Focus();
        }
        private void invoiceTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear displayLabel
            displayLabel.Text = string.Empty;
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
                invoiceTextBox.Clear();
                displayLabel.Text = string.Empty;
                invoiceTextBox.Focus();
            }
        }
    }
}
