using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Stars in different patterns.
            
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17,3);
            PrintTriangle(4);
            PrintRightTriangle(4);

            Console.WriteLine("");

            // Adds a list of names and prints them.
            List<string> list = new List<string>();  

            list.Add("Tom");
            list.Add("Steve");
            list.Add("lake");
            list.Add("Agaton");

            list.RemoveAt(3);
            list.ForEach(Console.WriteLine);
            Console.WriteLine("");

            // Adds a list of numbers and prints them. 
            List<double> matrix = new List<double>();

            matrix.Add(2.5);
            matrix.Add(1);
            matrix.Add(5.34);
            matrix.Add(7);

            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(matrix[i]);
                
            }
            
            if (matrix.Contains(7)) // Checks for a number 7 in the list of values.
                {
                   Console.WriteLine("This list has a 7"); 
                }

            Console.WriteLine("The sum is:");

            double sum = 0;
            foreach (double item in matrix) // Adds all values in the list and prints the sum.
            {
                sum = item + sum;
            }
            Console.WriteLine(sum);
            Console.WriteLine("");
            // Adds an array and some elements.
            
            int[] values = new int[4];

            values[0] = 2;
            values[1] = 0;
            values[2] = 2;
            values[3] = 0;

            foreach (int print in values)
            {
                Console.Write(print);
            }
            Console.WriteLine("");
            // Adds a new array with 4 elements and values.
            int[] array = {1, 9, 8, 1};

            // Can't add more values to the array because it was created with 4 elements.

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

        }
        public static void PrintStars(int number) // Method for printing stars.
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
        public static void PrintSquare(int size) // Method for printing squares.
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height) // Method for Printing Rectangles.
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }
        public static void PrintTriangle(int size) // Method for printing triangles.
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
        public static void PrintSpaces(int number) // Method for printing spaces.
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size) // Method for printing a right triangle.
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }
    }
}
