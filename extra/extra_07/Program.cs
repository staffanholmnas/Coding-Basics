using System;

namespace extra_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int sum = 0;
            Console.WriteLine("Give intgers, 'end' quits:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int numbers = Convert.ToInt32(input);
                sum += numbers;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
