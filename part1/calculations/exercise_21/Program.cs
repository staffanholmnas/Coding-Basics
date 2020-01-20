using System;

namespace exercise_21
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

      // Adds the 2 numbers and divides the by 2.
      double avg = (num1 + num2)/2;

      // Prints the average to the console.
      Console.WriteLine("The average is " + avg);
    }
  }
}
