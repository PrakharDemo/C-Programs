
// Using a Procedure,
// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

using System;
// using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("This program tell whether input time is in HH:MM Format or not");
		
		Console.WriteLine("Please enter a a date in the 24 hour (hh:mm) format, example - 19:00");
		var input = Console.ReadLine();
		
		bool check=IsTimeHHmmOrNot(input);
			
		if (check) 
			Console.WriteLine("Ok");
		else
			Console.WriteLine("Invalid Time");
	}
	
	public static bool IsTimeHHmmOrNot (string input)
	{
		if (String.IsNullOrWhiteSpace(input))
				return false;
		
		var time = input.Split(':');
		int hour = Convert.ToInt32(time[0]) ;
		int minute = Convert.ToInt32(time[1]);
				
		if (time.Length !=2)
			return false;
		
		else if ((hour <=23 && hour >=0) && (minute <=59 && minute >=0))
			return true;
		
		else
			return false;
	}
}