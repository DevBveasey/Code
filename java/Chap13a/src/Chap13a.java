//Brandon Veasey
//11/30/15
// Chapter 13 – Program a
// Writing Double values to a text file

import java.io.File;
import java.io.PrintWriter;
import java.io.IOException;

public class Chap13a 
{
	// ----- Main method -----
	public static void main(String[] args) throws IOException

	{
		//declare printwriter (output)file object - writes to the mynumber.txt file
		PrintWriter outFile = new PrintWriter("MyNumbers.txt");

		// for loop to write the numbers 1 to 50 to the file .5 at a time
		for(double number = 1; number <= 50; number = number + .5)
		{
			//write number to the text file
		    outFile.println(number);
		}
		//close printwriter object
		outFile.close();
		//display successful msg to user
		System.out.println("The MyNumbers.txt file was successfully created.");
		//declare file object - associated with the mynumbers.txt file
		File MyFile = new File("MyNumbers.txt");
		//declare variable initialized to 0.0
		double sizeInBytes = 0.0;
		//get file size and store in bytes variable
		sizeInBytes = MyFile.length();
		//display size msg to user
		System.out.println("Its size (on disk) is " + Math.round(sizeInBytes) + " bytes.");
		System.out.println();
		//  end of program
		System.out.println("End of Program.");

	}

}
