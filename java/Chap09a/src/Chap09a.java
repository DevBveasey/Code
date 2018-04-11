//Brandon Veasey
//11/2/2015
// Chapter 9 – Program a
// Creating a String array, sorting, reverse order

import java.util.Scanner;
import java.util.Arrays;

public class Chap09a 
{
    //---- Main method ----
	public static void main(String[] args) 
	{
		//declares string array
		String [] NamesArray = new String [10];
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//prompts user to input ten names
		System.out.println("Enter Ten First Names in Random Order:");
		//declares varible loopcount and initilizes to 0
		int loopCount = 0;
		//while loop used to populate array
		while (loopCount < 10)
		{
			// allows user input into array
			NamesArray[loopCount] = keyBoard.nextLine();
			loopCount++;//used to increase variable loopcount by one each pass
			
		}
		System.out.println();
		//prompts user apon completion
		System.out.println("You successfully entered 10 names.");
		System.out.println();
		// sorts data user inputs
		Arrays.sort(NamesArray);
		//passes array to sub method
		dspArray(NamesArray);
		keyBoard.close();   //closes keyboard
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}
	// ---- sub method dsparray ----
	//excepts names array
	public static void dspArray(String [] NamesArray)
	{
		// displays message about sorting
		System.out.println("Names in Alphabetic Order:");
		//for loop procceses array
		for (int index = 0; index < NamesArray.length; index++)
		{
			//displays values in each slot of the array
			System.out.println(NamesArray[index]);
		}
		System.out.println();
		// displays message about sorting
		System.out.println("Names in Reverse Order:");
		//for loop procceses array
		for (int index =  NamesArray.length - 1; index >= 0; index--)
		{
			//displays values in each slot of the array
			System.out.println(NamesArray[index]);
		}
	}

}
