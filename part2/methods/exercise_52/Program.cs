using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      // Calls a method with a value from which the countdown is started.
      PrintFromNumberToOne(5);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number) 
    {
      while (number >= 1) // Counts down from the number in the call to one.
      {
        Console.WriteLine(number);  
        number--; 
      }
    }
  }
}
