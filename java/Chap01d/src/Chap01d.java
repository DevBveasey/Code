// Brandon Veasey
// 08.26.2015
// Chapter 1 – Program d
// String manipulation, uppercase, lowercase, and concatenation
public class Chap01d 
{

	public static void main(String[] args) 
	{
		String strOne = new String("Characters to Manipulate");
		System.out.println(strOne);
		System.out.println(strOne.toUpperCase());
		System.out.println(strOne.toLowerCase());
		System.out.println();
		String strTwo;
		strTwo="Additional Characters to Manipulate ";
		System.out.println(strTwo);
		System.out.println(strTwo.toUpperCase());
		System.out.println(strTwo.toLowerCase());
		System.out.println();
		String strThree, strFour;
		strThree="Even More Characters ";
		strFour="to Manipulate";
		System.out.println(strThree +" " +strFour.toUpperCase());
		System.out.println(strThree.toUpperCase() +" " + strFour.toUpperCase());
		System.out.println(strThree.toLowerCase() + " " + strFour.toLowerCase());
		System.out.println();
		System.out.println("End of Program.");
	}

}
