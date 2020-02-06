using System;
using System.Collections.Generic;

namespace exercise_91
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = ""; // Empty string and integer that are needed later.
            int oldest = 0;

            // The while loop asks for inputs. Empty line quits. Enter: name,age.
            while (true)
            {
                string input = Console.ReadLine(); 

                if (input == "") 
                {
                    break;
                }

                string[] array = input.Split(","); // Splits the 2 strings into 2 parts, splits at comma-sign.

                if (Convert.ToInt32(array[1]) > oldest) // Converts the second value (age) to integer and checks if it is the largest.
                {
                    oldest = Convert.ToInt32(array[1]); // The greatest value is stored in oldest and the first string in name.
                    name = array[0];
                }
            }
            Console.WriteLine("Name of the oldest: " + name); // Prints out the name of the oldest.
        }
    }
}



