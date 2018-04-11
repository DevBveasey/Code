// Brandon Veasey
// 09/02/2015
// Chapter 2 – Program d
// Using variables in math calculations and concatenation
public class Chap02d 
{

	public static void main(String[] args) 
	{
		int numOne=0;
		int numTwo=0;
		int numThree=0;
		int sumOfIntegers;
		int avgOfIntegers;
		numOne=19;
		numTwo=43;
		numThree=65;
		sumOfIntegers= numOne + numTwo + numThree;
		avgOfIntegers= sumOfIntegers / 3;
		System.out.println("The sum of the integer numbers (19  43  65) is " + sumOfIntegers + ".");
		System.out.println("The average of the integer numbers (19  43  65) is " + avgOfIntegers + ".");
		System.out.println();
		double numFour, numFive, numSix, sumOfDoubles, avgOfDoubles;
		numFour=11.99;
		numFive=33.49;
		numSix=55.25;
		sumOfDoubles=numFour + numFive + numSix;
		avgOfDoubles= sumOfDoubles / 3;
		System.out.println("The sum of the double numbers (11.99  33.49  55.25) is " + sumOfDoubles + ".");
		System.out.println("The average of the double numbers (11.99  33.49  55.25) is " + avgOfDoubles + ".");
		System.out.println();
		System.out.println("End of program.");
	}

}
