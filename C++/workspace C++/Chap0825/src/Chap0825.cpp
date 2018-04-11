//============================================================================
// Name        : Chap0825.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 02/24/2016
// Description : // Chapter 8 – Exercise 25
// Calculate raise amounts for three years based on various rates
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declare variables
	int salary = 0;
	double raise = 0.0;
	int newSalary = 0;

	//set number of decimal places
	cout << fixed << setprecision(0);

	// TELLS USER HOW TO END LOOP
	cout << "ENTER A NEGATIVE NUMBER TO STOP DATA ENTRY." << endl << endl;

	//prompt user and store input
	cout << "Enter Salary: ";
	cin >> newSalary;

	do
	{

		for (double rate  = .03; rate < .07; rate += .01)
		{
			cout << "Raise rate is " << rate * 100 << "%" << endl;
			salary = newSalary;
			//for statment prints out raise statment and raise amount
			for (int year = 1; year < 4; year += 1)
			{
				raise = salary * rate;
				cout << "year " << year << " raise amount; $" << raise << endl;
				salary += raise;
			}
		}
		// ask for new salary
		cout << endl << "Enter Salary: " ;
		cin >> newSalary;

	}while(newSalary > 0 );// test end loop test

	//end program
	cout << endl;
	cout << "End of Program.";
	return 0;
}


