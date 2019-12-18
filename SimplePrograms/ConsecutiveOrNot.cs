
// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a few numbers separated by a Hyphen : '-'");
		var input = Console.ReadLine();
		
		var numList = new List<int>();
		int i = 1;
		bool check = true;
		
		foreach (var number in input.Split('-'))
		{
			numList.Add(Convert.ToInt32(number));
		}
		
		numList.Sort();
		
		while (i<numList.Count)
		{
			if (numList[i] != (numList[i-1] + 1))
			{
				check = false;
				break;
			}
			
			i++;
		}
		
		var message = check? "Consecutive" : "Not consecutive";
		
		Console.WriteLine(message);
	}
}