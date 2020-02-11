using System;
using System.Collections.Generic;

namespace exercise_112
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> list = new List<TelevisionProgram>(); // Creates new list.

            // Loop that asks for a tv show and duration. Empty line at name of program quits.
            while (true)
            {
                Console.Write("Name: ");
                string show = Console.ReadLine();
                if (show == "")
                {
                    break;
                }

                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                // All inputs are assigned to an object and each object added to a list.
                list.Add(new TelevisionProgram(show, duration));
            }

            Console.WriteLine();

            // Enter the maximum duration for the tv program.
            Console.Write("Program's maximum duration? ");
            int maxDuration = Convert.ToInt32(Console.ReadLine());

            // Prints the TV program and duration from each object in the list. Doesn't print shows longer than max duration.
            foreach (TelevisionProgram item in list)
            { 
                if (item.duration <= maxDuration)
                {
                    Console.WriteLine(item);
                }
                
            }

        }
    }
}




