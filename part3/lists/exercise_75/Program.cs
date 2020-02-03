using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {


      // Example method calls for testing your method.
      List<int> numbers = new List<int>(); // Creates a new list called numbers and adds a bunch of values to it.
      numbers.Add(5);
      numbers.Add(2);
      numbers.Add(6);
      numbers.Add(-1);
      numbers.Add(3);
      numbers.Add(8);
      numbers.Add(9);
      numbers.Add(-5);
      numbers.Add(1);

      Console.WriteLine("The numbers in the range [0, 5]"); // Calls a method that prints all values within a given range.
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]"); // Same method, different range.
      PrintNumbersInRange(numbers, 3, 10);
    }

    public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit) // Method for a list with limits.
    {
      foreach (int number in numbers) // Iterates through the numbers list.
      {
        if (number >= lowerLimit && number <= upperLimit) // Checks if the values in the list are within the limits and prints them one by one.
        {
          Console.WriteLine(number);
        }
      }
    }
  }
}

