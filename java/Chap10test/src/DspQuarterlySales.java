//Brandon Veasey
//11/11/2015
// Chapter 10 Test
// Utilizing the advantages of inheritance

public class DspQuarterlySales 
{
	// sub method excepts 2 variables
	public void dspQrtSales(String quarterText,double dspFirstQtr )
	{
		//displays quartly sales
		System.out.println(quarterText + ' ' + dspFirstQtr);
	}
	// sub method excepts 2 variables
	public void dspYearlySales(double sumOfSales,double avgOfSales)
	{
		//displays yearly sales and monthly average
		System.out.println("Total Yearly Sales ------> $" + Math.round(sumOfSales*100.0)/100.0 + ".");
		System.out.println("Average Monthly Sales ---> $" + Math.round(avgOfSales * 100.0) / 100.0 + ".");
	}

}
