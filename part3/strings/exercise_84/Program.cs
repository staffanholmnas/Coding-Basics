using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a string: "); // Asks for a string.

      string message = Console.ReadLine(); // Input a string.

      if (message == "true") // If your string says "true", then you got it right.
      {
        Console.WriteLine("You got it right!");
      }
      else
      {
        Console.WriteLine("Try again!");
      }

    }
  }
}

