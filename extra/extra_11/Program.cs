using System;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give a sentence:");
      string [] words = Console.ReadLine().Split(" ");
      foreach (string item in words)
      {
          Console.WriteLine(item);
      }
    }
  }
}
