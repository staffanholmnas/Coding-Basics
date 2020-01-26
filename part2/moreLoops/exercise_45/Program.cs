using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input = Convert.ToInt32(Console.ReadLine()); // Input an integer.

      // Loop that starts at 0 and adds 1 every loop until the input number is reached.
      for (int i = 0; i <= input; i++)
      {
        Console.WriteLine(i);
      }        
    }
  }
}
