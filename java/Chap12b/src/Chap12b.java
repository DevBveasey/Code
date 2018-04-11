//Brandon Veasey
//11/23/15
// Chapter 12 – Program b
// Catching an Array Index Out of Bounds exception

public class Chap12b 
{
    //---- Main method ----
	public static void main(String[] args) 
	{
		//sets up a try lock to test for errors
		try
		{
			//Calls populateArray method
			populateArray();
		}
		//catch block handles error msg
		catch (ArrayIndexOutOfBoundsException errorMsg)
		{
			System.out.println();
			//displays user the error made
			System.out.println("Array index " + errorMsg.getMessage() + " is out of the array boundary limits.");
			// prompts user to fix error
			System.out.println("Modify code asuring array index " + errorMsg.getMessage() + " is never refrenced.");
		}
	//End of Program
	System.out.println();
	System.out.println("End of Program.");
	}
    //----populate Array method----
	//accepts no arguments
	public static void populateArray()
	{
		//declares int array with 10 slots
		int [] myArray = new int [10];
		//declares count variable as 5
		int count = 5;
		//for loop procceses array
		for (int index = 0; index < myArray.length; index++)
		{
			//populate array with count
			myArray[index]= count;
			//displays user output
			System.out.println("Array index " + index + " contains a " + count + ".");
			//increses count by 5
			count= count + 5;
		}
		
	}
}
