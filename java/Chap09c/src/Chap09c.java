//Brandon Veasey
//11/02/2015
// Chapter 9 – Program c
// Accessing configuration (command-line) arguments

public class Chap09c 
{
    // ---- main method ----
	public static void main(String[] args) 
	{
		//declares varibles
		double originalPrice = 0.0, discountRate = 0.0;
		//pupolates variables with args array
		originalPrice = Double.parseDouble((args[0]));
		discountRate = Double.parseDouble((args[1]));
		//passes variables to sub method
		calcDiscount( originalPrice, discountRate);
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}
	// ---- calcDiscount ----
	//excepts 2 arguments
	public static void calcDiscount(double originalPrice, double discountRate)
	{
		// declares variable newPrice and initilizes to 0.0
		double newPrice = 0.0;
		//calculates newPrice
		newPrice  = originalPrice - (originalPrice * (( double) discountRate / 100) );
		//passes variables to sub method
        dspNewPrice(originalPrice, discountRate, newPrice);
	}
	// ---- dspNewPrice ----
	//excepts 3 arguments
	public static void  dspNewPrice(double originalPrice, double discountRate, double newPrice)
	{
		//Display the entire “This program was configured” message
		System.out.println("This program was configured with an original price of " + originalPrice + " and a discount rate of " + discountRate + ".");
		//Display the entire “The new discounted price” message (round to 2 decimal places)
		System.out.println("The new discounted price is " + Math.round(newPrice * 100.0) / 100.0 + ".");
	}
}
