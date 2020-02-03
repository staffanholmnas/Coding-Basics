using System;
using System.Collections.Generic;

namespace exercise_69
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
      Console.WriteLine("From where?");
      int begin = Convert.ToInt32(Console.ReadLine()); // Asks for the number from which to start and stores it in a variable called begin.

      Console.WriteLine("Where to?");
      int end = Convert.ToInt32(Console.ReadLine()); // The last number to be printed from the list is stored in end.
      

      foreach (int number in list) // This goes through every value in the list.
      {
        // If the values that have been stored in the list are between the begin and end range,
        // they are printed.
        if (number >= begin && number <= end) 
        {
          Console.WriteLine(number);  
        }
      }
    }
  }
}
