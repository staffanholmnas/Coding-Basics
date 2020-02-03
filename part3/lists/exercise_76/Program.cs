using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>(); // Creates a list called numbers and adds a couple of values to it.
      numbers.Add(3);
      numbers.Add(2);
      numbers.Add(6);
      numbers.Add(-1);

      Console.WriteLine(Sum(numbers)); // Calls a method and expects a value to be returned and then prints it.

      numbers.Add(5); // More values added to the list.
      numbers.Add(1);

      Console.WriteLine(Sum(numbers)); // Calls the method again and prints the returned value.
    }
    public static int Sum(List<int> numbers) // Method for numbers list.
    {
      int sum = 0; // Starting value for sum.
      foreach (int number in numbers) // Goes through every value on the list and adds the values together.
      {
        sum = sum  + number;
      }
      return(sum); // Returns the sum of all the values on the list to the main method, so it can be printed.
    }
  }
}


