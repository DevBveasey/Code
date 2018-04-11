//============================================================================
// Name        : MidtermExam.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 02/29/16
// Description : Introduction to O-O Programming
// Calculate total income and expenses, average income and average expenses, and profit or loss
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//declare variables
	double totalIncome = 0.0;
	double totalExpenses = 0.0;
	double avgIncome = 0.0;
	double avgExpenses = 0.0;
	int incomeCount = 0;
	int expensesCount = 0;
	double netTotal = 0.0;
	double income = 0.0;
	double expenses = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(2);

	// income msg to prompt user to enter primer data value and store it
	cout << "ENTER A NEGATIVE NUMBER TO STOP INCOME AMOUNT DATA ENTRY." << endl << endl ;
	cout << "Enter Income Amount: ";
	cin >> income;

	// loop allows user to enter any number of data entrys using any negative number to end loop
	while (income > -1)
	{
		totalIncome += income; // adds data entry to total as accumulator
	    incomeCount += 1;      //adds one to count
	    cout << "Enter Income Amount: "; // prompts user for entry and stores data entered
	    cin >> income;
	}
	avgIncome = totalIncome / incomeCount; // calculates avg
	cout << endl;

	// expenses msg to prompt user to enter primer data value and store it
	cout << "ENTER A NEGATIVE NUMBER TO STOP EXPENSES AMOUNT DATA ENTRY." << endl << endl;
	cout << "Enter Expenses Amount: ";
	cin >> expenses;

	// loop allows user to enter any number of data entrys using any negative number to end loop
	while (expenses > -1)
	{
		totalExpenses += expenses; // adds data entry to total as accumulator
		expensesCount += 1;        //adds one to count
		cout << "Enter Expenses Amount: "; // prompts user for entry and stores data entered
		cin >> expenses;
	}

	avgExpenses = totalExpenses / expensesCount; // calculates avg
	cout << endl;

	// dsp income total and avg
	cout << "Total of the " << incomeCount << " Income Amounts Entered:  " << totalIncome << "     ";
	cout << "Average Income Amount:  " << avgIncome << endl;

	// dsp expenses total and avg
	cout << "Total of the " << expensesCount << " Expense Amounts Entered: " << totalExpenses << "     ";
	cout << "Average Expense Amount: " << avgExpenses << endl;

	cout << "                                       --------" << endl;
	netTotal = totalIncome - totalExpenses; // calculates net total

	// if statment displays either profit or loss msg with amount
	if (netTotal > 0)
		cout << "Net Profit Earned:                     $" << netTotal << endl;
	else
		cout << "Net Loss Incurred:                     " << netTotal << endl;

	//end program
	cout << endl;
	cout << "End of Program.";
	return 0;
}
