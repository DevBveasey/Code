//============================================================================
// Name        : Chap0511.cpp
// Author      : Brandon veasey
// Version     :
// Copyright   : Your copyright notice
// Description : Chapter 5 – Exercise 11
// Calculate order total - with or without shipping charge
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declaring variables
	int numOrdered = 0;
	double pricePerPound = 0.0;
	char shipping = ' ';
	const int shippingCost = 15;
	double totalCost = 0.0;

	//prompt user and store input
	cout << "Enter Pounds Ordered: ";
	cin >> numOrdered;
	cout << "Enter Price per Pound: ";
	cin >> pricePerPound;
	cout << "Add Shipping Charge? (Y or N) ";
	cin >> shipping;
	cout << endl;

	//user char variable to upper
	shipping = toupper(shipping);

	//if statement determines if the shipping cost is applied
	if (shipping == 'Y')
		totalCost = numOrdered * pricePerPound + shippingCost;
	else
		totalCost = numOrdered * pricePerPound;

	//set number of decimal places
	cout << fixed << setprecision(2);

	//displays total cost to user
	cout << "Total Order Cost: $" << totalCost;
	cout << endl;

	//end program
	cout << endl;
	cout << "End of program.";

	return 0;
}
