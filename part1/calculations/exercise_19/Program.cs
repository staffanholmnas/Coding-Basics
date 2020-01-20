using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Asks for a number, stores it as a string and converts it to integer.
      Console.WriteLine("Give the first number!");
      string input1 = Console.ReadLine();
      int num1 = Convert.ToInt32(input1);

      // Asks for another number, stores it as a string and converts it to integer.
      Console.WriteLine("Give the second number!");
      string input2 = Console.ReadLine();
      int num2 = Convert.ToInt32(input2);

      // Adds the 2 numbers.
      int sum = num1 + num2;

      // Prints the equation to the console.
      Console.WriteLine(input1 + " + " + input2 + " = " + sum);
    }
  }
}
