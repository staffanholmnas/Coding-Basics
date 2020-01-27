using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      // Calls a method with a value which represents the amount of time the number is printed.
      PrintUntilNumber(8);  
    }

    // Write your method here:
    public static void PrintUntilNumber(int number) 
    {
      for (int i = 1; i <= number; i++) // Prints from 1 to the number of times specified in the call.
      {
        Console.WriteLine(i);
      }
    }
  }
}
