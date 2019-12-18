// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a a date in the 24 hour format, example - 19:00");
		var input = Console.ReadLine();
		
		if (String.IsNullOrWhiteSpace(input))
		{
			Console.Write("Invalid Time");
			return;
		}
		
		var time = input.Split(':');
		
		if (time.Length !=2)
		{
			Console.Write("Invalid Time");
			return;
		}
		
		int hour = Convert.ToInt32(time[0]) ;
		int minute = Convert.ToInt32(time[1]);
		
		if ((hour <=23 && hour >=0) && (minute <=59 && minute >=0))
			Console.Write("Ok");
		else
			Console.Write("Invalid Time");
	}
}