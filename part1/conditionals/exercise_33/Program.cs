using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Prints a text that asks for a string and stores it.
      Console.WriteLine("Give the first string:");
      string input1 = Console.ReadLine();

      // Prints a text that asks for another string and stores it.
      Console.WriteLine("Give the second string:");
      string input2 = Console.ReadLine();

      // If the 2 strings are equal, Echo is printed.
      // If not, nope is printed.
      if (input1 == input2)
      {
        Console.WriteLine("Echo!");
      }

      else
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}
