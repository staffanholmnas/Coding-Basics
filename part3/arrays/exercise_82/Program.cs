using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 }; // Creates a new array with values.
      PrintArrayInStars(array); // Calls the method for printing the corresponding amount of stars for each value.
    }

    public static void PrintArrayInStars(int[] array) // Method for iterating over every element in the array.
    {
      
      for (int i = 0; i < array.Length; i++) 
      {
        int value = array[i];
        PrintStars(value); // For each value a method is called that replaces the value with the same amount of stars.
      }
    }
    public static void PrintStars(int number) // Method for printing stars.
    {
      for (int i = 0; i < number; i++) // Each number is replaced with the same amount of stars. 
      {
        Console.Write("*"); 
      }
      Console.WriteLine(""); // Change line so each element in the array has its own line of stars.
    }
  }
}

