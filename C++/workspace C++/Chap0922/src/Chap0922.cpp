//============================================================================
// Name        : Chap0922.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/09/16
// Description :Chapter 9 – Exercise 22
// Calculate gross pay for each employee and total gross pay
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

//Global variable
double totalGrossPay = 0.0;

//Prototype functions
double calculateGrossPay(double, double);
double accumulateTotalGross(double);

int main()
{
	//declare variables
	double hours = 0.0;
	double payRate = 0.0;
	double grossPay = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(2);

	// how to end loop msg
	cout << "ENTER A NEGATIVE NUMBER TO STOP HOURS WORKED DATA ENTRY." << endl << endl;

	//prompt user and store input
	cout << "Enter Hours Worked: ";
	cin >> hours;

	//BEGIN loop
	while (hours > -1)
	{
		//prompt user and store input
		cout << "Enter Pay Rate: ";
		cin >> payRate;

		grossPay = calculateGrossPay(hours, payRate); // call lower method passing two variables storing the returned
		totalGrossPay = accumulateTotalGross(grossPay);// call lower method passing one variable storing the returned
		cout << "Gross pay for this employee: $" << grossPay << endl << endl;

		//prompt user and store input
		cout << "Enter Hours Worked: ";
		cin >> hours;


	}//end loop

	//dsp total gross msg
	cout << endl <<"Total gross pay for all employees: $" << totalGrossPay << endl ;

	//end program
	cout << endl;
	cout << "End of Program.";
	return 0;
}

//---------calculateGrossPay ----------
//excepts two variables returning one variable
// calculates gross pay
double  calculateGrossPay(double hours, double payRate)
{
	//declare variable
	double overTime = 0.0;
	double overTimePay = 0.0;
	double grossPay = 0.0;

	//Determines overtime and calculates gross pay
	if (hours > 40)
	{
		overTime = hours - 40;
		overTimePay = payRate * 1.5;
		grossPay = (40 * payRate) + (overTime * overTimePay);

	}
	else
		grossPay = hours * payRate;

	//Returns calculated grossPay
	return (grossPay);
}

//---------accumulateTotalGross ----------
//excepts one variable returning one variable
// accumulates grossPay
double accumulateTotalGross(double grossPay)
{
	//calculates totalGrossPay
	totalGrossPay =  totalGrossPay + grossPay;

	//returns accumulated grossPay
	return (totalGrossPay);
}
