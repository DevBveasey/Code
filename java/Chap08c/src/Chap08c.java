//Brandon Veasey
//10/21/2015
// Chapter 8 – Program c
// Using various methods in the String class

public class Chap08c 
{
	//---- Main method ----
	public static void main(String[] args) 
	{
		// declares variables
		 String strOne = "Mississippi";
		 String strTwo = "miSSiSSiPPi";
		 //calls sub method passing two strings
		 strEquals(strOne, strTwo );
		 //calls sub method passing two strings
		 strEqualsIgnore(strOne, strTwo );
		 //calls sub method passing strOne
		 strLength(strOne);
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
		
		
	}
	// ---- strEquals ----
	public static void strEquals(String strOne, String strTwo)
	{
		if (strOne.equals(strTwo))
		{
			//displays information to user
			System.out.println("Using the equals method - " + strOne + " and " + strTwo + " are equal.");
		}
		else
		{
			//displays information to user
			System.out.println("Using the equals method - " + strOne + " and " + strTwo + " are not equal.");
		}
	}
	//---- strEqualsIgnore ----
	public static void strEqualsIgnore(String strOne, String strTwo)
	{
		if (strOne.equalsIgnoreCase(strTwo))
		{
			//displays information to user
			System.out.println("Using the equalsIgnoreCase method - " + strOne + " and " + strTwo + " are equal.");
		}
		else
		{
			//displays information to user
			System.out.println("Using the equalsIgnoreCase method - " + strOne + " and " + strTwo + " are not equal.");
		}
	}
	//---- strLength ----
	public static void strLength(String strOne)
	{
		//declares variable, initializes to 0
		int strLength = 0;
		//counts the length of strOne and stores value as strLength
		strLength = strOne.length();
		//displays information to user
		System.out.println("Using the length method " + strOne + " contains " + strLength + " characters.");
	}
}
