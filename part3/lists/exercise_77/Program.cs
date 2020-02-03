using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can try your method here if you want
      List<string> strings = new List<string>(); // New list created.

      strings.Add("First"); // Adds some strings to the list.
      strings.Add("Second");
      strings.Add("Third");
      
      // Remember, this is how you print all the items in a list
      strings.ForEach(Console.WriteLine);

      RemoveLast(strings); // Calls the method for removing the last entry, does this twice.
      RemoveLast(strings);

      strings.ForEach(Console.WriteLine); // Prints all values one by one(only "first" remains).
    }
    public static void RemoveLast(List<string> strings) // The method that is called.
    {
      int last = strings.Count -1; // Determines the index for the last value.
      strings.RemoveAt(last); // Removes the last value from the list.
    }
  }
}


