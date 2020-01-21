using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Declares an integer value for everything.
      int everything = 42;

      // This while-loop statement will keep asking for a number to be 
      // input forever until a condition is met.
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        // If the input number and the number of everything are equal then
        // the condition is met and the while loop breaks.
        if (number == everything)
        {
          break;
        }
      }
    }
  }
}
