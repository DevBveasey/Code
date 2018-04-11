import java.util.Scanner;

//Brandon Veasey
//09/30/2015
// Chapter 4 – Program d
// Using multiple if statements

public class Chap04d 
{

	public static void main(String[] args) 
	{
		Scanner keyBoard = new Scanner(System.in);
		double numOne= 0.0, numTwo= 0.0, result= 0.0;
		char operator= ' ';
		System.out.println("Enter first number:" );   
		numOne= keyBoard.nextDouble();
		System.out.println("Enter operator:" );
		operator= keyBoard.next().charAt(0);
		System.out.println("Enter second number:" );
		numTwo = keyBoard.nextDouble();
		System.out.println();
		if (operator == '+')
		{
			result = numOne + numTwo;
			System.out.print("Addition performed --->");
		}
		if (operator == '-')
		{
			result = numOne - numTwo;
			System.out.print("Subtraction performed --->");
		}
		if (operator == '*')
		{
			result = numOne * numTwo;
			System.out.print("Multiplication performed --->" );
		}
		if (operator == '/')
		{
			result = numOne / numTwo;
			System.out.print("Division performed --->");
		}
		if (operator  !=  '+'  &&  operator  !=  '-'  &&  operator  !=  '*'  &&  operator  !=  '/')
		{
			System.out.println("Illegal Operator Entered");
			System.out.print("NO CALCULATIONS PERFORMED ON --->" );
		}
		keyBoard.close();
		System.out.println(numOne + " " + operator + " " + numTwo + " = " + result);
		System.out.println();
		System.out.println("End of Program.");
		
	}

}
