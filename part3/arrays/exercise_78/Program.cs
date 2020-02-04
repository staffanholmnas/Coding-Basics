using System;
using System.Collections.Generic;

namespace exercise_78
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
      Console.WriteLine("");

      // Implement here
      // asking for the two indices
      // and then swapping them
      Console.WriteLine("Give two indices to swap:"); // Prints a text asking for 2 indices.
      int firstSwap = Convert.ToInt32(Console.ReadLine()); // Inputs are declared as 2 integer values.
      int secondSwap = Convert.ToInt32(Console.ReadLine());

      int temp = array[firstSwap]; // First value is stored in a temp variable.
      array[firstSwap] = array[secondSwap]; // The second index is copied to the first.
      array[secondSwap] = temp; // The value of the first index is copied to the second. Now they have been swapped.


      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
    }

  }
}


