using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Stores the number given and converts it to double.
      Console.WriteLine("Give the first number!");
      string input1 = Console.ReadLine();
      double num1 = Convert.ToDouble(input1);

      // Stores the number given and converts it to double.
      Console.WriteLine("Give the second number!");
      string input2 = Console.ReadLine();
      double num2 = Convert.ToDouble(input2);

      // Calculates the equations and stores the results as double values.
      double sum = num1 + num2;
      double difference = num1 - num2;
      double product = num1 * num2;
      double quotient = num1 / num2;

      // Prints out the equations and the results.
      Console.WriteLine(num1 + " + " + num2 + " = " +  sum + "\n" +
      num1 + " - " + num2 + " = " + difference + "\n" +
      num1 + " * " + num2 + " = " + product + "\n" +
      num1 + " / " + num2 + " = " + quotient); 
    }
  }
}
