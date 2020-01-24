using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Asks for 2 user inputs as integers. Converts to int.
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());

      int sum = number1 + number2; // Adds the numbers.

      double squareroot = Math.Sqrt(sum); // Takes the square root of sum.

      Console.WriteLine(squareroot); // Prints the squareroot.
    }
  }
}
