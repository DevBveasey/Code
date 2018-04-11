//============================================================================
// Name        : Chap0512.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : Your copyright notice
// Description : Chapter 5 – Exercise 12
// Buy one item and get one item half off
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declaring variables
	double itemOne = 0.0;
	double itemTwo = 0.0;
	double lowestPrice = 0.0;
	double halfOffPrice = 0.0;
	double savings = 0.0;
	double totalAmount = 0.0;

	//prompt user and store input
	cout << "Enter First Item Price: ";
	cin >> itemOne;
	cout << "Enter Second Item Price: ";
	cin >> itemTwo;
	cout << endl;

	//if statement declares lowest price
	if (itemOne >= itemTwo)
	{
		lowestPrice = itemTwo;
		itemTwo = itemOne;
	}
	else
	{
		lowestPrice = itemOne;
	}

	//set number of decimal places
	cout << fixed << setprecision(2);

	// calculates savings and total
	savings = lowestPrice * .5;
	halfOffPrice = lowestPrice - savings;
	totalAmount = halfOffPrice + itemTwo;

	//displays total cost to user
	cout << "Total Cost: $" << totalAmount << endl;
	cout << "You Saved:  $" << savings << endl;

	//end program
	cout << endl;
	cout << "End of program.";





	return 0;
}
