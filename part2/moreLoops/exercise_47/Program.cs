using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?"); // Asks for an input.
      int lastnumber = Convert.ToInt32(Console.ReadLine()); // This is the last number.
      
      Console.WriteLine("Where from?"); // Asks for another input.
      int firstnumber = Convert.ToInt32(Console.ReadLine()); // This is the first number.

      for (int i = firstnumber; i <= lastnumber; i++) // Loop prints every number between first and last.
      {
          Console.WriteLine(i);
      }
    }
  }
}
