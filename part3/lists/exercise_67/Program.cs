using System;
using System.Collections.Generic;

namespace exercise_67
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      int numberOfValues = list.Count; // Stores the number of strings that's been entered in numberOfValues.

      int lastInIndex = numberOfValues -1; // Since the first string is stored in index 0, we have to subtract 1 to get the last entry.

      Console.WriteLine(list[0]); // Prints the first value from the list.

      Console.WriteLine(list[lastInIndex]); // Prints the last string.

    }
  }
}
