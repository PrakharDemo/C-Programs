
// Write a program and ask the user to enter an English word.
// Count the number of vowels (a, e, o, u, i) in the word. 
// So, if the user enters "inadequate", the program should display 6 on the console.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a word");
		var input = Console.ReadLine();
		
		var word = input.ToLower();
		int vowelsCount = 0;
		
		var vowels = new List<char>() {'a', 'e', 'i', 'o', 'u'};
		
		foreach (var letter in word)
		{
			if (vowels.Contains(letter))
				vowelsCount ++;
		}
		
		Console.WriteLine("The word {0} has {1} vowels", word, vowelsCount);
	}
}