using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      
      // Asks for a number, converts it to integer.
      Console.WriteLine("Your speed:");
      string input = Console.ReadLine();
      int speed = Convert.ToInt32(input);
      
      // If the number is more than a set value, it prints a message.
      if (speed > 120)
      {
        Console.WriteLine("Speeding!");
      }  
    }
  }
}
