//============================================================================
// Name        : Chap1130.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/23/2016
// Description : Chapter 11 – Exercise 30
// Generate random lottery numbers
//============================================================================

#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;

//Prototype functions
void displayNumbers(int []);
int generateNumbers(int []);

int main()
{
	//declare array
	int numbersArray[6] = {0};


	//call lower method to generate numbers
	generateNumbers(numbersArray);

	//call lower method for display
	displayNumbers(numbersArray);

	//end program
	cout << endl << endl;
	cout << "End of Program.";

	return 0;
}
int generateNumbers(int numbersArray[])
{
	//Initialize number generator
	srand(static_cast<int>(time(0)));

	//for loop generates 6 random numbers
	for (int index = 0; index < 6; index += 1)
	{
		// generates a random number and stores it in the respective indexed slot
		numbersArray[index] = 1 + rand() % (55 - 1 + 1);
	}
	return 0;
}

void displayNumbers(int numbersArray[])
{
	//display random numbers msg
	cout << "Weekly Lottery Numbers ---> ";

	//display each number in each slot
	for (int index = 0; index < 6; index += 1)
		{
			cout << numbersArray[index] << " ";
		}

}
