using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Prints a text asking for user input, converts
      // input to an integer number.
      Console.WriteLine("Give a number:");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);

      // Divides the number given with 2 and stores the remainder.
      int remainder = number % 2;

      // If the remainder is 0, then the statement is true and prints
      // it's even, if it's false it prints that it is odd.
      if (remainder == 0 )
      {
        Console.WriteLine("It is even.");
      }

      else
      {
        Console.WriteLine("It is odd.");
      }
    }
  }
}
