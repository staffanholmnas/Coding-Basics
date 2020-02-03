using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>(); // Initizalises a new list called list.
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine()); // Asks for user input and adds the integers to the list. Enter 9999 to stop. 
        if (input == 9999)
        {
          break;
        }
        list.Add(input);
      }
      int smallest = list[0]; // The first value is stored in a variable named smallest. This is the smallest value yet.
      int index = 0; // Declares a variable called index with value 0.

      for(int i = 0; i < list.Count; i++) // Iterates through the indices of the list.
      {
        int number = list[i]; // Each value in the list is stored in a variable called number.
        if (smallest > number) // Checks if the following number on the list is smaller than the first.
        {
          smallest = number; // If the following number is smaller then that number is stored in the smallest variable.
        }
        
      }
      Console.WriteLine("Smallest number: " + smallest); // Prints the smallest number.

      for (int i = 0; i < list.Count; i++) // Starts a new loop checking for the index position of the smallest value. 
      {
        if (smallest == list[i]) // If statement for checking the index of smallest.
        {
          index = i; // Index position is stored in index.
          Console.WriteLine("Found at index: " + index); // Prints the index position on the list.
        }
      }
    }
  }
}
