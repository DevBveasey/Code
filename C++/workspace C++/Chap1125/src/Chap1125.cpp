//============================================================================
// Name        : Chap1125.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/23/2016
// Description : Chapter 11 – Exercise 25
// Determine number of days in a month using parallel one-dimensional arrays
//============================================================================

#include <iostream>
using namespace std;

//Prototype functions
void displayDays(int, string [], int []);

int main()
{
	//declare arrays
	string monthsArray[12] = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
	int daysArray[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

	//declare variables
	int monthNum = 0;

	//dsp loop end msg
	cout << "ENTER A NEGATIVE NUMBER TO STOP MONTH NUMBER DATA ENTRY." << endl << endl;

	//get month to search for
	cout << "Enter Month Number: ";
	cin >> monthNum;

	//while loop test for break code
	while (monthNum > -1)
	{


		// if statment determins if the month number entered is a valid month
		if (monthNum >= 1 && monthNum <= 12 )
		{
			// calls displayDays method passing entered month number and both arrays
			displayDays(monthNum , monthsArray, daysArray);
		}

		else
		{
			cout << "INVALID MONTH NUMBER.";
		}

		//get month to search for
		cout << endl << endl << "Enter Month Number: ";
		cin >> monthNum;

	}

	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}

// ----- displayDays -----
//lower level method accepts one variable and two arrays
// displays month and amount of days msg
void displayDays(int monthNum, string monthsArray[], int daysArray[])
{
	//display msg
	cout << "Month of " << monthsArray[monthNum - 1] << " has " << daysArray[monthNum - 1] << " days.";
}
