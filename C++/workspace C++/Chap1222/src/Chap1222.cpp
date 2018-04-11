//============================================================================
// Name        : Chap1222.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/06/2016
// Description : Chapter 12 – Exercise 22
// Determine high and low temperature averages
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

//Prototype functions
int enterTemps(int temperatures[7][2]);
int calculateAvgTemps(int temperatures[7][2], double &, double &);
void displayAvgTemps(double avgHigh, double avgLow);

// ----- main method -----
// calls lower level methods
int main()
{
	//Declare temperatures array
	int temperatures[7][2] = {0};

	//declare variables
	double avgHigh = 0.0;
	double avgLow = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(1);

	// calling lower level methods
	enterTemps(temperatures);
	calculateAvgTemps(temperatures, avgHigh, avgLow);
	displayAvgTemps(avgHigh, avgLow);

	//end program
	cout << endl;
	cout << "End of Program.";

	return 0;
}
// ----- enterTemps method -----
// gets high and low temps form user
int enterTemps(int temperatures[7][2])
{

	//for loop allows user to enter high and low temps stored in array
	for (int days = 0; days < 7; days += 1)
	{
		//get Highest Temp
		cout <<"Enter Highest Temperature for Day " << days +1 << ": " ;
		cin >> temperatures[days][0];

		//get lowest Temp
		cout << " Enter Lowest Temperature for Day " << days + 1 << ": " ;
		cin >> temperatures[days][1];
	}

	//returns array
	return temperatures[7][2];
}

// ----- calculateAvgTemps method -----
// accepts array referencing high and low averages
int calculateAvgTemps(int tempertures[7][2], double &avgHigh, double &avgLow)
{
	//declare variables
	double totalHigh = 0;
	double totalLow = 0;

	//for loop used to go through array accumulating high and low temp total
	for(int days = 0; days < 7; days += 1)
	{
		//accumulate high total
		totalHigh += tempertures[days][0];

		//accumulate high total
		totalLow += tempertures[days][1];
	}

	//calculate averages
	avgHigh = totalHigh / 7;
	avgLow = totalLow / 7;


	return 0;
}

// ----- displayAvgTemps method -----
// accepts high and low averages for display to user
void displayAvgTemps(double avgHigh, double avgLow)
{
	//display msg to user
	cout << endl <<  "Average high temperatures was " << avgHigh << " degrees." ;
	cout << endl <<"Average low temperatures was " << avgLow << " degrees." << endl;
}
