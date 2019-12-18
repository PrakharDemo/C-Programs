
// Using a Procedure,
// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
// any duplicates. If so, display "Duplicate" on the console.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter few numbers separated by a Hyuphen");
		var input = Console.ReadLine();
		
		if (String.IsNullOrWhiteSpace(input))
		{
			Console.WriteLine("You did not enter anything, hence exiting the program");
			return;
		}
		
		if (IsDuplicate(input))
			Console.WriteLine("The list does not contain any duplicate numbers");
		else
			Console.WriteLine("The list contains duplicates");
	}
	
	public static bool IsDuplicate (string input)
	{
		bool check = true;
		
		var numbers = new List<int>();
		var uniques = new List<int>();
		
		foreach (var number in (input.Split('-')))
			numbers.Add(Convert.ToInt32(number));
		
		foreach (var number in numbers)
		{
			if (!(uniques.Contains(number)))
				uniques.Add(number);
			else
				check = false;
		}
		
		return check;
	}
}