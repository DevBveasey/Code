// Brandon Veasey
// 01/11/2018
// Chapter 2 – Programming Exercise 2
// Miles to Feet Conversion - Interactive

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeetInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const int FEET_IN_MILES = 5280;

            //variable declaration
            double distanceInMiles = 0.0;
            double distanceInFeet = 0.0;
            string entryString = "";

            //prompt user for miles
            Console.Write("Enter distance to the WAWA store in miles >> ");

            // capture user imput
            entryString = Console.ReadLine();

            //convert entered string to double
            distanceInMiles = Convert.ToDouble(entryString);

            //calc distance in feet
            distanceInFeet = distanceInMiles * FEET_IN_MILES;

            //display calculated results to user
            Console.WriteLine("The distance to the WAWA store is " + distanceInMiles + " miles or " + distanceInFeet + " feet.");
        }
    }
}
