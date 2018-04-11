//Brandon Veasey
//11/23/2015
// Chapter 12 Test
// Throw a New exception

public class ValidateHours extends Exception 
{
	//---- validatehours constructor----
	//accepts no parameters
	public ValidateHours()
	{
	// pass msg text to the exception constructor
		super("HOURS WORKED NOT VALID");
	}
	//---- validatehours constructor----
		//accepts one parameter
	public ValidateHours(String myMessage)
	{
		// assign msg text passed to exception constructor to my massage variable
		super(myMessage);
	}
}
