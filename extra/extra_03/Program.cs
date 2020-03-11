using System;
using System.Collections.Generic;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<int> list = new List<int>();
      Console.WriteLine("How many numbers?");
      int numberOfInputs = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + numberOfInputs + " numbers:");
      int number = 0;
      double sum = 0;
      int total = 1;
      double average = 0;
      for (int i = 0; i < numberOfInputs; i++)
      {
          number = Convert.ToInt32(Console.ReadLine());
          list.Add(number);
      }
      foreach (int item in list)
      {
          sum += item;
          total = total * item;
      }
      average = sum / numberOfInputs;
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + total);
      Console.WriteLine("Their average: " + average);
    }
  }
}
