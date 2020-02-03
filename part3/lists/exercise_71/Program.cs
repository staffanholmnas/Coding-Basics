using System;
using System.Collections.Generic;

namespace exercise_71
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
      Console.WriteLine("Search for?");
      int searchForValue = Convert.ToInt32(Console.ReadLine()); // Input the value to search for in the list

      if (list.Contains(searchForValue)) // Checks if the value is in the list.
      {
        for (int i = 0; i < list.Count; i++) // A loop that iterates through every index in the list.
        { 
          if (list[i] == searchForValue) // When the value is found in the list it prints the index of that value.
          {
            Console.WriteLine(searchForValue + " is at index " + i);
          }  
        }
      }     
    }
  }
}
