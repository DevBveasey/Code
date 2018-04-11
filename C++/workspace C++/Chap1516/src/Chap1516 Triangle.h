//============================================================================
// Name        : Chap1516Triangle.h
// Author      : Brandon Veasey
// Version     :
// Copyright   : 04/25/2016
// Description : Chapter 15 – Exercise 16
// 				 Calculate the area and parameter of a triangle using an instantiated triangle object
//               HEADER FILE
//============================================================================

//declaration section
class Triangle
{
public:
	Triangle();
	void setDimensions(double, double, double, double);
	double calculateArea();
	double calculateParameter();

private:
	double sideOne;
	double sideTwo;
	double height;
	double base;
	double area;
	double parameter;
};

//implementation section
Triangle::Triangle()
{
	sideOne   = 0.0;
	sideTwo   = 0.0;
	height    = 0.0;
	base      = 0.0;
	area      = 0.0;
	parameter = 0.0;
} // end of default constructor

void Triangle::setDimensions (double baseIn, double heightIn, double sideOneIn, double sideTwoIn)
{
	if (baseIn > 0.0)
		base = baseIn;
	else
		base = 0.0;

	if (heightIn > 0.0)
		height = heightIn;
	else
		height = 0.0;

	if (sideOneIn > 0.0)
		sideOne = sideOneIn;
	else
		sideOne = 0.0;

	if (sideTwoIn > 0.0)
		sideTwo = sideTwoIn;
	else
		sideTwo = 0.0;


}//end setDimensions method

double Triangle::calculateArea()
{
	area = .5 * base * height;
	return area;
}//end calculateArea method

double Triangle::calculateParameter()
{
	parameter = base + sideOne + sideTwo;
	return parameter;
} //end of calculatePerimeter method



