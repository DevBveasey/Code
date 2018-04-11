// Brandon Veasey
// 02/08/2018
// Chapter 6 – Programming Exercise 2
// Calculate tip average and determine how far each tip is from the average

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipsListGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear all labels
            dayOneLabel.Text = string.Empty;
            dayTwoLabel.Text = string.Empty;
            dayThreeLabel.Text = string.Empty;
            dayFourLabel.Text = string.Empty;
            dayFiveLabel.Text = string.Empty;
            daySixLabel.Text = string.Empty;
            daySevenLabel.Text = string.Empty;
            totalLabel.Text = string.Empty;
            avgTipLabel.Text = string.Empty;
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
                dayOneTextBox.Clear();
                dayTwoTextBox.Clear();
                dayThreeTextBox.Clear();
                dayFourTextBox.Clear();
                dayFiveTextBox.Clear();
                daySixTextBox.Clear();
                daySevenTextBox.Clear();

                // clear all labels
                dayOneLabel.Text = string.Empty;
                dayTwoLabel.Text = string.Empty;
                dayThreeLabel.Text = string.Empty;
                dayFourLabel.Text = string.Empty;
                dayFiveLabel.Text = string.Empty;
                daySixLabel.Text = string.Empty;
                daySevenLabel.Text = string.Empty;
                totalLabel.Text = string.Empty;
                avgTipLabel.Text = string.Empty;

                // set focus
                dayOneTextBox.Focus();
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // Declare Global array
            double[] tips = new double[7];
            double[] diffrence = new double[7];

            //declare variables
            double avg = 0.0;
            double total = 0.0;
            int count = 0;

            // capture user input
            tips[0] = Convert.ToDouble(dayOneTextBox.Text);
            tips[1] = Convert.ToDouble(dayTwoTextBox.Text);
            tips[2] = Convert.ToDouble(dayThreeTextBox.Text);
            tips[3] = Convert.ToDouble(dayFourTextBox.Text);
            tips[4] = Convert.ToDouble(dayFiveTextBox.Text);
            tips[5] = Convert.ToDouble(daySixTextBox.Text);
            tips[6] = Convert.ToDouble(daySevenTextBox.Text);

            // calc total
            foreach (double tip in tips)
            {
                // Add tip to total
                total += tip;
                diffrence[count] = tip - avg;
            }

            // calc avg
            avg = total / tips.Length;

            // calc diffrence
            foreach (double tip in tips)
            {
                diffrence[count] = tip - avg;
                count++;
            }

            // display avg and total
            totalLabel.Text = total.ToString("c");
            avgTipLabel.Text = avg.ToString("c");

            // display day one tips
            if (tips[0] < avg)
            {
                // tip is less then avg
                dayOneLabel.Text = diffrence[0].ToString("n2");
                dayOneLabel.ForeColor = Color.Red;
            }else
            {
                dayOneLabel.Text = diffrence[0].ToString("n2");
                dayOneLabel.ForeColor = Color.Black;
            }

            // display day Two tips
            if (tips[1] < avg)
            {
                // tip is less then avg
                dayTwoLabel.Text = diffrence[1].ToString("n2");
                dayTwoLabel.ForeColor = Color.Red;
            }
            else
            {
                dayTwoLabel.Text = diffrence[1].ToString("n2");
                dayTwoLabel.ForeColor = Color.Black;
            }

            // display day Three tips
            if (tips[2] < avg)
            {
                // tip is less then avg
                dayThreeLabel.Text = diffrence[2].ToString("n2");
                dayThreeLabel.ForeColor = Color.Red;
            }
            else
            {
                dayThreeLabel.Text = diffrence[2].ToString("n2");
                dayThreeLabel.ForeColor = Color.Black;
            }

            // display day Four tips
            if (tips[3] < avg)
            {
                // tip is less then avg
                dayFourLabel.Text = diffrence[3].ToString("n2");
                dayFourLabel.ForeColor = Color.Red;
            }
            else
            {
                dayFourLabel.Text = diffrence[3].ToString("n2");
                dayFourLabel.ForeColor = Color.Black;
            }

            // display day Five tips
            if (tips[4] < avg)
            {
                // tip is less then avg
                dayFiveLabel.Text = diffrence[4].ToString("n2");
                dayFiveLabel.ForeColor = Color.Red;
            }
            else
            {
                dayFiveLabel.Text = diffrence[4].ToString("n2");
                dayFiveLabel.ForeColor = Color.Black;
            }

            // display day Six tips
            if (tips[5] < avg)
            {
                // tip is less then avg
                daySixLabel.Text = diffrence[5].ToString("n2");
                daySixLabel.ForeColor = Color.Red;
            }
            else
            {
                daySixLabel.Text = diffrence[5].ToString("n2");
                daySixLabel.ForeColor = Color.Black;
            }

            // display day Seven tips
            if (tips[6] < avg)
            {
                // tip is less then avg
                daySevenLabel.Text = diffrence[6].ToString("n2");
                daySevenLabel.ForeColor = Color.Red;
            }
            else
            {
                daySevenLabel.Text = diffrence[6].ToString("n2");
                daySevenLabel.ForeColor = Color.Black;
            }

            // select all
            dayOneTextBox.SelectAll();
            dayTwoTextBox.SelectAll();
            dayThreeTextBox.SelectAll();
            dayFourTextBox.SelectAll();
            dayFiveTextBox.SelectAll();
            daySixTextBox.SelectAll();
            daySevenTextBox.SelectAll();

            // set focus
            dayOneTextBox.Focus();

        }
    }
}
