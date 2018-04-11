// Brandon Veasey
// 01/11/2018
// Chapter 2 – Programming Exercise 5
// Average of Test Scores

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare constant
            const double NUM_SCORES = 5.00;

            //declare variables
            double scoreOne = 91;
            double scoreTwo = 75;
            double scoreThree = 88;
            double scoreFour = 100;
            double scoreFive = 95;
            double avgScore = 0.00;

            //calc avg
            avgScore = (scoreOne + scoreTwo + scoreThree + scoreFour + scoreFive) / NUM_SCORES;

            Console.WriteLine("The average of the five test scores is " + avgScore.ToString("n2") + ".");
        }
    }
}
