using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Asks for your age, converts it to integer.
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      int age = Convert.ToInt32(input);
      
      // If your age is under 18, print that.
      if (age < 18)
      {
        Console.WriteLine("You're under age!");
      }
      // Else, print that you're an adult.
      else
      {  
        Console.WriteLine("You're an adult!");
      }  
    }
  }
}
