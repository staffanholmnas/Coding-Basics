using System;

namespace exercise_18
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

      // Asks for a third number, stores it and converts to int.
      Console.WriteLine("Give the third number!");
      string input3 = Console.ReadLine();
      int num3 = Convert.ToInt32(input3);

      // Prints the two numbers as a sum.
      Console.WriteLine("The sum is " + (num1 + num2 + num3));

    }
  }
}
