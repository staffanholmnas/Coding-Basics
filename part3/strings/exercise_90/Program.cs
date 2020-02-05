using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>(); // Creates a new list.

      int age = 0; // Declares an integer called age that is needed later.
      
      while (true) // A loop that asks for inputs until an empty line is entered.
      {
        string input = Console.ReadLine();
        
        if (input == "")
        {
          break;
        }
        
        string[] array = input.Split(","); // Splits the input strings at every comma, each part stored in the array. 
        
        age = Convert.ToInt32(array[1]); // Converts the second string entered to an integer stored in the variable age.
        
        list.Add(age); // Adds the integer to the list.
        
      }
      // The following code searches for the greatest value in the list.

      int greatest = list[0]; // The first value int the list is the greatest.

      for(int i = 0; i < list.Count; i++) // Iterates through the indices of the list.
      {
        int number = list[i]; // Each value in the list is stored in a variable called number.

        if (greatest < number) // Checks if the value is bigger than the previous value for each iteration.
        {
          greatest = number; // If the value was smaller, nothing happens. If it was bigger, the value is
          // stored in the variable greatest so it can be checked again in the next iteration. 
        }
      }

        int oldest = greatest; // The greatest value in the list is the oldest person.
        
        Console.WriteLine("Age of the oldest: " + oldest); // Prints the oldest person in the list.
    }
  }
}



