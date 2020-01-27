using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7); // Calls the method asking for the smallest number.
      Console.WriteLine("Smallest: " + answer); // Prints the smallest number.
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
    {
      if (number1 < number2) // Returns the smaller of the 2 values.
      {
        return number1;
      }
      else
      {
        return number2;
      }
    }
  }
}
