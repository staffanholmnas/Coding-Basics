using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a number, converts it to integer.
      Console.WriteLine("Give the first number!");
      string input1 = Console.ReadLine();
      int num1 = Convert.ToInt32(input1);

      // Asks for another number, converts it to integer.
      Console.WriteLine("Give the second number!");
      string input2 = Console.ReadLine();
      int num2 = Convert.ToInt32(input2);
      
      // If the first number is larger, print this.
      if (num1 > num2)
      {
        Console.WriteLine("The larger number is " + num1 + "!");
      }
      // If the second number is larger, print this.
      if (num1 < num2)
      {
         Console.WriteLine("The larger number is " + num2 + "!");
      }
      // If the numbers are equal, print this.
      if (num1 == num2)
      {
         Console.WriteLine("They are equal!");
      }
    }
  }
}
