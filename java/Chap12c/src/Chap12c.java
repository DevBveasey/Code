//Brandon Veasey
//11/23/15
// Chapter 12 – Program c
// Catching an Arithmetic exception

import java.util.Scanner;

public class Chap12c 
{
    //---- main method ----
	public static void main(String[] args) 
	{
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//declares int variables
		int numerator = 0, denominator = 0, quotient = 0, remainder = 0;
		//displayes user message
		System.out.println("TO DETERMINE THE QUOTIENT OF TWO NUMBERS...");
		//prompts user to enter data
		System.out.println("Enter the Numerator:");
		//declares user input as numerator
		numerator = keyBoard.nextInt();
		//prompts user to enter data
		System.out.println("Enter the Denominator:");
		//declares user input as denominator
		denominator = keyBoard.nextInt();
		//calles calcquotient passing two variables returning one
		quotient = calcQuotient(numerator, denominator);
		//calles calcremainder passing two variables returning one
		remainder = calcRemainder(numerator, denominator);
		//calles dspquotient passing four variables
		dspQuotient(numerator, denominator, quotient, remainder);
		//closes keyboard
		keyBoard.close();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}
	//---- calcquotient method ----
	//accepts two variables
	public static int calcQuotient(int numerator, int denominator)
	{
		//declares quotient int
		int  quotient = 0;
		//sets up a try lock to test for errors
		try
		{
			quotient = numerator / denominator;
		}
		//catch block handles error msg
		catch(ArithmeticException errorMsg)
		{
			//displayes error msg to user
			System.out.println("You are attempting to divide " + numerator + " by " + denominator + " ---> " + errorMsg.getMessage() + " is an illegal operation.");
			//End of Program
			System.out.println();
			System.out.println("End of Program.");
			System.exit(1);
		}
		return quotient;
	}
	//----calcRemainder method ----
	//accepts two variables
	public static int calcRemainder(int numerator, int denominator)
	{
		//calculates return remainder
		return  numerator % denominator;
	}
	//----dspQuotient method ----
	public static void dspQuotient(int numerator, int denominator, int quotient, int remainder)
	{
		//displays generated output
		System.out.println(numerator  + " divided by " + denominator + " equals " + quotient + " with a remainder of " + remainder + ".");
	}
}
