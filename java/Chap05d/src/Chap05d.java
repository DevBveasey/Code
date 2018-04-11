//Brandon Veasey
// 10/12/2015
// Chapter 5 – Program d
// Overloading method names

public class Chap05d 
{
    // main method
	public static void main(String[] args) 
	{
		int result = 0;
		result = calcResult(11);
		System.out.print("Squared -----------> ");
		dspResult(result);
		result = calcResult(400, 4);
		System.out.print("Division ----------> ");
		dspResult(result);
		result = calcResult(200, 50, 17);
		System.out.print("Subtraction -------> ");
		dspResult(result);
		result = calcResult(2, 4, 6, 8);
		System.out.print("Multiplication ----> ");
		dspResult(result);
		result = calcResult(22, 33, 44, 55, 66);
		System.out.print("Addition ----------> ");
		dspResult(result);
		System.out.println();
		System.out.println("End of Program.");
	}
	// sub methods with same calling verified by int
	public static int calcResult(int numOne)
	{
		return numOne * numOne;
	}
	public static int calcResult(int numOne, int numTwo)
	{
		return numOne / numTwo;
	}
	public static int calcResult(int numOne, int numTwo, int numThree)
	{
		return numOne - numTwo - numThree;
	}
	public static int calcResult(int numOne, int numTwo, int numThree, int numFour)
	{
		return numOne * numTwo * numThree * numFour;
	}
	public static int calcResult(int numOne, int numTwo, int numThree, int numFour, int numFive)
	{
		return numOne + numTwo + numThree + numFour + numFive;
	}
	public static void dspResult(int result)
	{
		System.out.println("Calculated result is " + result + "."); // prints results portion of the display
	}
}
