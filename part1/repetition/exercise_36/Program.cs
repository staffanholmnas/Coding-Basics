using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // Declares an integer value for exiting the program.
      int quit = 0;
      

      // This while-loop statement will keep asking for a number to be 
      // input forever until a condition is met.
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();

        // The string is converted to an integer called number. 
        int number = Convert.ToInt32(input);

        // Declares the function for an integer named power.
        int power = number * number;

        // If the input number and the quit number are equal then
        // the condition is met and the while loop breaks and exits the program.
        // 
        if (number == quit)
        {
          break;
        }

        // If the entered number is negative, a message appears. The loop continues.
        if (number < 0)
        {
            Console.WriteLine("That is negative");
        }

        // If the number is positive, it is calculated to the power of 2 and the 
        // result is printed. The loop continues.
        if (number > 0)
        {
            Console.WriteLine(power);
        }
      }
    }
  }
}
