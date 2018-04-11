// Brandon Veasey
// 01/11/2018
// Chapter 2 - Programming Exercise 4
// Projected Sales Increase - Interactive

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedSalesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int northCurrent = 0;
            int southCurrent = 0;
            double northProjected = 0;
            double southProjected = 0;
            string northString = "";
            string southString = "";

            //declare constants
            const double SALES_INCREASE = .10;

            //prompt user for input
            Console.Write("Enter current sales for the North division >> ");

            //store user input
            northString = Console.ReadLine();

            //convert entered string to double
            northCurrent = Convert.ToDouble(northString);

            //prompt user for input
            Console.Write("Enter current sales for the South division >> ");

            //store user input
            southString = Console.ReadLine();

            //convert entered string to double
            southCurrent = Convert.ToDouble(southString);

            //calc projected sales
            northProjected = northCurrent + (northCurrent * SALES_INCREASE);
            southProjected = southCurrent + (southCurrent * SALES_INCREASE);

            //display calculated msg
            Console.WriteLine("North division <current> " + northCurrent.ToString() + " - <projected> " + northProjected.ToString() + " next year.");
            Console.WriteLine("South division <current> " + southCurrent.ToString() + " - <projected> " + southProjected.ToString() + " next year.");
        }
    }
}
