using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3); // Calls for a method with 3 parameters.
      Console.WriteLine("Greatest: " + answer); // Prints the greatest number.
    }

    // Write your method here:
    public static int Greatest(int number1, int number2, int number3)
    {
      if (number1 > number2 && number1 > number3) // If number 1 is greater than both 2 and 3 it returns the value of number 1.
      {
       return number1;
      }
      if (number2 > number3 && number2 > number1) // If number 2 is greater than both number 1 and 3 then...
      {
       return number2;   // This returns the value of number2.
      }
      else // If none of the above is true, then number 3 must be the greatest. 
      {
        return number3;
      }
    }
  }
}
