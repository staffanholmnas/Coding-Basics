using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // Write your code here:

            // This code stores the input in a variable called message.
            string message = Console.ReadLine();

            // Prints out what you wrote 3 times with a line change after the first 2. 
            Console.WriteLine(message + "\n" + message
            + "\n" + message);
        }
    }
}
