//Brandon Veasey
// 11/11/15
// Chapter 10 – Program b
// Utilizing the advantages of inheritance

public class ContactInfo extends MailingAddress
{
	// ---- concatText method ----
	//accepts two variable
	public  String concatText(String phoneNo,String email)
	{
		//returns calculated result
		return "Contact Info:     " +  phoneNo + " - " + email;
	}
}
