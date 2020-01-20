using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:

      // The string is stored in the truth variable.
      string truth = Console.ReadLine();

      // The string is converted to a boolean type.
      bool var = Convert.ToBoolean(truth);

      // The bool is printed.
      Console.WriteLine(var);
    }
  }
}
