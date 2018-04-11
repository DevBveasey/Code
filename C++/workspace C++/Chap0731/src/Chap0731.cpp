//============================================================================
// Name        : Chap0731.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 02/17/16
// Description : // Chapter 7 – Exercise 31
// Calculate raise amounts and total salary for a three year period
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declare variables
	double salary = 0.0;
	const double raisePercent = .05;
	int year = 1;
	double avgRaise = 0.0;
	double totalSalary = 0.0;
	double raise = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(2);

	//prompt user and store input
	cout << "Enter Annual Salary: ";
	cin >> salary;
	cout << endl;

	while (year < 4)
	{
		raise = salary * raisePercent;
		avgRaise += raise;
		salary += raise;
		totalSalary += salary;
		cout << "year " << year << " raise amount: $" << raise << endl;
		year ++;
	}

	avgRaise /= 3;
	cout << "                     --------" << endl;
	cout << "Average raise amount $" << avgRaise << endl << endl;

	cout << "Total salary for the three year period: $" << totalSalary << endl;

	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}
