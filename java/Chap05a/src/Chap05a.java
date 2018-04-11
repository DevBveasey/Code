//Brandon Veasey
//10/07/2015
// Chapter 5 – Program a
// Calling methods, passing arguments, parameters, and math calculations

import java.util.Scanner;

public class Chap05a 
{
	//main method
	public static void main(String[] args) 
	{
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
	
	while (true)
		{
		int numOne = 0, numTwo = 0;
		System.out.println("Enter Two Numbers   -OR-   Enter 0 to End Program:");
		numOne = keyBoard.nextInt(); // declares keyboard input
			if (numOne == 0)
				{
					break; // ends program
				}
			else
			{
				numTwo = keyBoard.nextInt(); // declares keyboard input
			}
			// calling sub methods
			calcAddition(numOne, numTwo);
			calcSubtraction(numOne, numTwo);
			calcMultiplication(numOne, numTwo);
			calcDivision(numOne, numTwo);
			
			
			}
	keyBoard.close();
	System.out.println();
	System.out.println("End of Program."); // prints end of program statement
		}
	public static void calcAddition(int numOne, int numTwo)
	{
		int addResult = 0;
		addResult = numOne + numTwo; // mathmatical equation for result
		System.out.println("Result of addition is " + addResult + ".");
	}
	public static void calcSubtraction(int numOne, int numTwo)
	{
		int subResult = 0;
		subResult = numOne - numTwo;// mathmatical equation for result
		System.out.println("Result of subtraction is " + subResult + ".");
	}
	public static void calcMultiplication(int numOne, int numTwo)
	{
		int mulResult = 0;
		mulResult = numOne * numTwo;// mathmatical equation for result
		System.out.println("Result of mutiplication is " + mulResult + ".");
	}
	public static void calcDivision(int numOne, int numTwo)
	{ // numOne and numTwo are cast to doubles
		double divResult = 0;
		divResult = (double)numOne / (double)numTwo;// mathmatical equation for result
		System.out.println("Result of division is " + divResult + ".");
	}
	
	
}
