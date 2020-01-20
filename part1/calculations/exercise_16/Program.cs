using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      // Gives the variable a value, the amount of seconds in a day.
      int secInDay = 86400;

      // Asks for a number, converts it to an integer.
      Console.WriteLine("How many days?");
      string numberOfDays = Console.ReadLine();
      int value = Convert.ToInt32(numberOfDays);

      // Prints the amount of seconds in a day times number of days.
      Console.WriteLine(value * secInDay);


    }
  }
}
