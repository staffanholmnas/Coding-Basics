using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17,3);
            PrintTriangle(4);
            PrintRightTriangle(4);
        }
        public static void PrintStars(int number)
        {
        // you can print one star with the command
        // Console.Write("*");
        // call the print command n times
        // in the end print a line break with the comand
        // Console.WriteLine("");
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        public static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }
        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }
    }
}
