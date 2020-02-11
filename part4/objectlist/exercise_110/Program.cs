using System;
using System.Collections.Generic;

namespace exercise_110
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>(); // Creates new list.

            while (true) // Enter items, empty line quits.
            {
                Console.Write("Name: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                items.Add(new Item(input)); // Creates a new object for each item and adds them to the items list.
            }

            Console.WriteLine();
            foreach (Item item in items) // Prints all objects in the list.
            {
                Console.WriteLine(item);
            }
        }
    }
}




