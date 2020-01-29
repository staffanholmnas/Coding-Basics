using System;

namespace exercise_60
{
  class Program
  {
    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for (int i = 0; i < number; i++) // Prints n number of stars followed by a line change.
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }
    public static void PrintSquare(int size) // Prints a square of stars. Size parameter determines the size of the square.
    {
      for (int i = 0; i < size; i++)
      {
        PrintStars(size);
      }
    }
    public static void PrintRectangle(int width, int height) // This method prints stars in a rectangle with 2 parameters.
    {
      for (int i = 0; i < height; i++)
      {
        PrintStars(width);
      }
    }
    public static void PrintTriangle(int size) // This method prints a right-angled triangle.
    {
      for (int i = 1; i <= size; i++)
      {
        PrintStars(i);
      }
    }
    public static void Main(String[] args) // Main method from which all of my methods are called.
    {
      PrintStars(5);
      PrintStars(3);
      PrintStars(9);
      PrintSquare(4);
      PrintRectangle(17,3);
      PrintTriangle(4);
    }
  }
}
