using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine());

      // Implement the search functionality here
      // The notFound variable could also be of type boolean.
      int notFound = 1; // If this variable turns to 1 the last message is printed.

      for (int i = 0; i < array.Length; i++) // Iterates over the indices in the array.
      {
          if (array[i] == searching) // If the value in the array matches the value we search for, then a message is printed.
          {
            Console.WriteLine(searching + " is at index " + i + ".");
            notFound = 0; // If the value is found, then notFound is 0 and the last message is not printed.
          }
      }

      if (notFound == 1)
      {
        Console.WriteLine(searching + " was not found."); // Is only printed if the value was not found.
      }
    }
  }
}


