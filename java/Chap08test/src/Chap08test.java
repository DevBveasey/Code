//Brandon Veasey
// 10/21/2015
// Chapter 8 Test
// Using the Math.pow and Math.round methods

import java.util.Scanner;

public class Chap08test 
{
    //---- main method----
	public static void main(String[] args)  
	{
		//calls sub method
		getInput();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");

	}
	// ---- getInput method ----
	//accepts no parameters
	public static void getInput()
	{
		double baseNumber = 0.0, raisedNumber = 0.0, raisedResult = 0.0;
		//Creates keyboard input
		Scanner keyBoard = new Scanner(System.in); 
		System.out.println("Enter a Base Number:");
		// declares keyboard input
		baseNumber = keyBoard.nextDouble(); 
		System.out.println("Enter a Raise Number:");
		raisedNumber = keyBoard.nextDouble();
		//calls calcPower method passing two parameters with a returned value
		raisedResult = calcPower(baseNumber, raisedNumber);
		//calls dspRaisedNumber method passing three parameters
		dspRaisedNumber(baseNumber, raisedNumber, raisedResult);
		keyBoard.close();
	}
	//---- calcPower method ----
	//accepts two parameters
	public static double calcPower(double baseNumber, double raisedNumber)
	{
		//returns solved variable to main method
		return (Math.pow(baseNumber, raisedNumber));
	}
	//---- dspRaisedNumber method ----
	//accepts three parameters
	public static void dspRaisedNumber(double baseNumber,double raisedNumber,double raisedResult)
	{
		//displays information to the user
		System.out.println(baseNumber + " raised " + raisedNumber + " times equals " + raisedResult + ".");
		System.out.println(raisedResult + " rounded equals " + Math.round(raisedResult) + ".");
	}
}
