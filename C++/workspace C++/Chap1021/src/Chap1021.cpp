//============================================================================
// Name        : Chap1021.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/16/2016
// Description :Chapter 10 – Exercise 21
// Calculate commission earned and total commission earned
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

//Prototype functions
double getsalesamount(double);
void calculateCommission(double, double &);
void displayCommission(double &);
void accumulateTotalCommission(double &, double &);

int main()
{
	//declare variables
	double salesAmount = 0.0;
	double commission = 0.0;
	double totalCommission = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(2);

	// how to end loop msg
	cout << "ENTER A NEGATIVE NUMBER TO STOP SALES AMOUNT DATA ENTRY." << endl << endl;

	//call lower level method to get salesAmount
	salesAmount = getsalesamount(salesAmount);

	//BEGIN loop
	while (salesAmount > -1)
	{
		//call lower level method referencing commission passing sales Amount
		calculateCommission(salesAmount, commission);

		//call lower level method referencing commission and totalCommission
		accumulateTotalCommission(commission, totalCommission);

		//call lower level method referencing commission
		displayCommission(commission);

		//call lower level method to get salesAmount
		salesAmount = getsalesamount(salesAmount);

		}//end loop

	//display total commission msg
	cout << endl <<"Total commission earned (all sales) ---> " << totalCommission << endl;

	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}

// ---------- getsalesamount ----------
// excepts one variable returning entered stored salesAmount
double getsalesamount(double salesAmount)
{

	//prompt user and store input
	cout << "Enter Sales Amount: ";
	cin >> salesAmount;

	//return entered sales amount
	return salesAmount;
}

// ---------- calculateCommission ----------
// excepts one variable referencing commission
// calculates commission
void calculateCommission(double salesAmount, double &commission)
{
	commission = salesAmount * .10;
}

// ---------- accumulateTotalCommission ----------
// references commission and totalCommission
// accumulates totalCommission
void accumulateTotalCommission(double &commission, double &totalCommission)
{
	totalCommission += commission;
}

// ---------- displayCommission ----------
// references commission
// displays commission earned
void displayCommission(double &commission)
{
	cout << "Commission earned on sales: " << commission << endl << endl;
}
