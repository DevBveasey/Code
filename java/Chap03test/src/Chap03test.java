// Brandon Veasey
// 09/21/2015
// Chapter 3 Test
// Math calculations using variables, casting, and concatenation
public class Chap03test 
{

	private static final boolean True = false;
	private static final boolean False = false;

	public static void main(String[] args) 
	{
		int numOne= 26, numTwo= 13, numThree= 34, numFour= 20, numFive= 8, numSix= 53, numSeven= 15, numEight= 29, numNine= 6, numTen= 30, firstSum= 0, secondSum= 0, allSum= 0; 
 double avgFirst= 0.0, avgSecond= 0.0, avgAll= 0.0;
 boolean booOne= True, booTwo= False;
 firstSum= numOne + numTwo + numThree + numFour + numFive;
 secondSum= numSix + numSeven + numEight + numNine + numTen;
 allSum= firstSum + secondSum;
 System.out.println("The sum of the numbers (26 13 34 20 8) is " + firstSum + ".");
 System.out.println("The sum of the numbers (53 15 29 6 30) is " + secondSum + ".");
 System.out.println("The sum of " + firstSum + " and " + secondSum + " is " + allSum + ".");
 System.out.println();
 avgFirst= firstSum / 5.0;
 avgSecond= secondSum / 5.0;
 avgAll= allSum / 10.0;
 System.out.println("The average of the numbers (26 13 34 20 8) is " + avgFirst + ".");
 System.out.println("The average of the numbers (53 15 29 6 30) is " + avgSecond + ".");
 System.out.println("The average of all numbers is  " + avgAll + ".");
 booOne= firstSum > secondSum;
 booTwo= avgFirst < avgSecond;
 System.out.println();
 System.out.println("After comparison - booOne value is " + booOne + ".");
 System.out.println("After comparison - booTwo value is " + booTwo + ".");
 System.out.println();
 System.out.println("End of Program.");
	}

}
