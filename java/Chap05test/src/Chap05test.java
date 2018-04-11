//Brandon Veasey
//10/14/2015
// Chapter 5 Test
// Capturing user input, internal method calls, external class and method calls

import java.util.Scanner;

public class Chap05test 
{
    //-----main method-----
	public static void main(String[] args) 
	{
		// Call lower level method passing no values
		getPriceInfo();
		// Calls external method in external class passing no arguments
		EndOfProgram.terminate();
	}
	//-----getPriceInfo-----
	//accepts no parameters
	public static void getPriceInfo()
	{
		//declares variables
		double originalPrice = 0.0;
		int discountRate = 0;
		Scanner keyBoard = new Scanner(System.in);
		// displays message to user for keyboard input
		System.out.println("Enter Price to be Discounted:" );
		originalPrice = keyBoard.nextDouble();
		// displays message to user for keyboard input
		System.out.println("Enter Discount Rate:" );
		discountRate = keyBoard.nextInt();
		//calls lower level method passing two arguments
		displayPriceInfo(originalPrice, discountRate);
		keyBoard.close();
	}
	//-----displayPriceInfo-----
	//accepts two parameters
	public static void displayPriceInfo(double originalPrice, int discountRate)
	{
		//declares variable, initializes to 0.0
		double newPrice = 0.0;
		//calculates newPrice
		newPrice  = originalPrice - (originalPrice * (( double) discountRate / 100) );
		//Displays calculated result to user
		System.out.println(originalPrice + " discounted by " +  discountRate + " percent is " + newPrice);
	}


}
