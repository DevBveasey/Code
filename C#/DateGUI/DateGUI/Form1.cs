// Brandon Veasey
// 03/20/2018
// Chapter 10 – Programming Exercise 2
// Enter, manipulate, and display a date using multiple classes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dispalyButton_Click(object sender, EventArgs e)
        {
            // declare variables and initilize
            int month = Convert.ToInt32(monthTextBox.Text);
            int day = Convert.ToInt32(dayTextBox.Text);
            int year = Convert.ToInt32(yearTextBox.Text);

            // instantiate objects
            Dates myDates = new Dates();
            DatesUpdate myDatesUpdate = new DatesUpdate();

            // validate user entered month
            if (month < 1 || month > 12)
            {
                // invalid month
                MessageBox.Show("Invalid month entered (1-12 only)", "Data Entry Error");

                // set focus and select all
                monthTextBox.Focus();
                monthTextBox.SelectAll();
            }
            else // valid month validate day
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (day < 1 || day > 31)
                        {
                            // invalid day
                            MessageBox.Show("Invalid day entered (1-31 only)", "Data Entry Error");

                            // set focus and select all
                            dayTextBox.Focus();
                            dayTextBox.SelectAll();
                        }
                        else
                        {
                            // valid day validate year
                            if (year < 1900)
                            {
                                // invalid year
                                // invalid day
                                MessageBox.Show("Invalid year entered (1900 or later)", "Data Entry Error");

                                // set focus and select all
                                yearTextBox.Focus();
                                yearTextBox.SelectAll();
                            }
                            else
                            {
                                // valid year 
                                // call SetDates passing required variables
                                myDates.SetDate(month, day, year);
                                myDatesUpdate.SetDate(month, day, year);

                                // display today msg
                                todayLabel.Text = "Today is ---> " + myDates.BuildDate();

                                // display tomorrow msg
                                tomorrowLabel.Text = "Tomorrow is ---> " + myDatesUpdate.UpdateDates();

                                // set focus and select all
                                monthTextBox.Focus();
                                monthTextBox.SelectAll();
                                dayTextBox.SelectAll();
                                yearTextBox.SelectAll();
                            }
                        }
                        break;
                    case 2:
                        // check for leap year
                        if ((year % 400 == 0 || year % 100 != 0) && (year % 4 == 0))
                        {
                            // is a leap year
                            if (day < 1 || day > 29)
                            {
                                // invalid day
                                MessageBox.Show("Invalid day entered (1-29 only)", "Data Entry Error");

                                // set focus and select all
                                dayTextBox.Focus();
                                dayTextBox.SelectAll();
                            }
                            else
                            {
                                // valid day validate year
                                if (year < 1900)
                                {
                                    // invalid year
                                    // invalid day
                                    MessageBox.Show("Invalid year entered (1900 or later)", "Data Entry Error");

                                    // set focus and select all
                                    yearTextBox.Focus();
                                    yearTextBox.SelectAll();
                                }
                                else
                                {
                                    // valid year 
                                    // call SetDates passing required variables
                                    myDates.SetDate(month, day, year);
                                    myDatesUpdate.SetDate(month, day, year);

                                    // display today msg
                                    todayLabel.Text = "Today is ---> " + myDates.BuildDate();

                                    // display tomorrow msg
                                    tomorrowLabel.Text = "Tomorrow is ---> " + myDatesUpdate.UpdateDates();

                                    // set focus and select all
                                    monthTextBox.Focus();
                                    monthTextBox.SelectAll();
                                    dayTextBox.SelectAll();
                                    yearTextBox.SelectAll();
                                }
                            }
                        }
                        else
                        {
                            // is not a leap year
                            if (day < 1 || day > 28)
                            {
                                // invalid day
                                MessageBox.Show("Invalid day entered (1-28 only)", "Data Entry Error");

                                // set focus and select all
                                dayTextBox.Focus();
                                dayTextBox.SelectAll();
                            }
                            else
                            {
                                // valid day validate year
                                if (year < 1900)
                                {
                                    // invalid year
                                    // invalid day
                                    MessageBox.Show("Invalid year entered (1900 or later)", "Data Entry Error");

                                    // set focus and select all
                                    yearTextBox.Focus();
                                    yearTextBox.SelectAll();
                                }
                                else
                                {
                                    // valid year 
                                    // call SetDates passing required variables
                                    myDates.SetDate(month, day, year);
                                    myDatesUpdate.SetDate(month, day, year);

                                    // display today msg
                                    todayLabel.Text = "Today is ---> " + myDates.BuildDate();

                                    // display tomorrow msg
                                    tomorrowLabel.Text = "Tomorrow is ---> " + myDatesUpdate.UpdateDates();

                                    // set focus and select all
                                    monthTextBox.Focus();
                                    monthTextBox.SelectAll();
                                    dayTextBox.SelectAll();
                                    yearTextBox.SelectAll();
                                }
                            }
                        }
                        break;
                    default:
                        if (day < 1 || day > 30)
                        {
                            // invalid day
                            MessageBox.Show("Invalid day entered (1-30 only)", "Data Entry Error");

                            // set focus and select all
                            dayTextBox.Focus();
                            dayTextBox.SelectAll();
                        }
                        else
                        {
                            // valid day validate year
                            if (year < 1900)
                            {
                                // invalid year
                                // invalid day
                                MessageBox.Show("Invalid year entered (1900 or later)", "Data Entry Error");

                                // set focus and select all
                                yearTextBox.Focus();
                                yearTextBox.SelectAll();
                            }
                            else
                            {
                                // valid year 
                                // call SetDates passing required variables
                                myDates.SetDate(month, day, year);
                                myDatesUpdate.SetDate(month, day, year);

                                // display today msg
                                todayLabel.Text = "Today is ---> " + myDates.BuildDate();

                                // display tomorrow msg
                                tomorrowLabel.Text = "Tomorrow is ---> " + myDatesUpdate.UpdateDates();

                                // set focus and select all
                                monthTextBox.Focus();
                                monthTextBox.SelectAll();
                                dayTextBox.SelectAll();
                                yearTextBox.SelectAll();
                            }
                        }
                        break;
                } // end switch

            }// end else
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
                monthTextBox.Clear();
                dayTextBox.Clear();
                yearTextBox.Clear();
                todayLabel.Text = string.Empty;
                tomorrowLabel.Text = string.Empty;
                monthTextBox.Focus();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of both display labels
            todayLabel.Text = string.Empty;
            tomorrowLabel.Text = string.Empty;
        }
    }
}
