
// Using a Procedure,
// Write a program and ask the user to enter a few words separated by a space. Use the words to 
// create a variable name with PascalCase convention. For example, if the user types: 
// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
// "NumberOfStudents". If the user doesn't supply any words, display "Error".

using System;
// using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a few words separated by space");
		var input = Console.ReadLine();
		
		if (String.IsNullOrWhiteSpace(input))
			Console.Write("Error");
		
		Console.WriteLine("The converted word in Pascal Case is : {0}", ToPascalCase(input));
	}
	
	public static string ToPascalCase (string input)
	{
		var words = input.Split(' ');
		var singleWordInPascal = "";
		var entireWordInPascalCase = "";
	
		foreach (var word in words)
		{
			singleWordInPascal = char.ToUpper(word[0]) + word.ToLower().Substring(1);	
			entireWordInPascalCase += singleWordInPascal;
		}
		
		return entireWordInPascalCase;
	}
}