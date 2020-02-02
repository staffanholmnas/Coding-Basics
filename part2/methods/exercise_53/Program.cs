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
      double answer = (double)numerator/denominator; // The numbers are divided and the rusult is printed.
      string stringAnswer = Convert.ToString(answer); // In order to pass the test, the answer is converted to string and
      string dotReplaced = stringAnswer.Replace(",", "."); // the comma is replaced with a dot.
      Console.WriteLine(dotReplaced);
    }
  }
}
