using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a number, converts it to integer.
      Console.WriteLine("Give a number:");
      string input = Console.ReadLine();
      int year = Convert.ToInt32(input);
      
      // If the number is exactly the same as the set value, it prints a message.
      if (year == 1984)
      {
        Console.WriteLine("Orwell");
      }
    }
  }
}
