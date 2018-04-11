//Brandon Veasey
// 11/09/15
// Chapter 10 – Program a
// Utilizing the advantages of inheritance

public class Squared 
{
	public static int calcResult(int numEntered)
	{
		//returns calculated result
		return  numEntered * numEntered;
	}
	public static void dspResults(int numEntered, int result, String myText) 
	{
		//displays the generated output for both cubed and squared
		System.out.println("The " + numEntered + myText + result + ".");
	}
}