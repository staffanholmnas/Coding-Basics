using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = {5, 1, 3, 4, 2}; // Creates a new array with 5 values.
      PrintNeatly(array); // Calls the method to print the values.
    }

    public static void PrintNeatly(int[] array)
    {
      for (int i = 0; i < array.Length -1; i++) // Iterates through the array but leaves out the last index.
      {
         Console.Write(array[i] + ", "); // Prints each value followed by a comma and a whitespace.
      }
      Console.Write(array[array.Length -1] + "\n"); // Prints the last index without a comma but adds a line change.
    }
  }
}

