// Brandon Veasey
// 09/21/15
// Chapter 3 – Program c
// Using relational and boolean operators
public class Chap03c 
{

	public static void main(String[] args) 
	{
		int intOne= -3, intTwo= 1, intThree= 5, intFour= 10, intFive= 20;
		System.out.println("1.  Comparison result using (or) is  " + (intOne < 1 || intOne > 10) + ".");
		System.out.println("2.  Comparison result using (or) is  " + (intTwo < 1 || intTwo > 10) + ".");
		System.out.println("3.  Comparison result using (or) is  " + (intThree < 1 || intThree > 10) + ".");
		System.out.println("4.  Comparison result using (or) is  " + (intFour < 1 || intFour > 10) + ".");
		System.out.println("5.  Comparison result using (or) is  " + (intFive < 1 || intFive > 10) + ".");
		System.out.println(); 
		System.out.println("6.  Comparison result using (and) is  " + (intOne < 1 && intTwo > 5) + ".");
		System.out.println("7.  Comparison result using (and) is  " + (intTwo < 2 && intThree > 4) + ".");
		System.out.println("8.  Comparison result using (and) is  " + (intThree < 6 && intFour > 9) + ".");
		System.out.println("9.  Comparison result using (and) is  " + (intFour < 11 && intFive > 19) + ".");
		System.out.println("10. Comparison result using (and) is  " +  (intFive < 20 && intFour > 10) + ".");
		System.out.println();
		System.out.println("11. Comparison result using (not) is  " + (intOne != -4 && intTwo != 2) + ".");
		System.out.println("12. Comparison result using (not) is  " + (intTwo != 1 && intThree != 5) + ".");
		System.out.println("13. Comparison result using (not) is  " + (intThree != 5 && intFour != 10) + ".");
		System.out.println("14. Comparison result using (not) is  " + (intFour != 10 && intFive != 20) + ".");
		System.out.println("15. Comparison result using (not) is  " + (intFive != 21 && intFour != 11) + ".");
		System.out.println();
		System.out.println("End of Program.");
		
	}

}
