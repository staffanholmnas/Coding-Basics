using System;

namespace extra_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("What do you want to print?");
            string printThis = Console.ReadLine();
            Console.WriteLine("How many times do you want to print?");
            int numberOfPrints = Convert.ToInt32(Console.ReadLine());

            Printer(numberOfPrints, printThis);
        }
        static void Printer(int printTimes, string whatToPrint)
        {
            for (int i = 0; i < printTimes; i++)
            {
                Console.WriteLine(whatToPrint);
            }
        }
    }
}
