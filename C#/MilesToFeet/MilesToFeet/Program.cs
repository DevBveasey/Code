// Brandon Veasey
// 01/11/2018
// Chapter 2 – Programming Exercise 1
// Miles to Feet Conversion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const int FEET_IN_MILES = 5280;

            //variable declaration
            double distanceInMiles = 8.5;
            double distanceInFeet = 0.0;

            //calc distance in feet
            distanceInFeet = distanceInMiles * FEET_IN_MILES;

            //display calculated results to user
            Console.WriteLine("The distance to the WAWA store is " + distanceInMiles + " miles or " + distanceInFeet + " feet.");

        }
    }
}
