using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      // Write your code here:

      // Assigns starting value for count and the exit value.
      int exit = 0;
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
        
        // 1 is added to the count value everytime the loop is run.
        count = count + 1;
      }

      // Prints the number of times an integer was entered.
      Console.WriteLine("Total amount of numbers: " + count);
    }
  }
}
