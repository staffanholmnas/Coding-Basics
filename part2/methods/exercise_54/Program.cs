using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(8,65); //Calls a method with an increasing range.
    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
      // Checks for every number inside the range starting with the smallest if the remainder after
      // dividing by 3 is zero. If it is it prints the number and continues to check the next number.

      while (beginning <= end)   
      {
        int remainder = beginning%3;
        
        if (remainder == 0)
        {
          Console.WriteLine(beginning);
        }
    
        beginning++;
      }
    }
  }
}
