//============================================================================
// Name        : Chap1422.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/19/2016
// Description : Chapter 14 � Exercise 22
// Reading and displaying employee data contained in a sequential access text file
//============================================================================


#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;

//prototypes
void processFile();

// ----- Main method -----
//displays heading and calls lower method
int main()
{

	//call processFile
	processFile();

	return 0;
}

// -----processFile method -----
//reads file and display record
//displays accumulated total pay
void processFile()
{
	//declare variables
	string employeeName = "";
	double amount = 0.0;
	double totalPay = 0.0;

	//open file
	ifstream inFile;
	inFile.open("Payroll.txt", ios::in);

	//set number of decimal places
	cout << fixed << setprecision(2);

	// test to see if file opened
	if (inFile.is_open())
	{
		//display heading
		cout << "     ABC COMPANY   " << endl;
		cout << "Weekly Payroll Report" << endl;
		cout << endl << "Name            Amount" << endl;
		cout << "-------         ------" << endl;
		// reads file till end of line
		while (!inFile.eof())
		{
			//read a record
			getline(inFile, employeeName, '#');
			inFile >> amount;
			inFile.ignore();
			//accumulator for total pay
			totalPay += amount;
			cout << employeeName << '\t' << '\t'<< amount << endl;
			}//end while
			//close file
			inFile.close();
			//display footing and total pay msg
			cout << "              --------";
			cout << endl << "Total Payroll $" << totalPay;

			//end program
			cout << endl << endl;
			cout << "End of Report.";
			}
		else
		{
			cout << "PROCESSING ERROR..." << endl << endl;
			cout << "Payroll.txt file could not be opened." << endl << endl;
			cout << "Program Terminated.";

		}//end if

}
