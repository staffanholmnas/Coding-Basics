using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a user inputs as integers. Converts to int.
      int number = Convert.ToInt32(Console.ReadLine());

      if (number < 0)
      {
          Console.WriteLine(number * -1); // If the number is negative, it changes it to positive and prints it.
      }
      else
      {
          Console.WriteLine(number); // If the number is positive, it prints it.
      }
      
    }
  }
}
