//============================================================================
// Name        : Chap1226.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 4/11/2016
// Description : Chapter 12 – Exercise 26
// Calculate bonus amount for each employee and a total bonus amount for all employees
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

//Prototype functions
void displayColumnHeadings();
void displayTotalBonus(double);

int main()
{
	//declare variables
	double rate = 0.0;
	int total = 0;
	double totalBonus = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(2);

	//declare array
	int salesArray[10][3] = {{2400, 3500, 2000},
							 {1500, 7000, 1000},
							 {1600, 2450, 3100},
							 {1790, 2240, 3500},
							 {1000, 2000, 3000},
							 {3300, 2000, 4100},
							 {1300, 3450, 4700},
							 {2700, 3500, 2200},
							 {4700, 3800, 1300},
							 {1200, 2300, 3400}};

	cout << "Enter Bonus Rate in Decimal Form: ";
	cin >> rate;

	//call lower level method
	displayColumnHeadings();

	//for loop allows user to enter high and low temps stored in array
	for (int sales = 0; sales < 10; sales += 1)
	{
		//for loop to accumulate total
		for(int month = 0; month < 3; month += 1)
		{
			total += salesArray[sales][month];

		}
		// if statment used to correctly space numbers when displayed to user
		if (sales == 9)
		{
			cout << " " << sales +1 << "       " << total << "      " << total * rate << endl;
			totalBonus += (total * rate);  // accumulates total bonus
			total = 0; // sets total to 0
		}
		else
		{
			cout << "  " << sales +1 << "       " << total << "      " << total * rate << endl;
			totalBonus += (total * rate);// accumulates total bonus
			total = 0;// sets total to 0
		}
	}

	//call displayTotalBonus passing calculated total bonus
	displayTotalBonus(totalBonus);

	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}
//----- displayColumnHeadings -----
//displays heading
void displayColumnHeadings()
{
	cout << endl << "SLsno     Sales     Bonus" << endl;
	cout << "-----     -----     -------"  << endl;
}

//----- displayTotalBonus -----
//accepts calculated total bonus
//displays footing and calculated total bonus msg
void displayTotalBonus(double totalBonus)
{
	cout << "                   ---------"  << endl;
	cout << "Total Bonuses:     $" << totalBonus << endl;
}
