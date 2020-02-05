using System;
using System.Collections.Generic;

namespace exercise_88
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
        
        Console.WriteLine(array[0]); // Prints the first string in the array.  
      }
    }
  }
}



