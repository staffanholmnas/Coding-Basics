using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input = Convert.ToInt32(Console.ReadLine()); // Input an integer.

      // Loop that starts at input number and adds 1 every loop until the number 100 is reached.
      for (int i = input; i <= 100; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
