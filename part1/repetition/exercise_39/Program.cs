using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Assigns starting value for the total and the exit value.
      int exit = 0;
      int total = 0;

      // While loop statement that loops until exit value is entered.
      while (true)
      {
        // Asks for number input, converts to int.
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // If the number is equal to exit value, the program quits.
        if (number == exit)
        {
          break;
        }
        
        // Your number is added to the total everytime you enter a number.
        total = total + number;
        
      }

      // Prints the total sum of all numbers entered.
      Console.WriteLine("Total sum of numbers: " + total);
    }
  }
}
