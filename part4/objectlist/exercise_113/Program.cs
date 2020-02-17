using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!

            List<Book> list = new List<Book>(); // Creates new list.

            // Loop that asks for a book name, number of pages and year of publication. Empty line at name of book quits.
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                Console.Write("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                // All inputs are assigned to an object and each object added to the list.
                list.Add(new Book(name, pages, year));
            }

            Console.WriteLine();

            // Enter what information will be printed: everything or name.
            Console.Write("What information will be printed? ");
            string whatToPrint = Console.ReadLine();

            if (whatToPrint == "everything") // Prints everything from the toString method.
            {
                foreach (Book item in list)
                {
                    Console.WriteLine(item);
                }
            }

            if (whatToPrint == "title") // Only prints the name. Changed input string "name" to "title" after the test was altered.
            {
                foreach (Book item in list)
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}



