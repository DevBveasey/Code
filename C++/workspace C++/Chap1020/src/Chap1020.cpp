//============================================================================
// Name        : Chap1020.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/16/2016
// Description : Chapter 10 – Exercise 20
// Calculate gross pay including any overtime hours worked
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;


//Prototype functions
void calculateGrossPay(double, double, double &);
double accumulateTotalGross(double, double);

int main()
{
	//declare variables
	double hours = 0.0;
	double payRate = 0.0;
	double grossPay = 0.0;
	double totalGrossPay = 0.0;

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

		calculateGrossPay(hours, payRate, grossPay); // call lower method passing two variables storing the returned
		cout << "Gross pay for this employee: $" << grossPay << endl << endl;
		totalGrossPay = accumulateTotalGross(grossPay, totalGrossPay);// call lower method passing one variable storing the returned

		//prompt user and store input
		cout << "Enter Hours Worked: ";
		cin >> hours;


	}//end loop

	//dsp total gross msg
	cout << endl <<"Total gross pay for all employees: $" << totalGrossPay << endl ;

	//end program
	cout << endl;
	cout << "End of Program.";
}

//---------calculateGrossPay ----------
//excepts two variables referencing one variable
// calculates gross pay
void calculateGrossPay(double hours, double payRate, double &grossPay)
{
	//declare variable
	double overTime = 0.0;
	double overTimePay = 0.0;

	//Determines overtime and calculates gross pay
	if (hours > 40)
	{
		overTime = hours - 40;
		overTimePay = payRate * 1.5;
		grossPay = (40 * payRate) + (overTime * overTimePay);
	}
	else
		grossPay = hours * payRate;

}

//---------accumulateTotalGross ----------
//excepts one variable referencing one variable
// accumulates grossPay
double accumulateTotalGross(double grossPay, double totalGrossPay )
{
	double placeHolder = 0.0;
	//calculates totalGrossPay
	placeHolder = totalGrossPay + grossPay;

	//returns accumulated grossPay
	return (placeHolder);
}
