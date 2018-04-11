//Brandon Veasey
//10/12/2015
// Chapter 5 – Program e
// External and internal method calls

import java.util.Scanner;

public class CalcAndDisplay 
{
	// sub method calcSales
	public static void calcSales()
	{
		double salesAmount = 0.0, sumOfSales = 0.0, avgOfsales = 0.0;
		int month = 1;
		Scanner keyBoard = new Scanner(System.in);// declares scanner
		while (month <= 12)
		{
			System.out.println("Enter month " + month + " Sales Amount");
			salesAmount = keyBoard.nextDouble(); // declares keyboard input
			sumOfSales = sumOfSales + salesAmount;
			month++;
		}
		keyBoard.close();
		avgOfsales = sumOfSales / 12;
		dspSales(sumOfSales, avgOfsales);
	}
	// sub method dspSales
	public static void dspSales(double sumOfSales, double avgOfsales)
	{
		System.out.println();
		System.out.println("Total yearly Sales ------>" + sumOfSales  + ".");
		System.out.println("Average Monthly Sales --->" + avgOfsales + ".");
		if (sumOfSales >= 500000.00)// rules for if-else statement
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
	}

}
