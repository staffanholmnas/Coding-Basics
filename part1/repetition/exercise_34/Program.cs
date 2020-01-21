using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Declares the string for quitting.
      string quit = "no";

      // This while-loop statement will keep asking for an input forever
      // until a condition is met.
      while (true)
      {
        Console.WriteLine("Do you want to continue?");
        string input = Console.ReadLine();

        // If the input string and the quit string are equal then
        // the condition is met and the while loop breaks.
        if (input == quit)
        {
          break;
        }
      }
    }
  }
}
