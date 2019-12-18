
// Write a program and ask the user to enter 5 numbers. 
// If a number has been previously entered, display an error message and ask the user to re-try. 
// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

using System;
					
public class Program
{
	public static void Main()
	{
		const int size=5;
		int[] numbers = new int[size];
		int count=1;
		int num=0;
		
		while (count<=size)
		{
			Console.WriteLine("Please enter a number");
			num=Convert.ToInt32(Console.ReadLine());
			if (Array.IndexOf(numbers,num) <0)
			{
				numbers[count-1]=num;
				count++;
			}
			else
				Console.WriteLine("Error - the last number has been entered already");
		}
		
		Console.WriteLine("The entered array is :");
		for (int i=0; i<size; i++)
			Console.WriteLine(numbers[i]);
		
		int[] numSorted = new int[size];
		Array.Sort(numbers);
		
		Console.WriteLine("The sorted array is :");
		for (int i=0; i<size; i++)
			Console.WriteLine(numbers[i]);
	}
}