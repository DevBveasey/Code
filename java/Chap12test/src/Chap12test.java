//Brandon Veasey
//11/23/2015
// Chapter 12 Test
// Throw a New exception

import java.util.Scanner;

public class Chap12test 
{
    //---- main method ----
	public static void main(String[] args) //throws RuntimeException
	{
		//declares int variables
		int empNumber = 0;
		//declares double variables
		double hrsWorked = 0.0, payRate = 0.0,grossPay = 0.0;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//prompts user to enter emnumber or 0
		System.out.println("Enter Employee Number    -or-   Enter 0 to End Program:");
		//declares user input as empNumber
		empNumber = keyBoard.nextInt();
		//while loop creates break statement 
		while (empNumber != 0)
		{
			//sets up a try lock to test for errors
			try
			{
				//prompts user to enter data
				System.out.println("Enter Pay Rate:");
				//declares user input as variable
				payRate = keyBoard.nextDouble();
				//prompts user to enter data
				System.out.println("Enter Hours Worked:");
				//declares user input as variable
				hrsWorked = keyBoard.nextDouble();
				//if statement excludes less than 0 hrs and more than zero hrs
				if(hrsWorked < 0 || hrsWorked > 40)
				{
					//throws exception
					throw new ValidateHours();
				}
		
				else 
				{
					//calculates gross pay
					grossPay = hrsWorked * payRate;
					//displayes calulation
					System.out.println("Gross pay for employee " + empNumber + " is " + grossPay);
					System.out.println();
					//prompts user to enter empnumber or 0
					System.out.println("Enter Employee Number    -or-   Enter 0 to End Program:");
					empNumber = keyBoard.nextInt();
				}
				
			}
			//catch block handles error msg
			catch(ValidateHours myMessage)
			{
				//displays error msg to user
				System.out.println(myMessage.getMessage());
				System.out.println();
				//prompts user to enter data
				System.out.println("Enter Employee Number    -or-   Enter 0 to End Program:");
				//declares user input as variable
				empNumber = keyBoard.nextInt();
			}
		}
		//closes keyboard
		keyBoard.close();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
		
	}

}
