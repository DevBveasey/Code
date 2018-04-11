//Brandon Veasey
//09/30/2015
// Chapter 4 – Program c
// Using if and if-else statements (single statement)
public class Chap04c 
{

	public static void main(String[] args) 
	{
	int numOne= 8;
		if (numOne <= 10)
		{
			System.out.println("20 is less than or equal to 10" + " (simple if statement).");
		}
		if (numOne > 10)
		{
			System.out.println("20 is greater than 10" + " (simple if statement).");
		}
		if (numOne <= 10)
		{
			System.out.println("20 is less than or equal to 10" + " (if-else statement).");
		}
		else
		{
			System.out.println("20 is greater than 10" + " (if-else statement).");
		}
		System.out.println();
		System.out.println("End of Program.");
	}

}
