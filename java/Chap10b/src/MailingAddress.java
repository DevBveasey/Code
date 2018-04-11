//Brandon Veasey
// 11/11/15
// Chapter 10 – Program b
// Utilizing the advantages of inheritance

public class MailingAddress extends FullName
{
	// ---- concatText method ----
	//accepts four variable
	public String concatText(String address, String city, String state, String zipCode)
	{
		//returns calculated result
		return  "Mailing Address:  " + address + " - " + city + " " + state + " " + zipCode;
	}
	public void dspMailingAddress(String addCityStZip)
	{
		//dsp data to user
		System.out.println( addCityStZip);
	}
}
