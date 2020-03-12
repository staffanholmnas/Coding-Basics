using System;

namespace extra_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            ChristmasTree(10);
        }
        public static void ChristmasTree(int height)
        {
          for (int i = 0; i <= height; i++)
          {
              printSpaces(height - i);
              printStars((i * 2) - 1);
              Console.WriteLine();
          }
          printSpaces(height-2);
          printStars(3);
          Console.WriteLine();
          printSpaces(height-2);
          printStars(3);  
        }
        public static void printStars(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.Write("*");
            }
        }
        public static void printSpaces(int numberOfSpaces)
        {
            for (int i = 0; i <= numberOfSpaces; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
