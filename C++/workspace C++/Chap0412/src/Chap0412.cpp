//============================================================================
// Name        : Chap0412.cpp
// Author      : Brandon Veasey
// Version     :
// Copyright   : Your copyright notice
// Description : Chapter 4 – Exercise 12
// Ticket revenue by seating category and total ticket revenue for all categories
//============================================================================

#include <iostream>
using namespace std;

int main()
{
	//declares variables
	int balconyTickets = 0;
	int mainTickets = 0;
	int orchestraTickets = 0;
	int orchestraRate = 25;
	int mainRate = 30;
	int balconyRate = 15;
	int balconyTotal = 0.0;
	int mainTotal = 0.0;
	int orchestraTotal = 0.0;
	int totalTickets = 0;

	//display ticket header
	cout << "PROCESS TICKET ORDERS";

	//capture user input
	cout << endl;
	cout << "Orchestra Section: ";
	cin >> orchestraTickets;
	cout << "Main Floor: ";
	cin >> mainTickets;
	cout << "Balcony Section: ";
	cin >> balconyTickets;
	cout << endl;

	//calculate totals
	balconyTotal = balconyTickets * balconyRate;
	mainTotal = mainTickets * mainRate;
	orchestraTotal = orchestraTickets * orchestraRate;
	totalTickets = balconyTickets + mainTickets + orchestraTickets;

	//display revenue header
	cout << "REVENUE GENERATED" << endl;

	//DISPLAY TOTALS
	cout << "Orchestra........ " << orchestraTotal << endl;
	cout << "Main Floor....... " << mainTotal << endl;
	cout << "balcony.......... " << balconyTotal << endl;
	cout << "Total............ $" << balconyTotal + mainTotal + orchestraTotal << endl;
	cout << endl;
	cout << "Tickets Sold..... " << totalTickets << endl;

	//end program
	cout << endl;
	cout << "End of program.";
}
