using System;
using System.Collections.Generic;

namespace exercise_131
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while (true)
            {
                // Asks for 2 user inputs, identifier and name, empty line in either quits.
                Console.WriteLine("Identifier? (empty will stop):");
                string identifier = Console.ReadLine();
                if (identifier == "")
                {
                    break;
                }

                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Item item = new Item(identifier, name); // A new object is created with the inputs as variables.

                // Calls the overridden equals method and compares only the identifier. If they differ, the object is added to the list.
                if (!items.Contains(item))
                {
                    items.Add(item);
                }
            }
            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
