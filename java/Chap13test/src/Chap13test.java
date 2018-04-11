//Brandon Veasey
//12/02/2015
// Chapter 13 Test
// Reading and processing String values from a text file

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Chap13test 
{
	//----- main method -----
	public static void main(String[] args) 
	{
		//declare scanner input pointer
		Scanner inFile = null;
		// try block creates the scanner object
		try
		{
			//declare scanner input file object
			inFile = new Scanner(new File("NameAddress.txt"));
					
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
		//declares string array with 15 slots
		String [] myArray = new String [15];
		//declares two variable initialized to 0
		int slotIndex = 0, lineCount = 0;
		//while loop used to populate array
		while (inFile.hasNextLine())
		{
			// allows user input into array
			myArray[slotIndex] = inFile.nextLine();
			//adds one to slotindex
			slotIndex++;
		}
		//displayes NAMES AND ADDRESSES msg to user
		System.out.println("NAMES AND ADDRESSES IN THE NameAddress FILE:");
		System.out.println();
		//for loop processes array
		for (int slotindex = 0; slotindex < myArray.length; slotindex++) 
		{
			//if statement line count less than 3
			if ( lineCount < 3)
			{
				//displays values in each slot of the array
				System.out.println(myArray[slotindex]);
				//adds one to linecount
				lineCount++;
			}
			else
			{
				System.out.println();
				//displays values in each slot of the array
				System.out.println(myArray[slotindex]);
				//declares linecount as 1
				lineCount = 1;
			}
		}
		// close scanner object
		inFile.close();
		//  end of program
		System.out.println();
		System.out.println("End of Program.");
	}

}
