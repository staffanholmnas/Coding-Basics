using System;
using System.Collections.Generic;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

      int sum = 0; // Declares a variable sum with starting value 0.

      foreach (int number in list) // Iterates through the list and adds each number to sum.
      {
        sum = sum + number;  
      }

      Console.WriteLine("Sum: " + sum); // Prints the sum.
    }
  }
}
