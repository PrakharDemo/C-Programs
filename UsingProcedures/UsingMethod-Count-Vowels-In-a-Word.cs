
// Using a Procedure,
// Write a program and ask the user to enter an English word. Count the number of vowels 
// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a word");
		var input = Console.ReadLine();
		
		Console.WriteLine("The word {0} has {1} vowels", input, CountVowels(input));
	}
	
	public static int CountVowels (string input)
	{
		var word = input.ToLower();
		int vowelsCount = 0;
		
		var vowels = new List<char>() {'a', 'e', 'i', 'o', 'u'};
		
		foreach (var letter in word)
		{
			if (vowels.Contains(letter))
				vowelsCount ++;
		}
		
		return vowelsCount;
	}
}