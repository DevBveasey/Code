//============================================================================
// Name        : Chap0411.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : Your copyright notice
// Description : Chapter 4 – Exercise 11
// 					End-of-month dishwasher count
//============================================================================

#include <iostream>
using namespace std;

int main()
{
	// declaring variables
	int beginStock = 0;
	int numSold =0;
	int numPurchased =0;
	int totalStock = 0;
	int endStock = 0;

	//capture user input
	cout << "Enter the Number of Dishwashers in stock at the Beginning of the Month: ";
	cin >> beginStock;
	cout << "Enter the number of Dishwashers purchased During the Month: ";
	cin >> numPurchased;
	cout << "Enter the Number of Dishwashers sold During the Month: ";
	cin >> numSold;
	cout << endl;

	//calculate totalStock
	totalStock = beginStock + numPurchased;

	//calculate endStock//calculate endStock
	endStock = totalStock - numSold;

	//display total stock at end of month
	cout <<"Number of Dishwashers in Stock at the end of the Month is " << endStock << "."<< endl;

	//end program
	cout << endl;
	cout << "End of program.";
}
