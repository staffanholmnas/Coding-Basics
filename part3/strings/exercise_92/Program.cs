using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declares integers and an empty string that are needed later.
            int oldest = 2020;
            int length = 0;
            string longestName = "";
            int age = 0;
            int stringCompare = 0;

            // A while loop that asks for user input until an empty line is entered. Enter name, date of birth.
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] parts = input.Split(","); // Splits input into 2 pieces.

                if (Convert.ToInt32(parts[1]) < oldest) // Converts to integer and checks for the oldest.
                {
                    oldest = Convert.ToInt32(parts[1]);
                }
                string word = parts[0]; // Calculates the number of characters in the first part (name). Stores int in length.
                length = word.Length;

                if (length > stringCompare) // Checks for the longest name and stores the string in longestName.
                {
                stringCompare = length;
                longestName = parts[0];
                }
            }
            age = 2020 - oldest; // Gets the age instead of date of birth.

            Console.WriteLine("Longest name: " + longestName); // Prints the results of the longest name and highest age.
            Console.WriteLine("Highest age: " + age);
        }
    }
}



