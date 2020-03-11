using System;

namespace extra_06
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 + number2 < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Sqrt(number1 + number2));
            }
        }
    }
}
