using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a number and assigns the value as a string.
      Console.WriteLine("Give a number!");

      string input = Console.ReadLine();

      // The string is converted to a double.
      Double number = Convert.ToDouble(input);

      // The integer is printed out.
      Console.WriteLine("You gave " + number);

    }
  }
}
