//============================================================================
// Name        : Chap0613.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : Your copyright notice
// Description : Chapter 6 – Exercise 13
// Determine number of registrants and calculate total cost
//============================================================================

#include <iostream>
using namespace std;

int main()
{
	//declare variables
	int numReg = 0;
	double  total = 0.0;

	//declare constants
	const double LOW_REG_RATE = 100.00;
	const double MID_REG_RATE = 80.00;
	const double HIGH_REG_RATE = 60.00;

	//prompt user and store input
	cout << "Enter Number of Registrants: ";
	cin >> numReg;
	cout << endl;

	//if statements
	if ( numReg >= 0)
	{
		if (numReg >= 1 && numReg <=4)
		{
			total = (LOW_REG_RATE * numReg);
			cout << "Total Cost: $" << total;

		}
		else if (numReg >= 5 && numReg <=10)
		{
			total = (MID_REG_RATE * numReg);
			cout << "Total Cost: $" << total;

		}
		else if (numReg >= 11)
		{
			total = (HIGH_REG_RATE * numReg);
			cout << "Total Cost: $" << total;

		}
		else
			cout << "INVALID ENTRY – Please Try Again.";
	}

	//end program
	cout << endl;
	cout << endl;
	cout << "End of Program.";

	return 0;
}
