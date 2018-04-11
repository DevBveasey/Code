//Brandon Veasey
// 11/11/15
// Chapter 10 – Program b
// Utilizing the advantages of inheritance

public class FullName 
{
	// ---- concatText method ----
		//accepts two variable
	public String concatText(String firstName,String lastName)
	{
		//returns calculated result
		return "Full Name:        " + (firstName + " " + lastName);
	}
	public void dspStringText(String completeName)
	{
		//dsp data to user
		System.out.println(completeName);
	}

}
