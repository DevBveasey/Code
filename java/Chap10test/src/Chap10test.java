//Brandon Veasey
//11/11/2015
// Chapter 10 Test
// Utilizing the advantages of inheritance

import java.util.Scanner;

public class Chap10test 
{
	//declares public variables initializes each to 0.0
static double firstQtrSales = 0.0, SecondQtrSales = 0.0, ThirdQtrSales = 0.0, FourthQtrSales = 0.0;
	//---- Main method ----
	public static void main(String[] args) 
	{
		//declares double variables, initializes each to 0.0
		double salesAmount = 0.0, sumOfSales = 0.0,avgOfSales = 0.0;
		//declares int variable, initializes to 1
		int month = 1;
		//declares string variable, initializes to null
		String quarterText = null;
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		while (month <= 12)
		{
			//prompts user to enter monthly sales data
			System.out.println("Enter Month " + month + " Sales Amount:");
			//declares input as sales amount variable
			salesAmount = keyBoard.nextDouble();
			//calls calcquartlysales method passing 2 variables
			calcQuarterlySales(month, salesAmount);
			//calculates sumofsales
			sumOfSales = sumOfSales + salesAmount;
			//adds one to month for counter
			month++;
		}
		System.out.println();
		//calculates avgofsales
		avgOfSales = sumOfSales / 12;
		//declares pointer to point to class
		DspFirstQtrSales dspFirstQtrPointer = new DspFirstQtrSales();
		//populates quarter text with new data
		quarterText = "  First Quarter Sales -----> ";
		//calls first qtr passing no variables
		dspFirstQtrPointer.dspFirstQtr();
		//calls qrtsales passing 2 valuables
		dspFirstQtrPointer.dspQrtSales(quarterText, firstQtrSales);
		//declares pointer to point to class
		DspSecondQtrSales dspSecondQtrPointer = new DspSecondQtrSales();
		//populates quarter text with new data
		quarterText = "  Second Quarter Sales ----> ";
		//calls second qtr passing no variables
		dspSecondQtrPointer.dspSecondQtr();
		//calls qrtsales passing 2 valuables
		dspSecondQtrPointer.dspQrtSales (quarterText, SecondQtrSales);
		//declares pointer to point to class
		DspThirdQtrSales dspThirdQtrPointer = new DspThirdQtrSales();
		//populates quarter text with new data
		quarterText = "  Third Quarter Sales -----> ";
		//calls third qtr passing no variables
		dspThirdQtrPointer.dspThirdQtr();
		//calls qrtsales passing 2 valuables
		dspThirdQtrPointer.dspQrtSales(quarterText, ThirdQtrSales);
		//declares pointer to point to class
		DspFourthQtrSales dspFourthQtrPointer = new DspFourthQtrSales();
		//populates quarter text with new data
		quarterText = "  Fourth Quarter Sales ----> ";
		//calls fourth qtr passing no variables
		dspFourthQtrPointer.dspFourthQtr();
		//calls qrtsales passing 2 valuables
		dspFourthQtrPointer.dspQrtSales(quarterText, FourthQtrSales);
		System.out.println();
		dspFirstQtrPointer.dspYearlySales(sumOfSales, avgOfSales);
		//closes keyboard
		keyBoard.close();
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}
	public static void calcQuarterlySales(int month, double salesAmount)
	{
		//if statement for first qtr
		if (month == 1 || month == 2 || month ==3)
		{
			//calculates quarters sales total
			firstQtrSales = firstQtrSales + salesAmount;
		}
		//if statement for second qtr
		if (month == 4 || month == 5 || month ==6)
		{
			//calculates quarters sales total
			SecondQtrSales = SecondQtrSales + salesAmount;
		}
		//if statement for third qtr
		if (month == 7 || month == 8 || month ==9)
		{
			//calculates quarters sales total
			ThirdQtrSales = ThirdQtrSales + salesAmount;
		}
		//if statement for fourth qtr
		if (month == 10 || month == 11 || month ==12)
		{
			//calculates quarters sales total
			FourthQtrSales = FourthQtrSales + salesAmount;
		}
	}

}
