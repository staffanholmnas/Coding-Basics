using System;
using System.Collections.Generic;

namespace exercise_89
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

        string[] array = input.Split(" "); // Splits the input strings at every space, each part stored in the array. 

        int lastString = array.Length -1; // Declares an integer that has the last value in the array.

        Console.WriteLine(array[lastString]); // Prints the last string in the array.  
      }

    }
  }
}



