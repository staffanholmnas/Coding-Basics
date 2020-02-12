using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {   
            // Reads inputs until "end" is entered, then prints the number of inputs.
            int numberOfInputs = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                numberOfInputs++;
            }

            Console.WriteLine(numberOfInputs);
        }
    }
}
