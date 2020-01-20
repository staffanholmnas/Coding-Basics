using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Asks you to write something and stores it.
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();

      // Asks you to write a number and converts it to an integer.
      Console.WriteLine("Give an integer:");
      string input1 = Console.ReadLine();
      int number1 = Convert.ToInt32(input1);

      // Asks you to write a number with decimals and converts it to double.
      Console.WriteLine("Give a double:");
      string input2 = Console.ReadLine();
      double number2 = Convert.ToDouble(input2);

      // Asks you to write true or false and converts the string to boolean.
      Console.WriteLine("Give a boolean:");
      string input3 = Console.ReadLine();
      bool var = Convert.ToBoolean(input3);

      // Prints out the converted values of what you wrote.
      Console.WriteLine("Your string: " + message + "\n" +
      "Your integer: " + number1 + "\n" +
      "Your double: " + number2 + "\n" +
      "Your boolean: " + var);
      
      
    }
  }
}
