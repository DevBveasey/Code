//Brandon Veasey
// 11/11/15
// Chapter 10 – Program b
// Utilizing the advantages of inheritance

import java.util.Scanner;

public class Chap10b 
{
	// ---- main method ----
	public static void main(String[] args) 
	{
		//declares string variables
		String firstName = null, lastName = null, completeName = null, address = null, city = null, state = null, zipCode = null, addCityStZip = null, phoneNo = null, email = null, info = null;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		System.out.println("Enter your First Name:");
		//prompts user to input data
		firstName = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your Last Name:");
		lastName = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your Address:");
		address = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your City:");
		city = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your State:");
		state = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your Zip Code:");
		zipCode = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your Phone Number:");
		phoneNo = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println("Enter your Email Address:");
		email = keyBoard.nextLine();
		//declares input data as variable
		//prompts user to input data
		System.out.println();
		//Declares pointer to point to class
		FullName FullNamePointer = new FullName();
		//calls class passing 2 variables to lower level method returning a value
		completeName = FullNamePointer.concatText(firstName,lastName);
		FullNamePointer.dspStringText(completeName);
		//Declares pointer to point to class
		MailingAddress addressPointer = new MailingAddress();
		//calls class passing 4 variables to lower level method returning a value
		addCityStZip = addressPointer.concatText(address, city, state, zipCode);
		addressPointer.dspStringText(addCityStZip);
		//Declares pointer to point to class
		ContactInfo contactInfoPointer = new ContactInfo();
		//calls class passing 2 variables to lower level method returning a value
		info = contactInfoPointer.concatText(phoneNo,email);
		contactInfoPointer.dspStringText(info);
		keyBoard.close();   //closes keyboard
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
		
		
	}

}
