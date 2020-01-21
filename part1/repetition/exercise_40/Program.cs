using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Assigns starting values for the total, count and the exit variables.
      int exit = 0;
      int total = 0;
      int count = 0;
    

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
        
        // Continuosly adds your number to a total.
        total = total + number;

        // Your number is added to the total everytime you enter a number.
        count = count + 1;
      }

      // Prints the total sum of all numbers entered.
      Console.WriteLine("Total sum of numbers: " + total);

      // Prints the total amount of numbers entered.
      Console.WriteLine("Total amount of numbers: " + count);

    }
  }
}
