

//Brandon Veasey
// 10/12/2015
// Chapter 5 – Program b
// Calling methods, passing arguments, parameters, and returning values

import java.util.Scanner;

public class Chap05b 
{
     // main method
	public static void main(String[] args) 
	{
		int addResult = 0, subResult = 0, mulResult = 0;
		double divResult = 0.0;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		while (true)
			{
				int numOne = 0, numTwo = 0;
				System.out.println("Enter Two Numbers   -OR-   Enter 0 to End Program:");
				numOne = keyBoard.nextInt();// declares keyboard input
			if (numOne == 0)
			{
				break;// ends program
			}
			else
			{
					numTwo = keyBoard.nextInt();// declares keyboard input
			}
			// calling sub methods and prints results
			addResult = calcAddition(numOne, numTwo);
			System.out.println("Result of addition is " + addResult + ".");
			subResult = calcSubtraction(numOne, numTwo);
			System.out.println("Result of subtraction is " + subResult + ".");
			mulResult = calcMultiplication(numOne, numTwo);
			System.out.println("Result of mutiplication is " + mulResult + ".");
			divResult = calcDivision(numOne, numTwo);
			System.out.println("Result of division is " + divResult + ".");
			System.out.println();
			
			}
		keyBoard.close();
		System.out.println();
		System.out.println("End of Program.");// prints end of program statement

	}
	public static int calcAddition(int numOne, int numTwo)
	{
		int addResult = 0;
		addResult = numOne + numTwo;
		return addResult; // returns result to calling
	}
	public static int calcSubtraction(int numOne, int numTwo)
	{
		int subResult = 0;
		subResult = numOne - numTwo;// mathmatical equation for result
		return subResult;// returns result to calling
	}
	public static int calcMultiplication(int numOne, int numTwo)
	{
		int mulResult = 0;
		mulResult = numOne * numTwo;// mathmatical equation for result
		return mulResult;// returns result to calling
	}
	public static double calcDivision(int numOne, int numTwo)
	{
		double divResult = 0;
		divResult = (double)numOne / (double)numTwo;// mathmatical equation for result
		return divResult;// returns result to calling
	}
	
	
	
}
