//Brandon/Veasey
//12/02/2015
//introduction to Programming Final Exam
//Processing menu options

import java.util.Scanner;

public class FinalExam 
{
//Global variables
static Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
static int numOne = 0, numTwo = 0;
	// ----- main method -----
	public static void main(String[] args) 
	{
		//declares int menu, initilizes to 0
		int menu = 0;
		//declares string end ,initilizes to End of Program msg
		String end = "End of Program.";
		//declares string end ,initilizes to Exam Complete msg
		String finalEnd = "Java Final Exam Complete.";
		//prompts user to enter menu selection
		System.out.println("Enter a Menu Option   - OR-   Enter 0 to End Program:");
		//Displays menu options to user
		System.out.println("1. Square a Number");
		System.out.println("2. Cube a Number");
		System.out.println("3. Add Two Numbers");
		System.out.println("4. Subtract Two Numbers");
		System.out.println("5. Mutiply Two Numbers");
		System.out.println("6. Divide Two Numbers");
		//stores user input as menu
		menu = keyBoard.nextInt();
		System.out.println();
		//does not allow 0 entry
		while (menu != 0)
		{
			//if statement excepts menu equal 1
			if (menu == 1)
			{
				optionOne();
			}
			//if statement excepts menu equal 2
			if (menu == 2)
			{
				optionTwo();
			}
			//if statement excepts menu equal 3
			if (menu == 3)
			{
				optionThree();
			}
			//if statement excepts menu equal 4
			if (menu == 4)
			{
				optionFour();
			}
			//if statement excepts menu equal 5
			if (menu == 5)
			{
				optionFive();
			}
			//if statement excepts menu equal 6
			if (menu == 6)
			{
				optionSix();
			}
			//if statement excepts anything less than 0 or greater than 6
			if (menu < 0 || menu > 6)
			{
				System.out.println("INVALID OPTION - PLEASE TRY AGAIN.");
			}
			System.out.println();
			//prompts user to enter menu selection
			System.out.println("Enter a Menu Option   - OR-   Enter 0 to End Program:");
			//Displays menu options to user
			System.out.println("1. Square a Number");
			System.out.println("2. Cube a Number");
			System.out.println("3. Add Two Numbers");
			System.out.println("4. Subtract Two Numbers");
			System.out.println("5. Mutiply Two Numbers");
			System.out.println("6. Divide Two Numbers");
			//stores user input as menu
			menu = keyBoard.nextInt();
			System.out.println();
		}
		//calls endofprogram method in endofprogram class, passing two arguments
		EndOfProgram.EndOfProgram(end ,finalEnd);
	}
	// --- option One method---
	// accepts no parameters
	public static void optionOne() 
	{
		//prompts user to enter data
		System.out.println("Enter the number you would like squared:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//declares int, initializes to 0
		int result = 0;
		//Calculates result
		result= numOne * numOne;
		//displays calculated msg to user
		System.out.println(numOne + " squared is " + result + ".");

	}
	// --- option Two method---
	// accepts no parameters
	public static void optionTwo()
	{
		//prompts user to enter data
		System.out.println("Enter the number you would like cubed:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//declares int, initializes to 0
		int result = 0;
		//Calculates result
		result= numOne * numOne * numOne;
		//displays calculated msg to user
		System.out.println(numOne + " cubed is " + result + ".");
		
	}
	// --- option Three method---
	// accepts no parameters
	public static void optionThree()
	{
		//prompts user to enter data
		System.out.println("Enter two numbers you would like to add:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//stores input as numTwo
		numTwo = keyBoard.nextInt();
		//declares int, initializes to 0
		int result = 0;
		//Calculates result
		result= numOne + numTwo;
		//displays calculated msg to user
		System.out.println("Addition ---> " + numOne + " + " + numTwo + " = " +  result + ".");
	}
	// --- option Four method---
	// accepts no parameters
	public static void optionFour()
	{
		//prompts user to enter data
		System.out.println("Enter two numbers you would like to subtract:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//stores input as numTwo
		numTwo = keyBoard.nextInt();
		//declares int, initializes to 0
		int result = 0;
		//Calculates result
		result= numOne - numTwo;
		//displays calculated msg to user
		System.out.println("Subtraction ---> " + numOne + " - " + numTwo + " = " +  result + ".");

	}
	// --- option Five method---
	// accepts no parameters
	public static void optionFive()
	{
		//prompts user to enter data
		System.out.println("Enter two numbers you would like to mutiply:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//stores input as numTwo
		numTwo = keyBoard.nextInt();
		//declares int, initializes to 0
		int result = 0;
		//Calculates result
		result= numOne * numTwo;
		//displays calculated msg to user
		System.out.println("Mutiplication ---> " + numOne + " * " + numTwo + " = " +  result + ".");

	}
	// --- option Five method---
	// accepts no parameters
	public static void optionSix()
	{
		//prompts user to enter data
		System.out.println("Enter two numbers you would like to divide:" );
		//stores input as numOne
		numOne = keyBoard.nextInt();
		//stores input as numTwo
		numTwo = keyBoard.nextInt();
		//declares int, initializes to 0
		double result = 0.0;
		//sets up a try lock to test for errors
		try
		{
			//if statment accepts numTwo equality 0
			if (numTwo == 0)
			{
				//calculate result of division
				result = numOne / numTwo;
			}
			else
			{
				//calculate result of division
				result = (double)numOne / numTwo;
				//displays user division msg rounded
				System.out.println("Division --->" + numOne + " / " + numTwo + " = " + Math.round(result * 100.0) / 100.0 + ".");
			}
		}
		//catch block handles error msg
		catch(ArithmeticException errorMsg)
		{
			//Displays error msg to user
			//Displays error msg to user
			System.out.println("ERROR - cannot " + errorMsg.getMessage() + ".");
		}
	}
	
}
