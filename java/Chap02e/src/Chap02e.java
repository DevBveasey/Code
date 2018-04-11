// Brandon Veasey
// 09/09/2015
// Chapter 2 – Program e
// Assigning initial values to variables, math calculations, and concatenation
public class Chap02e 
{

	public static void main(String[] args) 
	{
	int numOne= 121;
	int numTwo= 93;
	int numThree= 265;
	int sumOfIntergers= 0;
	int avgOfIntergers= 0;
	sumOfIntergers= numOne + numTwo + numThree;
	avgOfIntergers= sumOfIntergers / 3;
	System.out.println("The sum of the integer numbers (121 93  265) is " + sumOfIntergers + ".");
	System.out.println("The average of the integer numbers (121  93  265) is " + avgOfIntergers + ".");
	System.out.println();
	double numFour= 101.313;
	double numFive= 88.808;
	double numSix= 144.14;
	double sumOfDoubles= 0.0;
	double avgOfDoubles= 0.0;
	sumOfDoubles= numFour + numFive + numSix;
	avgOfDoubles= sumOfDoubles / 3;
	System.out.println("The sum of the double numbers (101.313  88.808  144.14) is " + sumOfDoubles + ".");
	System.out.println("The average of the double numbers (101.313  88.808  144.14) is " + avgOfDoubles + ".");
	System.out.println();
	System.out.println("End of program.");
	}

}
