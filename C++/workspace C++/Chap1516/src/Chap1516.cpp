//============================================================================
// Name        : Chap1516.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/25/2016
// Description : Chapter 15 – Exercise 16
// Calculate the area and perimeter of a triangle using an instantiated triangle object
//============================================================================

#include <iostream>
#include "Chap1516 Triangle.h"
#include <iomanip>
using namespace std;

int main()
{
	//instantiate Triangle object
	Triangle shape;

	//declare variables
	double base = 0.0;
	double height = 0.0;
	double sideOne = 0.0;
	double sideTwo = 0.0;
	double area = 0.0;
	double parameter = 0.0;

	//set number of decimal places
	cout << fixed << setprecision(0);

	//display user prompt msg
	cout << "Enter Triangle Dimensions..." << endl << endl;

	// get measurements
	cout << "Base: ";
	cin >> base;
	cout <<"Height: ";
	cin >> height;
	cout << "Side One Length: ";
	cin >> sideOne;
	cout << "Side Two Length: ";
	cin >> sideTwo;

	// assign measurements
	shape.setDimensions(base, height, sideOne, sideTwo);

	//calculate and display area
	area = shape.calculateArea();
	cout << endl <<"Area of triangle is " << area << "." << endl;

	//calculate and display area
	parameter = shape.calculateParameter();
	cout << "Perimeter of triangle is " << parameter << "." << endl;

	//end program
	cout << endl << "End of Program.";

	return 0;
}
