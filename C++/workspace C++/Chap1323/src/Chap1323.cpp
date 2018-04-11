//============================================================================
// Name        : Chap1323.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/13/2016
// Description : Chapter 13 – Exercise 23
// Determine item color code based on item number entered by user
//============================================================================

#include <iostream>
#include <string>
using namespace std;

//Prototype functions
string enterItemNumber();

int main()
{
	//declare variables
	string itemNum = "";
	//dsp end loop msg
	cout << "ENTER AN X TO STOP ITEM NUMBER DATA ENTRY." << endl << endl;
	//call lower level method storing returned value as zipCode
	itemNum = enterItemNumber();
	//while loop test for end loop value
	while (itemNum != "x" && itemNum != "X")
	{
		// if statment test string lenght
		if (itemNum.length() == 8)
		{
			//if statment test index 4 for valid color code
			//if pass dsp color msg
			//if does not pass till else then dsp invalid code msg
			if (itemNum.substr(4, 1) == "B" || itemNum.substr(4, 1) == "b")
			{
				cout << "Item color is BLUE" << endl << endl;
			}
			else if (itemNum.substr(4, 1) == "G" || itemNum.substr(4, 1) == "g")
			{
				cout << "Item color is GREEN" << endl << endl;
			}
			else if (itemNum.substr(4, 1) == "R" || itemNum.substr(4, 1) == "r")
			{
				cout << "Item color is RED" << endl << endl;
			}
			else if (itemNum.substr(4, 1) == "W" || itemNum.substr(4, 1) == "w")
			{
				cout << "Item color is WHITE" << endl << endl;
			}
			else
			{
				cout << "invalid color code found in item number." << endl << endl;
			}
		}
		else
		{
			// dsp invalid amount of characters
			cout << "Item number must contain exactly 8 characters." << endl << endl;
		}
		//call lower level method storing returned value
		itemNum = enterItemNumber();
	}

	//end program
	cout << endl ;
	cout << "End of Program.";

	return 0;
}

// ----- enterItemNumber method -----
//accepts no variables returns one value
//ask user to enter item number and returns itemNum to main method
string enterItemNumber()
{
	//declare variable
	string itemNum = "";
	//prompt user
	cout << "Enter Item Number: ";
	//stores user input
	getline(cin, itemNum);
	//returns variable
	return itemNum;
}
