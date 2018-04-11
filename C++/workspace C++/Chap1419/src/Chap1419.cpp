//============================================================================
// Name        : Chap1419.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/19/2016
// Description : Chapter 14 – Exercise 19
// Capturing and writing employee data to a sequential access text file
//============================================================================

#include <iostream>
#include <string>
#include <fstream>
using namespace std;

//prototypes
void processFile();

int main()
{
	//call processFile
	processFile();

	// saved msg
	cout << endl << "Payroll names and amounts successfully saved to Payroll.txt file.";

	//end program
	cout << endl << endl;
	cout << "End of Program.";
	return 0;
}

void processFile()
{
	//declare variables
	string employeeName = "";
	string amount = "";

	//create file object and open file
	ofstream outFile;
	outFile.open("Payroll.txt", ios::app);

	//get employee name
	cout << "ENTER XXX TO STOP PAYROLL NAME AND AMOUNT DATA ENTRY." << endl << endl;
	cout << "Enter Employee Last Name: " ;
	getline(cin, employeeName);
	while (employeeName!= "XXX")
	{
		//get amount
		cout << "Enter Payroll Amount: ";
		getline(cin, amount);

		//write to record
		outFile << employeeName << '#' << amount << endl;

		//get another employee name
		cout << "Enter Employee Last Name: " ;
		getline(cin, employeeName);
	}//end loop

	//close file
	outFile.close();


}
