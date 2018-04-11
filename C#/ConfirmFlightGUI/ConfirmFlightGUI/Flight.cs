// Brandon Veasey
// 03/06/2018
// Chapter 9 – Programming Exercise 1
// Instantiate an object to display flight information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmFlightGUI
{
    class Flight
    {
        // declare variables 
        private string flightName;
        private int flightNum;
        private int row;
        private char seat;

        // ----- GetAirline -----
        // sets value of flightName if passed a value via set
        // returns a value is nothing is passed via get
        public string GetAirline
        {
            get
            {
                return flightName;
            }
            set
            {
                flightName = value;
            }
        }

        // ----- GetFlightNum -----
        // sets value of flightNum if passed a value via set
        // returns a value is nothing is passed via get
        public int GetFlightNum
        {
            get
            {
                return flightNum;
            }
            set
            {
                flightNum = value;
            }
        }

        // ----- GetRow -----
        // sets value of row if passed a value via set
        // returns a value is nothing is passed via get
        public int GetRow
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        // ----- GetSeat -----
        // sets value of seat if passed a value via set
        // returns a value is nothing is passed via get
        public char GetSeat
        {
            get
            {
                return seat;
            }
            set
            {
                seat = value;
            }
        }

        // ----- default constructor -----
        // initilizes values to defults
        // accepts no arguments
        public Flight()
        {
            flightName = "";
            flightNum = 0;
            row = 0;
            seat = ' '; 
        }
    }
}
