using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for your year of birth, converts it to integer.
      Console.WriteLine("Give your age:");
      string input = Console.ReadLine();
      int year = Convert.ToInt32(input);
      
      // If the year is less than 1900, it prints a message.
      if (year < 1900)
      {
        Console.WriteLine("You're old");
      }
    }
  }
}
