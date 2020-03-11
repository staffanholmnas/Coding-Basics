using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
        Console.WriteLine("Give your percentage [0-100]:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input <= 0)
        {
            Console.WriteLine("Impossible");
        }
        else if (input <= 49)
        {
            Console.WriteLine("Fail");
        }
        else if (input <= 59)
        {
            Console.WriteLine("Grade: 1");
        }
        else if (input <= 69)
        {
            Console.WriteLine("Grade: 2");
        }
        else if (input <= 79)
        {
            Console.WriteLine("Grade: 3");
        }
        else if (input <= 89)
        {
            Console.WriteLine("Grade: 4");
        }
        else if (input <= 100)
        {
            Console.WriteLine("Grade: 5");
        }
        else
        {
            Console.WriteLine("Outstanding!");
        }
    }
  }
}
