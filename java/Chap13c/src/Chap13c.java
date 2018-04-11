//Brandon Veasey
//11/30/15
// Chapter 13 � Program c
// Reading and processing Integer values from a text file

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Chap13c 
{
	//----- main method -----
	public static void main(String[] args) throws IOException
	{
		//declare scanner input pointer
		Scanner inFile = null;
		// try block creates the scanner object
		try
		{
			//declare scanner input file object
			inFile = new Scanner(new File("TestScores.txt"));
			
		}
		//catch block catches exceptions
		catch (IOException errorMsg)
		{
			//Displays system error to user
			System.out.println(errorMsg.getMessage());
			//program terminated msg
			System.out.println();
			System.out.println("Program Terminated");
			//Terminates the program immediately
			System.exit(1);
		}
		//declares two int and initilizes both to 0
		int sum = 0, count = 0;
		//while loop reads input file
		while (inFile.hasNextInt())
		{
			//calculates sum
			sum = sum + inFile.nextInt();
			//adds one to counter
			count++;
		}
		// close scanner object
		inFile.close();
		//calls calaverage passing sum and count
		calcAverage(sum,count);
	}
	// ----- calcaverage method-----
	// accepts 2 arguments
	public static void calcAverage (int sum,int count)
	{
		//declares double and initilizes to 0.0
		double average = 0.0;
		//calculates average
		average = (double)sum / count;
		//displays user sum msg and average msg
		System.out.println("The sum of the test scores in the TestScores.txt file is " + sum + ".");
		System.out.println("The average test score in the TestScores.txt file is " + Math.round(average * 100.0) / 100.0 + ".");
		//  end of program
		System.out.println();
		System.out.println("End of Program.");
	}
}
