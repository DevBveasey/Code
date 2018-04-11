//============================================================================
// Name        : Chap0614.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : Your copyright notice
// Description :Chapter 6 – Exercise 14
//          Determine sales and calculate commission earned
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declare variables
	double monthSales = 0.0;
	double comEarned = 0.0;

	//declare constants
	const double NO_SALE = .00;
	const double RATE_ONE = .04;
	const double RATE_TWO = .05;
	const double RATE_THREE = .06;
	const double RATE_FOUR = .07;
	const double RATE_FIVE = .09;

	//prompt user and store input
	cout << "Enter sales: ";
	cin >> monthSales;
	cout << endl;

	//set number of decimal places
	cout << fixed << setprecision(2);

	//if statements detimins commission rate and calculates commissioned earned
		if (monthSales == 0 )
		{
			comEarned = monthSales * NO_SALE;
			cout << "Commission Earned: $" << comEarned;

		}
		else if (monthSales >= 1 && monthSales <=19999.99)
		{
			comEarned = monthSales * RATE_ONE;
			cout << "Commission Earned: $" << comEarned;

		}
		else if (monthSales >= 20000 && monthSales <=29999.99)
		{
			comEarned = monthSales * RATE_TWO;
			cout << "Commission Earned: $" << comEarned;

		}
		else if (monthSales >= 30000 && monthSales <=39999.99)
		{
			comEarned = monthSales * RATE_THREE;
			cout << "Commission Earned: $" << comEarned;

		}
		else if (monthSales >= 40000 && monthSales <=49999.99)
		{
			comEarned = monthSales * RATE_FOUR;
			cout << "Commission Earned: $" << comEarned;

		}
		else if (monthSales >= 50000)
		{
			comEarned = monthSales * RATE_FIVE;
			cout << "Commission Earned: $" << comEarned;

		}
		else
		cout << "INVALID ENTRY – Please try again.";

	//end program
	cout << endl;
	cout << endl;
	cout << "End of Program.";




	return 0;
}
