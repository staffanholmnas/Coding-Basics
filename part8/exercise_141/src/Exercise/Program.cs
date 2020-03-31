using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
            Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
            books.Add(senseAndSensibility.name, senseAndSensibility);
            books.Add(prideAndPrejudice.name, prideAndPrejudice);
        
            PrintValues(books);
            Console.WriteLine("-- -- -- --");
            // Note that even though the string that's being passed is all lower case, the value is still printed.
            PrintValueIfNameContains(books, "prejud");
        }

        public static void PrintValues(Dictionary<string, Book> dictionary)
        {
            foreach (KeyValuePair<string, Book> item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
        }
        public static void PrintValueIfNameContains(Dictionary<string, Book> dictionary, string text)
        {
          foreach (KeyValuePair<string, Book> item in dictionary)
            {
              // Note that the name of the object that is being checked is also converted to lower case.
              if (item.Value.name.ToLower().Contains(text) || item.Value.name.Contains(text))
              {
                  Console.WriteLine(item.Value);
              }
            }
        }
    }
}

