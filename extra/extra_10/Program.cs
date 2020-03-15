using System;

namespace extra_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
        }
        public static void PrintArrayInStars(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PrintStars(array[i]);
            }
        }

        public static void PrintStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
