// Brandon Veasey
// 09/09/2015
// Chapter 2 Test
// Assigning initial values to variables, math calculations, and concatenation
public class Chap02test 
{

	public static void main(String[] args) 
	{
		int numOne= 18, numTwo= 43, numThree= 67, numFour= 9, numFive= 27, firstsum= 0, secondsum= 0, multResult= 0, divResult= 0, remResult= 0;
		firstsum= numOne + numFive;
		secondsum= numTwo + numThree + numFour;
		System.out.println("The value in the firstSum variable is " + firstsum + ".");
		System.out.println("The value in the secondSum variable is " + secondsum + ".");
		System.out.println("The values " + firstsum + " and " + secondsum + "  added together equals " + (firstsum + secondsum) + ".");
		multResult= numOne * numTwo * numThree * numFour * numFive;
		System.out.println("All variable values multiplied together equals "  + multResult + ".");
		divResult= 100000 / (numOne + numTwo + numThree + numFour + numFive);
		System.out.println("One hundred thousand divided by the sum of all variables equals "  + divResult + ".");
		remResult= 100000 % (numOne + numTwo + numThree + numFour + numFive);
		System.out.println("One hundred thousand divided by the sum of all variables has a remainder of " + remResult + ".");
		System.out.println();
		System.out.println("End of program.");
	}

}
