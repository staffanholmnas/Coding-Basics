using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a number, the value is assigned as a string.
      Console.WriteLine("Give a number!");

      string input = Console.ReadLine();

      // The string is converted to an integer.
      int number = Convert.ToInt32(input);

      // The integer is printed out.
      Console.WriteLine("You gave " + number);

  
    } 
  }
}
