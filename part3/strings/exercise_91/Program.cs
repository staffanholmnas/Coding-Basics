using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> listOfAges = new List<int>(); // Creates a new list for ages.
      List<string> listOfNames = new List<string>(); // Creates a new list for names.

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
        
        listOfAges.Add(age); // Adds the integer to the ages list.
        listOfNames.Add(array[0]); // Adds the names to list of names.
      }
        int indexOfOldest = OldestAge(listOfAges); // Calls the method OldestAge that searches the list for the largest value. Gets the INDEX of the oldest person.
        string nameOfOldest = listOfNames[indexOfOldest]; // The index for the oldest age corresponds to the index of the name of the oldest.
        // The name of oldest is taken from the list using the same index as the list of ages. The name is stored in the variable name of oldest.
        
        Console.WriteLine("Name of the oldest: " + nameOfOldest); // Prints the oldest person in the list.
    }
    public static int OldestAge(List<int> list) // Method that gets the greatest value from the list.
    {
      int greatest = list[0]; // The first value int the list is the greatest.
      int index = 0;

      for(int i = 0; i < list.Count; i++) // Iterates through the indices of the list.
      {
        int number = list[i]; // Each value in the list is stored in a variable called number.
        

        if (greatest < number) // Checks if the value is bigger than the previous value for each iteration.
        {
          greatest = number; // If the value was smaller, nothing happens. If it was bigger, the value is
          // stored in the variable greatest so it can be checked again in the next iteration. 
          index = i;
        }
      }
      return index; // Returns the largest value.
    }
  }
}



