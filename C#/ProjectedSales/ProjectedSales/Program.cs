// Brandon Veasey
// 01/11/2018
// Chapter 2 – Programming Exercise 3
// Projected Sales Increase

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double northCurrent = 4000;
            double southCurrent = 5500;
            double northProjected = 0;
            double southProjected = 0;


            //declare constants
            const double SALES_INCREASE = .10;

            //calc projected sales
            northProjected = northCurrent + (northCurrent * SALES_INCREASE);
            southProjected = southCurrent + (southCurrent * SALES_INCREASE);

            //display calculated msg
            Console.WriteLine("North division <current> " + northCurrent + " - <projected> " + northProjected + " next year." );
            Console.WriteLine("South division <current> " + southCurrent + " - <projected> " + southProjected + " next year.");
        }
    }
}
