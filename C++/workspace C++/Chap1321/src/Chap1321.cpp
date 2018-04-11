//============================================================================
// Name        : Chap1321.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/12/2016
// Description : Chapter 13 – Exercise 21
// Determine shipping charge based on zip code
//============================================================================


#include <iostream>
#include <string>
using namespace std;

//Prototype functions
string enterZipCode();

// ----- main method -----
int main()
{
	//declare variables
	string zipCode = "";
	//dsp end loop msg
	cout << "ENTER AN X TO STOP ZIP CODE DATA ENTRY." << endl << endl;
	//call lower level method storing returned value as zipCode
	zipCode = enterZipCode();
	//while loop test for endl loop value
	while (zipCode != "x" && zipCode != "X")
	{

			// if statment test string for correct length
			if (zipCode.length() == 10)
			{
				//if statment test string for either 199 or 198
				if (zipCode.substr(0, 3) == "199" || zipCode.substr(0, 3) == "198")
				{
					//if statment test for 199 zipCodes
					if (zipCode.substr(0, 3) == "199")
					{
						//dsp shipping cost msg
						cout << "Shipping charge for zip code " << zipCode << " is $25.00." << endl << endl;
					}
					else
					{
						//dsp shipping cost msg
						cout << "Shipping charge for zip code " << zipCode << " is $30.00." << endl << endl;
					}
				}
				else
				{
					//dsp wrong zipcode msg
					cout << "Zip code must begin with 199 or 198." << endl << endl;

				}
			}
			else
			{
				//dsp wrong amount of characters msg
				cout << "Zip code must contain exactly 10 characters." << endl << endl;

			}
	//calls enter zipcode method storing returned value
	zipCode = enterZipCode();

	}
	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}

// ----- enterZipCode method -----
//accepts no variables returns one value
//ask user to enter zipcode and returns zipcode to main method
string  enterZipCode()
{
	//declare variable
	string zipCode = "";
	//prompt user
	cout << "Enter Zip Code: ";
	//stores user input
	getline(cin, zipCode);
	//returns variable
	return zipCode;
}
