// Brandon Veasey
// 01/11/2018
// Chapter 2 – Programming Exercise 6
// Average of Test Scores - Interactive

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoresInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare constant
            const double NUM_SCORES = 5.0;

            //declare variables
            int scoreOne = 91;
            string stringOne = "";
            int scoreTwo = 75;
            int scoreThree = 88;
            int scoreFour = 100;
            int scoreFive = 95;
            double avgScore = 0.0;

            //prompt user for input
            Console.Write("Enter first test score ----> ");

            //store user input
            stringOne = Console.ReadLine();

            //convert entered string to double
            scoreOne = Convert.ToDouble(stringOne);

            //prompt user for input
            Console.Write("Enter second test score ---> ");

            //store user input
            stringOne = Console.ReadLine();

            //convert entered string to double
            scoreTwo = Convert.ToDouble(stringOne);

            //prompt user for input
            Console.Write("Enter thired test score ---> ");

            //store user input
            stringOne = Console.ReadLine();

            //convert entered string to double
            scoreThree = Convert.ToDouble(stringOne);

            //prompt user for input
            Console.Write("Enter fourth test score ---> ");

            //store user input
            stringOne = Console.ReadLine();

            //convert entered string to double
            scoreFour = Convert.ToDouble(stringOne);

            //prompt user for input
            Console.Write("Enter five test score ----> ");

            //store user input
            stringOne = Console.ReadLine();

            //convert entered string to double
            scoreFive = Convert.ToDouble(stringOne);

            //calc avg
            avgScore = (scoreOne + scoreTwo + scoreThree + scoreFour + scoreFive) / NUM_SCORES;

            Console.WriteLine("The average of the five test scores is " + avgScore.ToString("n3") + ".");
        }
    }
}
