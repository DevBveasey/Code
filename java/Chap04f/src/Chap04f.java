import java.util.Scanner;

//Brandon Veasey
// 10/05/2015
// Chapter 4 – Program f
// Capturing user input, using a while loop, and using an if-else statement

public class Chap04f 
{

	public static void main(String[] args) 
	{
		double salesAmount = 0.0, sumOfSales = 0.0, avgOfsales = 0.0;
		int month = 1;
		Scanner keyBoard = new Scanner(System.in);
		while (month <= 12)
		{
			System.out.println("Enter month " + month + " Sales Amount");
			salesAmount = keyBoard.nextDouble();
			sumOfSales = sumOfSales + salesAmount;
			month++;
		}
		System.out.println();
		System.out.println("Total yearly Sales ------>" + sumOfSales  + ".");
		avgOfsales = sumOfSales / 12;
		System.out.println("Average Monthly Sales --->" + avgOfsales + ".");
		if (sumOfSales >= 500000.00)
		{
			System.out.println();
			System.out.println("Yearly Sales Goal Met.");
			System.out.println("Five Percent Salary Increase for All Sales Personnel.");
		}
		else
		{
			System.out.println();
			System.out.println("FAILED TO MEET YEARLY SALES GOAL.");
			System.out.println("FIVE PERCENT SALARY REDUCTION FOR ALL SALES PERSONNEL.");
		}
		keyBoard.close();
		System.out.println();
		System.out.println("End of Program.");
	}

}
