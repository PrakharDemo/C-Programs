// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string[] numbers = new string[100];
		List<int> listOfNumbers = new List<int>();
		const int number = 5;
		int i, j, k = 0;
		bool check = true;
		while (check)
		{
			Console.WriteLine("Please enter a list of numbers separated by comma");
			var input=Console.ReadLine();
			
			if (!(string.IsNullOrWhiteSpace(input)))
			{
				numbers=input.Split(',');
							
				if (numbers.Length<number)
				Console.WriteLine("Invalid List, Please retry");
				else
				{
					check = false;
					break;
				}
			}
			else
				Console.WriteLine("Invalid List, Please retry");
			
		}
		
		foreach (var num in numbers)
		{
			listOfNumbers.Add(Convert.ToInt32(num));
		}
		
		Console.WriteLine("The entered list of numbers is :");
		
		foreach (var num in listOfNumbers)
			Console.WriteLine(num);
		
		
		for (i=0; i<listOfNumbers.Count; i++)
		{
			// k = listOfNumbers[i];
			
			for (j=i+1; j<listOfNumbers.Count; j++)
			{
				if (listOfNumbers[i] > listOfNumbers[j])
				{
					k = listOfNumbers[i];
					listOfNumbers[i] = listOfNumbers[j];
					listOfNumbers[j] = k;
				}
			}
		}
		
		Console.WriteLine("The smallest 3 numbers are:");
		for (i=0;i<3;i++)
			Console.WriteLine(listOfNumbers[i]);
	}
}