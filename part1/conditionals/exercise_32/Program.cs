using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Prints a text that asks for a string.
      Console.WriteLine("Speak, friend, and enter!");
      string input = Console.ReadLine();
      
      // Declares another string to be the password.
      string password = "Mellon";
      
      // If the 2 strings are equal, then a welcoming text is printed.
      // If not, a hostile text is printed.
      if (input == password)
      {
        Console.WriteLine("Welcome, friend!");
      }

      else
      {
        Console.WriteLine("They've got a cave troll!");
      }
    }
  }
}
