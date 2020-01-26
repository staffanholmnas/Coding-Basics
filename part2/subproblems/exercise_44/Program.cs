using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int first = Convert.ToInt32(Console.ReadLine()); // Takes 2 input integers, first and second.
      int second = Convert.ToInt32(Console.ReadLine());

      if (first > second)
      {
        Console.WriteLine(first + " is greater than " + second + "."); // If the first is greater, print this.
      }
      
      else if (first < second)
      {
        Console.WriteLine(first + " is less than " + second + "."); // If the first is smaller, print this.
      }

      else
      {
        Console.WriteLine(first + " is equal to " + second + "."); // Otherwise they are equal, print this.
      }

    }
  }
}
