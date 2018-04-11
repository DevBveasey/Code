//============================================================================
// Name        : Chap0923.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 03/09/16
// Description : Chapter 9 – Exercise 23
// Collect three test scores and calculate an average test score
//============================================================================

#include <iostream>
#include <iomanip>
using namespace std;

//Prototype functions
double getTestScore();
double calculateAverage(double, double, double);

int main()
{
	//Declare variables
	double scoreOne = 0.0;
	double scoreTwo = 0.0;
	double scoreThree = 0.0;
	double avg = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(1);

	//call getTestScore storing returned value as score 1-3
	scoreOne = getTestScore();
	scoreTwo = getTestScore();
	scoreThree = getTestScore();

	//call calculateAverage passing three variables,storing returned value as avg
	avg = calculateAverage(scoreOne, scoreTwo, scoreThree);

	cout << endl << "Average of test scores is " << avg << endl;

	//end program
	cout << endl;
	cout << "End of Program.";
	return 0;
}

//--------- getTestScore ----------
//excepts no variables returning one variable
double  getTestScore()
{
	//declare local variable
	double score = 0.0;

	//prompt user and store input
	cout << "Enter Test Score: ";
	cin >> score;

	return (score);
}

//--------- calculateAverage ----------
//excepts three variables returning one variable
double  calculateAverage(double scoreOne, double scoreTwo, double scoreThree )
{
	//declare local variable
	double avg = 0.0;

	//calculate average
	avg = (scoreOne + scoreTwo + scoreThree) / 3;

	//return variable
	return (avg);
}
