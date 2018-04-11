// Brandon Veasey
// 03/20/2018
// Chapter 10 – Programming Exercise 2
// Enter, manipulate, and display a date using multiple classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateGUI
{
    class Dates
    {
        // declare feilds
        public int month;
        public int day;
        public int year;
        public string date;

        // ----- SetDate -----
        // stores the passed user date in the appropiate feilds
        // accepts three ints
        public void SetDate(int month1, int day1, int year1)
        {
            // set passed values to feilds
            month = month1;
            day = day1;
            year = year1;
        }

        // ----- BuildDate -----
        // accepts no parameters
        // returns the date in format mm/dd/yyyy
        public string BuildDate()
        {
            date = month + "/" + day + "/" + year;
            return date;
        }

        // ----- Default constructor -----
        // initilizes ints to 0 and string to an empty string
        public Dates()
        {
            month = 0;
            day = 0;
            year = 0;
            date = "";
        }
    }
}
