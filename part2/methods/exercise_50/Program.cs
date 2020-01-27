using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?"); 
      int numberOfTimes = Convert.ToInt32(Console.ReadLine());  // Type how many times it should print.

      int print = 0; // Starting value.

      while (print < numberOfTimes) // Runs the loop as many times as you entered.
      {
      PrintPhrase();  // Calls the method that prints the text.
      print++; // Adds 1 everytime the loop is ran.
      }
    }

    // Write your method here:
    public static void PrintPhrase() // My print method.
    {
      Console.WriteLine("In a hole in the ground there lived a method"); // The line that should be printed.
    }
  }
}
