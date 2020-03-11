using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give three numbers:");
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      int number3 = Convert.ToInt32(Console.ReadLine());
      int largest = 0;
      if (number1 > number2 && number1 > number3)
      {
          largest = number1;
      }
      else if (number2 > number1 && number2 > number3)
      {
          largest = number2;
      }
      else
      {
          largest = number3;
      }
      Console.WriteLine("Largest: " + largest);
    }
  }
}
