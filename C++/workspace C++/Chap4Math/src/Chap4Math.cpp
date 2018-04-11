//============================================================================
// Name        : Chap4Math.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 01.25.16
// Description : Chapter 4 math example
//				calculate tip amount base on user input
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//variable declaration
	double totalBill = 0.0;
	double liquorAmount = 0.0;
	double tipPercent = 0.0;
	double billNoLiquor = 0.0;
	double tipAmount = 0.0;
	double totalCharge = 0.0;

	//prompt user to enter bill amount, liquor charge, and tip percent
	//assign each to appropriate variable
	cout << "Enter total bill amount:";
	cin >> totalBill;
	cout << "Enter liquor amount:";
	cin >> liquorAmount;
	cout << "Enter tip percent in decimal form:";
	cin >> tipPercent;

	//calculate total bill without liquor charge
	billNoLiquor = totalBill - liquorAmount;

	//calculate tip amount
	tipAmount = billNoLiquor * tipPercent;

	//calculate total charge
	totalCharge = totalBill + tipAmount;

	//set number of decimal places
	cout << fixed << setprecision(2);

	//display tip amount and total charge to user
	cout << endl;
	cout << "tip amount is $" << tipAmount << endl;
	cout << "total charged is $" << totalCharge << endl;

	//end program
	cout << endl;
	cout << "End of program.";

	return 0;
}
