using System;
using System.Collections.Generic;

namespace exercise_90
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The while loop asks for user input until an empty line is entered. Enter: name,age.
            int oldest = 0;
            while (true) 
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] array = input.Split(","); // Splits the strings into 2 parts and stores them in an array.

                if (Convert.ToInt32(array[1]) > oldest) // Converts to integer and checks if the value is the largest.
                {
                    oldest = Convert.ToInt32(array[1]); // The largest value is stored in the variable oldest.
                }
            }
            Console.WriteLine("Age of the oldest: " + oldest); // Prints the oldest age.
        }
    }
}



