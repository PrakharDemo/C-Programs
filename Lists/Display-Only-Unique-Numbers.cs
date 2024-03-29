//Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
//The list of numbers may include duplicates. Display the unique numbers that the user has entered.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		bool entry = true;
		int count=0;
		var numbers = new List<int>();
		var uniques = new List<int>();
		while (entry)
		{
			Console.WriteLine("Please enter a number or type 'Quit' to exit");
			var input = Console.ReadLine();
			if (input.ToUpper()=="QUIT")
				break;
			else
				numbers.Add(Convert.ToInt32(input));
		}
		
		foreach (var number in numbers)
		{
			if (!(uniques.Contains(number)))
				uniques.Add(number);
		}
		
		Console.WriteLine("The unique numbers are:");
		
		foreach (var number in uniques)
			Console.WriteLine(number);
	}
}