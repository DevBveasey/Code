//============================================================================
// Name        : Chapstring.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   :01.25.16
// Description : chapter 4 string example
// 				Concatenation of first and last names entered by user
//============================================================================

#include <iostream>
using namespace std;

int main()
{
	//declares string
	string firstName = " ";
	string lastName = " ";
	string fullName = " ";

	//prompt user for first and last name
	//assign each to appropriate variable
	cout << "Enter your first name: ";
	cin >> firstName;
	cout << "Enter your last name: ";
	cin >> lastName;

	//populate variable fullname  with concatenation of first and last names
	// each name is separated by a blank space
	fullName = firstName + " " + lastName;

	//display fullname to user
	cout << endl;
	cout << "hello " << fullName << ", welcome to CIS150. " << endl;

	//end program
	cout << endl;
	cout << "end of program.";

	return 0;
}
