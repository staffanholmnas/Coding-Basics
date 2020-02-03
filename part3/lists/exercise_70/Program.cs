using System;
using System.Collections.Generic;

namespace exercise_70
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

      int greatest = list[0]; // Sets the first value as the greatest.

      for(int i = 0; i < list.Count; i++) // Iterates through the indices of the list.
      {
      int number = list[i]; // Each value in the list is stored in a variable called number.
        if (greatest < number) // If the newest value in the loop is bigger than the first then...
        {
          greatest = number; // the newest value is the greatest.
        }
      }
      Console.WriteLine("The greatest number: " + greatest); // Prints the greatest number.
    }
  }
}
