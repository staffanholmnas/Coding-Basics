using System;
using System.Collections.Generic;

namespace exercise_65
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
      int totalNumberOfInputs = list.Count; // Stores the total number of strings entered.

      Console.WriteLine("In total: " + totalNumberOfInputs); // Prints the total amount of inputs.
    }
  }
}
