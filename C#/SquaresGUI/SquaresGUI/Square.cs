// Brandon Veasey
// 03/06/2018
// Chapter 9 – Programming Exercise 2
// Instantiate an array of square objects to display the area of each square

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresGUI
{
    class Square
    {
        // declare variables
        private int length;
        private int area;

        // ----- GetSide -----
        // sets value of length if passed a value via set
        // returns a value is nothing is passed via get
        public int GetSide
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        // ----- GetArea -----
        // sets value of area if passed a value via set
        // returns a value is nothing is passed via get
        public int GetArea
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        // ----- CalcArea -----
        // calculates the area of the square
        // stores calculated area
        private void CalcArea()
        {
            // calculate area
            area = length * length;
        }

        // ----- constructor -----
        // sets defult value to area and passed value to length
        // accepts one argument , length
        public Square(int passedlength)
        {
            length = passedlength;
            CalcArea();// sets the calculated area 
        }
    }
}
