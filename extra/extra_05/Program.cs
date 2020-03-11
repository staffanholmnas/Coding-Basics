using System;
using System.Collections.Generic;

namespace extra_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            List<string> list = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Give words, 'end' quits:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                list.Add(input);
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
