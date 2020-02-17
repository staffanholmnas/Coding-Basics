using System;
using System.Collections.Generic;

namespace exercise_124
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implement your program here!

          List<int> list = new List<int>(); // Creates a new list object.

         list = null; // The list is nulled.
         list.ForEach(Console.WriteLine); // Tries to do something with the list, but we get a NullReferenceException error instead.

        }
    }
}
