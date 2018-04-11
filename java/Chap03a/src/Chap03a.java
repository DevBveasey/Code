// Brandon Veasey
// 09/16/2015
// Chapter 3 – Program a
// Using various primitive types in calculations and equality comparisons

public class Chap03a 
{

	private static final boolean True = false;

	public static void main(String[] args) 
	{
		byte numOne = 115, numTwo = -125;
		short numThree= -22225, numFour= -10325;
		int numFive= 123456789, numSix= 987654321;
		long numSeven= 10011001, numEight= 20022002;
		float numNine= 999999, numTen= 888888;
		double numEleven= -235987.123456, numTwelve= -16.987654;
		char charOne= 'Z', charTwo= 'z';
		boolean booOne= True, booTwo= True;
		System.out.println("BYTE type addition result is " + (numOne + numTwo) + ".");
		System.out.println("SHORT type addition result is " + (numThree + numFour) + ".");
		System.out.println("INT type addition result is " + (numFive + numSix) + ".");
		System.out.println("LONG type addition result is " + (numSeven + numEight) + ".");
		System.out.println("FLOAT type addition result is " + (numNine + numTen) + ".");
		System.out.println("DOUBLE type addition result is " + (numEleven + numTwelve) + ".");
		System.out.println("CHAR type comparison result is " + (charOne == charTwo) + ".");
		System.out.println("BOOLEAN type comparison result is " + (booOne == booTwo) + ".");
		System.out.println();
		System.out.println("End of Program.");
		
		
		

	}

}
