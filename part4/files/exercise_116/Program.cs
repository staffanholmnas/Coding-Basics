using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    { 
      // Read the file data.txt and print the text from it as it is.
      string lines = File.ReadAllText("data.txt");
      Console.WriteLine(lines);
    }
  }
}
