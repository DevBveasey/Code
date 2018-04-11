// Brandon Veasey
// 09/16/2015
// Chapter 3 – Program b
// Math calculations using variables and casting from one type to another

public class Chap03b 
{

	public static void main(String[] args) 
	{
		int numOne= 13, numTwo= 25, numThree= 39, numFour= 25, numFive= 9, sum= 0, divInteger= 0, divRemainder=0;
		double avgOfnumbers= 0.0;
		sum = numOne + numTwo + numThree + numFour + numFive;
		divInteger= sum / 5;
		divRemainder= sum % 5;
		avgOfnumbers= sum / 5.0;
		System.out.println("The sum of the numbers" + " (13 25 39 25 9) " + "is "+sum +  ".");
		System.out.println("The integer part of dividing sum by 5 is " + divInteger + ".");
		System.out.println("The remainder part of dividing sum by 5 is  " + divRemainder + ".");
		System.out.println("The average of the numbers" + " (13 25 39 25 9) " + "is " + avgOfnumbers + ".");
		System.out.println();
		System.out.println("End of Program.");
	}

}
