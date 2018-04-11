// Brandon Veasey
// 03/20/2018
// Chapter 10 – Programming Exercise 2
// Enter, manipulate, and display a date using multiple classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateGUI
{
    class DatesUpdate : Dates
    {
        // ----- UpdateDates -----
        // accepts no parameters
        //  calculates new date
        public string UpdateDates()
        {
            // Find month
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if(day < 31)
                    {
                        // not the last day of month
                        day++;
                    }
                    else
                    {
                        // last day of month
                        month++;
                        day = 1;
                    }
                    break;
                case 2:
                    if ((year % 400 == 0 || year % 100 != 0) && (year % 4 == 0))
                    {
                        // It is a leap year
                        if (day < 29)
                        {
                            // not the last day of month
                            day++;
                        }
                        else
                        {
                            // last day of month
                            month++;
                            day = 1;
                        }
                    }
                    else
                    {
                        // It is not a leap year
                        if (day < 28)
                        {
                            // not the last day of month
                            day++;
                        }
                        else
                        {
                            // last day of month
                            month++;
                            day = 1;
                        }
                    }
                    break;
                case 12:
                    if (day < 31)
                    {
                        // not the last day of month
                        day++;
                    }
                    else
                    {
                        // last day of month and year
                        month = 1;
                        day = 1;
                        year++;
                    }
                    break;
                default:
                    if (day < 30)
                    {
                        // not the last day of month
                        day++;
                    }
                    else
                    {
                        // last day of month
                        month++;
                        day = 1;
                    }
                    break;
            }
                
            return month + "/" + day + "/" + year;
        }
    }
}
