using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for a number, converts it to integer.
      Console.WriteLine("Give a number:");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      
      // If the number positive, print a positive message.
      if (number > 0)
      {
        Console.WriteLine("It is positive");
      }
      // Else, print a negative message.
      else
      {  
        Console.WriteLine("It is not positive");
      }  
    }
  }
}
