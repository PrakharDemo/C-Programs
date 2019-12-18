
// Write a program and ask the user to enter a few numbers separated by a hyphen. 
// If the user simply presses Enter, without supplying an input, exit immediately; 
// Otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a few numbers separated by a Hyphen : '-'");
		var input = Console.ReadLine();
		
		var numList = new List<int>();
		int i, j = 0;
		bool check = true;		
		
		if (String.IsNullOrWhiteSpace(input))
			Console.Write("You entered a blank/space/null character. Hence, exiting");
		
		foreach (var number in input.Split('-'))
		{
			numList.Add(Convert.ToInt32(number));
		}
		
		for (i = 0; i<numList.Count; i++)
		{
			for (j = i+1; j<numList.Count; j++)
			{
				if (numList[i] == numList[j])
				{
					check = false;
					break;
				}
			}
		}
		
		if (!check)
			Console.WriteLine("Duplicate");
	}
}