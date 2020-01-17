using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:

            // This statement prints out that you should enter you name.
            Console.WriteLine("What is your name?");

            // The text you entered will be stored as a string in a variable called name.
            string name = Console.ReadLine();

            /* The following prints out a greeting along with whatever text you entered
            followed by an exclamation mark. */
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
