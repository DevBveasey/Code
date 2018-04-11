//Brandon Veasey
//10/21/2015
// Chapter 8 – Program b
// Using the Math.PI method in the Math class

import java.util.Scanner;

public class Chap08b 
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
		System.out.println("Enter the Radius of a Circle  -OR-  Enter a 0 to end program:");
		userInput = keyBoard.nextDouble(); // declares keyboard input
		while (userInput != 0)
		{
			//calls sub method calcSquareRoot passing userInput
			squareRoot = calcSquareArea( userInput);
			//calls sub method dspSquareRoot passing userInput & squareRoot
			dspSquareRoot(userInput, squareRoot);
			System.out.println();
			//prompts user to input data
			System.out.println("Enter the Radius of a Circle  -OR-  Enter a 0 to end program:");
			userInput = keyBoard.nextDouble(); // declares keyboard input
		}
		keyBoard.close();
			
	}
	//---- sub method calcSquareArea ----
	public static double calcSquareArea(double userInput)
	{
		double area = Math.PI * userInput * userInput;
		//returns variable back to main method
		return  area;

	}
	//---- sub method dspSquareRoot ----
	public static void dspSquareRoot(double userInput, double squareRoot)
	{
		//displays user with information
		System.out.println("A circle with the radius of " + userInput + " has an area of " + Math.round(squareRoot * 100.0) / 100.0 + ".");
	}
}
