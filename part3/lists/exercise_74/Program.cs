using System;
using System.Collections.Generic;

namespace exercise_74
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

      Console.WriteLine("Search for?"); // Asks for a name and stores the input as string.
      string searchName = Console.ReadLine();

        if (list.Contains(searchName)) // Searches the list for the name, outputs accordingly.
        {
          Console.WriteLine(searchName + " was found!");
        }
        else
        {
          Console.WriteLine(searchName + " was not found!");
        }
      
    }
  }
}

