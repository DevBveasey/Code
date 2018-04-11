// Brandon Veasey
// 01/18/2018
// Chapter 3 – Programming Exercise 3
// Average of Test Scores GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scoreOneTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of averageLabel
            averageLabel.Text = string.Empty;
        }

        private void scoreTwoTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of averageLabel
            averageLabel.Text = string.Empty;
        }

        private void scoreThreeTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of averageLabel
            averageLabel.Text = string.Empty;
        }

        private void scoreFourTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of averageLabel
            averageLabel.Text = string.Empty;
        }

        private void scoreFiveTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear contents of averageLabel
            averageLabel.Text = string.Empty;
        }

        private void findAvgButton_Click(object sender, EventArgs e)
        {
            // declare constant
            const double NUM_SCORES = 5.0;

            //declare variables
            int scoreOne = 91;
            int scoreTwo = 75;
            int scoreThree = 88;
            int scoreFour = 100;
            int scoreFive = 95;
            double avgScore = 0.0;

            // capture user imput and convert string to int
            scoreOne = Convert.ToInt32(scoreOneTextBox.Text);
            scoreTwo = Convert.ToInt32(scoreTwoTextBox.Text);
            scoreThree = Convert.ToInt32(scoreThreeTextBox.Text);
            scoreFour = Convert.ToInt32(scoreFourTextBox.Text);
            scoreFive = Convert.ToInt32(scoreFiveTextBox.Text);

            //calc avg
            avgScore = (scoreOne + scoreTwo + scoreThree + scoreFour + scoreFive) / NUM_SCORES;

            // display results to user
            averageLabel.Text = avgScore.ToString("n2");

            //set focus to the miles textbox
            scoreOneTextBox.Focus();

            // select all text 
            scoreOneTextBox.SelectAll();
            scoreTwoTextBox.SelectAll();
            scoreThreeTextBox.SelectAll();
            scoreFourTextBox.SelectAll();
            scoreFiveTextBox.SelectAll();

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
                scoreOneTextBox.Clear();
                scoreTwoTextBox.Clear();
                scoreThreeTextBox.Clear();
                scoreFourTextBox.Clear();
                scoreFiveTextBox.Clear();
                averageLabel.Text = string.Empty;

                //set focus to the miles textbox
                scoreOneTextBox.Focus();
            }
        }
    }
}
