using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      // A text is printed that says that you should
      // enter an integer number. The text is converted from
      // a string to an integer and the value assigned to num.
      Console.WriteLine("Give your percent [0 - 100]:");

      string input = Console.ReadLine();

      int num = Convert.ToInt32(input);

      // This statement checks if the value is less than 0 and prints a text if it is.
      if (num < 0)
      {
          Console.WriteLine("Impossible");
      }

      // If the previous statement was false, then the following 
      // else if statements checks if the value is within a 
      // certain interval and prints only the text for that interval.
      else if (num < 50)
      {
          Console.WriteLine("Fail");
      }

      else if (num < 60)
      {
          Console.WriteLine("Grade: 1");
      }

      else if (num < 70)
      {
          Console.WriteLine("Grade: 2");
      }

      else if (num < 80)
      {
          Console.WriteLine("Grade: 3");
      }

      else if (num < 90)
      {
          Console.WriteLine("Grade: 4");
      }

      else if (num < 101)
      {
          Console.WriteLine("Grade: 5");
      }

      // If none of the above statements were true, then 
      // the final text is printed.
      else
      {
          Console.WriteLine("Outstanding!");
      }
    }
  }
}
