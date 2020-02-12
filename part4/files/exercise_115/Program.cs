using System;

namespace exercise_115
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Reads inputs until the word "end" is entered. Every number is cubed and printed.
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                int number = Convert.ToInt32(input);
                int cubed = number * number * number;
                Console.WriteLine(cubed);
            }
        }
    }
}
