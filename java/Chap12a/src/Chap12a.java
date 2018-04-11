//Brandon Veasey\
//11/18/2015
// Chapter 12 – Program a
// Catching an Input Mismatch exception

import java.util.InputMismatchException;
import java.util.Scanner;

public class Chap12a 
{
	//---- Main method ----
	public static void main(String[] args) throws RuntimeException
	{
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//declares double variables 
		double userInput = 0.0, squared = 0.0;
		//prompts user to input data
		System.out.println("Enter a Positive Number:");
		//sets up a try lock to test for errors
		try
		{
			//declares user input as data user typed
			userInput = keyBoard.nextDouble();
		}
		//catch block handles error msg
		catch (InputMismatchException errorMsg)
		{
			//displayes error msg to user
			System.out.println("The value you entered is not a number - it is evaluated as " + errorMsg.getMessage() + ".");
			//End of Program
			System.out.println();
			System.out.println("End of Program.");
			System.exit(1);
		}
		//detirmins if userinput is greater than 0
		if (userInput > 0)
		{
			//declares squared variable as return from calcSquared method
			squared = calcSquared(userInput);
			//displays squared math
			System.out.println(userInput + " squared is " + Math.round(squared * 100.0) / 100.0 + ".");
		}
		//detirmins if userinput is less than 0
		if (userInput < 0)
		{
			// displays user error msg
			System.out.println("The value you entered is a negative number.");
		}
		//detirmins if userinput is equal to 0
		if (userInput == 0)
		{
			//displays error msg
			System.out.println("The value you entered is a zero (neither positive or negative).");
		}
		//closes keyboard
		keyBoard.close();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}
	//---- calcSquared method ----
	//accepts one varaible
	public static double calcSquared(double userInput)
	{
		//returned squared value of userinput
		return userInput * userInput;
	}
}
