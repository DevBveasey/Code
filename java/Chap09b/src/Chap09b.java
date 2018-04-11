//Brandon Veasey
//11/02/2015
// Chapter 9 – Program b
// Creating a Double array, sorting, reverse order

import java.util.Scanner;
import java.util.Arrays;

public class Chap09b 
{
    // ---- main method ----
	public static void main(String[] args) 
	{
		//declares double array
		double [] SalesArray = new double [12];
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//prompts user to input sales data
		System.out.println("Enter Sales Data:");
		//declares variable loopCount and initializes to 0
		int loopCount = 0;
		//while loop used to populate array
		while (loopCount < 12)
		{
			// allows user input into array
			SalesArray[loopCount] = keyBoard.nextDouble();
			loopCount++; //used to increase variable loopCount by one each pass
		}
		System.out.println();
		//prompts user upon completion
		System.out.println("You successfully entered 12 Sales figures.");
		System.out.println();
		// sorts data user inputs
		Arrays.sort(SalesArray);
		//passes array to sub method
		dspArray(SalesArray);
		keyBoard.close();   //closes keyboard
		//End of Program
		System.out.println();
		System.out.println("End of Program.");

	}
	// ---- sub method dsparray ----
	//excepts salesArray
	public static void dspArray(double [] SalesArray)
	{
		//Declare variables, initialize each to 0.0
		double sumOfSales = 0.0, avgOfSales = 0.0;
		//for loop processes array
		for (int index = 0; index < SalesArray.length; index++)
		{
			//displays values in each slot of the array
			sumOfSales = sumOfSales + SalesArray[index];
		}
		// displays message about yearly sales
		System.out.print("Total Yearly Sales - " + sumOfSales);
		//solves for avgOfSales
		avgOfSales = sumOfSales / 12;
		// displays message about yearly sales
		System.out.println("  -   Average Monthly Sales - " + Math.round(avgOfSales * 100.0) / 100.0);
		System.out.println();
		//displays message to user about how the list is sorted
		System.out.println("Sales in Ascending Order:");
		//for loop processes array
		for (int index = 0; index < SalesArray.length; index++)
		{
			//displays values in each slot of the array
			System.out.println(SalesArray[index]);
		}
		System.out.println();
		//displays message to user about how the list is sorted
		System.out.println("Sales in Descending Order:");
		//for loop processes array
		for (int index =  SalesArray.length - 1; index >= 0; index--)
		{
			//displays values in each slot of the array
			System.out.println(SalesArray[index]);
		}
	}
}
