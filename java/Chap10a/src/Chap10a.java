//Brandon Veasey
// 11/09/15
// Chapter 10 – Program a
// Utilizing the advantages of inheritance

import java.util.Scanner;

public class Chap10a 
{
	// ---- main method----
	public static void main(String[] args) 
	{
		// declares int variables
		int numEntered = 0;
		int result = 0;
		//declares string variable
		String myText = null;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//prompts user to input data
		System.out.println("Enter a Whole Number you would like squared and cubed");
		//declares user data
		numEntered = keyBoard.nextInt();
		//Declares pointer to point to squared class
		Squared squaredPointer = new Squared();
		//calls squared class passing numEntered to calcResult method returning a value
		result = Squared.calcResult(numEntered);
		myText = " you entered has a squared value of ";
		//class squared class passing 3 variables to dspResults method
		Squared.dspResults(numEntered, result, myText);
		//Declares pointer to point to squared class
		Cubed cubedPointer = new Cubed();
		//calls cubed class passing numEntered to dspResult method returning a value
		result = Cubed.calcResult(numEntered);
		myText = " you entered has a cubed value of ";
		//class cubed class passing 3 variables to dspResults method
		Cubed.dspResults(numEntered, result, myText);
		keyBoard.close();   //closes keyboard
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
		
	}

}
