using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Asks for a number, stores it as a string and converts it to double.
      Console.WriteLine("Give the first number!");
      string input1 = Console.ReadLine();
      double num1 = Convert.ToDouble(input1);

      // Asks for another number, stores it as a string and converts it to double.
      Console.WriteLine("Give the second number!");
      string input2 = Console.ReadLine();
      double num2 = Convert.ToDouble(input2);

      // Asks for a third number, stores it as a string and converts it to double.
      Console.WriteLine("Give the third number!");
      string input3 = Console.ReadLine();
      double num3 = Convert.ToDouble(input3);

      // Adds the 3 numbers and divides them by 3.
      double avg = (num1 + num2 + num3)/3;

      // Prints the average to the console.
      Console.WriteLine("The average is " + avg);
    }
  }
}
