using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      ChristmasTree(10); // Calls the christmas tree method, using the value 10.
    }
    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++) // A method that prints a number of stars.
      {
        Console.Write("*");
      }
    Console.WriteLine("");
    }
    public static void PrintSpaces(int number) // The number value determines how many spaces.
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }
    }
    public static void PrintRightTriangle(int size) // A method for drawing a triangle with a size parameter.
    {
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(size - i);
        PrintStars(i);
      }
    }
    public static void ChristmasTree(int height) // Draws a cristmas tree made of stars. Height should be more than 3.
    {
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(height - i);
        PrintStars((2 * i) - 1);
      } 
      PrintSpaces(height - 2);
      PrintStars(3);
      PrintSpaces(height - 2);
      PrintStars(3);
    }
  }
}
