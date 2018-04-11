//Brandon Veasey
//10/19/2015
// Chapter 8 – Program a
// Using the Math.sqrt method in the Math class

import java.util.Scanner;

public class Chap08a 
{
	//---- Main method ----
	public static void main(String[] args) 
	{
		//calls sub method
		getInput();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");

	}
	//---- getInput method----
	public static void getInput()
	{
		// declares variables
		double userInput = 0.0, squareRoot = 0.0;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//prompts user to input data
		System.out.println("Enter a number to find its square root  -OR-  Enter a 0 to end program:");
		userInput = keyBoard.nextDouble(); // declares keyboard input
		while (userInput != 0)
		{
			//calls sub method calcSquareRoot passing userInput
			squareRoot = calcSquareRoot( userInput);
			//calls sub method dspSquareRoot passing userInput & squareRoot
			dspSquareRoot(userInput, squareRoot);
			System.out.println();
			//prompts user to input data
			System.out.println("Enter a number to find its square root  -OR-  Enter a 0 to end program:");
			userInput = keyBoard.nextDouble(); // declares keyboard input
		}
		keyBoard.close();
	}
	//---- sub method calcSquareRoot ----
	public static double calcSquareRoot(double userInput)
	{
		return  Math.sqrt(userInput);

	}
	//---- sub method dspSquareRoot ----
	public static void dspSquareRoot( double userInput, double squareRoot)
	{
		//displays user with information
		System.out.println("The square root of " + userInput + " is " + Math.round(squareRoot * 100.0) / 100.0 + ".");
	}
	
}
