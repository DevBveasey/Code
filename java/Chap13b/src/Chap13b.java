//Brandon Veasey
//11/30/15
// Chapter 13 � Program b
// Writing String values to a text file

import java.io.File;
import java.io.PrintWriter;
import java.io.IOException;
import java.util.Scanner;

public class Chap13b 
{
	//----- main method -----
	public static void main(String[] args) throws IOException
	{
		//declares string variables initilizes to null
		String fullName = null, addressLine = null, cityStateZip = null;
		//declares int variable initilizes to 0
		int nameCount = 0;
		//declare printwriter (output)file object - writes to the mynumber.txt file
		PrintWriter outFile = new PrintWriter("NameAddress.txt");
		//Creates keyboard input
		Scanner keyBoard = new Scanner(System.in); 
		//prompts user to enter name or quit to end program
		System.out.println("Enter full Name    -OR-   Enter Quit to End Program");
		//stores user input as fullname
		fullName = keyBoard.nextLine();
		while (true)
		{
			//if statement quits program when user enters Quit as full name
			if (fullName.equals("Quit"))
			{
				//close printwriter object
				outFile.close();
				//closes keyboard
				keyBoard.close();
				//display successful msg to user
				System.out.println("The NameAddress.txt file was successfully created.");
				//display line count msg to user
				System.out.println("You entered " + nameCount + " names and addresses into the file.");
				//declare file object - associated with the mynumbers.txt file
				File MyFile = new File("NameAddress.txt");
				//declare variable initialized to 0.0
				double sizeInBytes = 0.0;
				//get file size and store in bytes variable
				sizeInBytes = MyFile.length();
				//display size msg to user
				System.out.println("Its size (on disk) is " + Math.round(sizeInBytes) + " bytes.");
				//  end of program
				System.out.println();
				System.out.println("End of Program.");
				System.exit(1);
			}
			else
			{
				//write input to the text file
			    outFile.println(fullName);
			    //prompts user to enter address
				System.out.println("Enter Address:");
				//stores user input as address
				addressLine = keyBoard.nextLine();
				//write input to the text file
			    outFile.println(addressLine);
			    //prompts user to Enter City, State, and Zip
				System.out.println("Enter City, State, and Zip:");
				//stores user input as citysatezip
				cityStateZip = keyBoard.nextLine();
				//write input to the text file
			    outFile.println(cityStateZip);
			    //adds one to namecount
			    nameCount++;
			    //prompts user to enter name or quit to end program
				System.out.println("Enter full Name    -OR-   Enter Quit to End Program:");
				//stores user input as fullname
				fullName = keyBoard.nextLine();
			}
		}
	}

}
