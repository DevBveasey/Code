//Brandon Veasey
//11/02/2015
// Chapter 9 Test
// Creating and processing a Double array

import java.util.Scanner;

public class Chap09test 
{
	// ---- main method----
	public static void main(String[] args) 
	{
		//declares 2-dimensional array
		double[][]scoresArray = new double[5][3];
		//declares 1-dimensional array
		double [] averageArray = new double [5];
		Scanner keyBoard = new Scanner(System.in); //Creates keyboard input
		//Declares two variables initialized to 0.0
		double sum = 0.0, average = 0.0;
		//for loop processes array
		for (int row = 0; row < scoresArray.length; row++)
		{
			// declares sum 0
			sum = 0;
			//for loop processes array
			for (int column = 0; column < scoresArray[row].length; column++)
			{
				// prompts user to enter test scores
				System.out.println("Enter Test Score:");
				scoresArray[row][column] = keyBoard.nextDouble();
				//calculates sum
				sum = sum + scoresArray[row][column];
			}
			//calculate average
			average = sum / 3;
			averageArray[row]= average;
		}
		System.out.println();
		//dispays calculated results message
        System.out.println("Calculated Results:");
      //for loop processes array
        for (int row = 0; row < scoresArray.length; row++)
        {
        	//displays calculated output message to the user
        	System.out.println("Student " + (row + 1) + " has a " + Math.round(averageArray[row])  + " average." );
        	
        }
        keyBoard.close();   //closes keyboard
		//End of Program
		System.out.println();
		System.out.println("End of Program.");
	}

}
