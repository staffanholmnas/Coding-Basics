using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true) // A loop that asks for inputs until an empty line is entered.
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }

        string[] array = input.Split(" "); // Splits the input strings at every whitespace, each part stored in the array. 
        
        for (int i = 0; i < array.Length; i++) // Iterates over every element in the array and prints them out one by one.
        {
          Console.WriteLine(array[i]); // Outputs each string in the array.
        }
      }
    }
  }
}

