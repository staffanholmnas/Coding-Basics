using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      // Calls the method and gives it 2 values.
      Division(1,4);
    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
    {
      Console.WriteLine((double)numerator/denominator); // The numbers are divided and the rusult is printed.
    }
  }
}
