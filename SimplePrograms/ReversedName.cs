
// Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a 
// new string. Display the reversed name on the console.

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter your name");
		string[] name = new string[30];

		name=Console.ReadLine();

		string reversedName = new string[30];
		reversedName=Array.Reverse(name);

		Console.WriteLine("Your reversed name is {0}",reversedName);
	}
}
		

