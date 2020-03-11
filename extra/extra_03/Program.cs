using System;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      
      Console.WriteLine("How many numbers?");
      int numberOfInputs = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + numberOfInputs + " numbers:");
      
      int number = 0;
      double sum = 0;
      int total = 1;
      double average = 0;

      while (number < numberOfInputs)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        sum += input;
        total = total * input;
        number++;
      }

      average = sum / numberOfInputs;
      
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + total);
      Console.WriteLine("Their average: " + average);
    }
  }
}
