
//1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different 
// information.
// If no one likes your post, it doesn't display anything.
// If only one person likes your post, it displays: [Friend's Name] likes your post.
// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your // post.
// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying 
// a name). Depending on the number of names provided, display a message based on the above pattern.


using System;
using System.Collections.Generic;

	public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            int count = 0;
            List<string> names = new List <string>();
            while (check)
            {
                Console.WriteLine("Please enter a name");
                var input = Console.ReadLine();
			
                if (!(string.IsNullOrWhiteSpace(input)))
                {
                    names.Add(input);
                    count++;
                }
                else
                    check=false;
            }
		
            switch (count)
            {
                case 0:
                    break;
			
                case 1:
                    Console.WriteLine("{0} likes your picture ",names[0]);
                    break;
				
                case 2:
                    Console.WriteLine("{0} and {1} like your picture ", names[0], names[1]);
                    break;
				
                default: 
                    Console.WriteLine("{0}, {1} and {2} others like your picture ", names[0], names[1], count-2);
                    break;
            }  
       }
    }
