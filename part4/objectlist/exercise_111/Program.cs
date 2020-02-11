using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>(); // Creates new list.
      
      // Loop that asks for first name, last name and id number. Empty line at first name quits.
      while (true) 
      {
          Console.WriteLine("First name:");
          string firstName = Console.ReadLine();
          if (firstName == "")
          {
              break;
          }

          Console.WriteLine("Last name:");
          string lastName = Console.ReadLine();

          Console.WriteLine("Identification number:");
          string identificationNumber = Console.ReadLine();

          // All inputs are assigned to an object and each object added to a list.
          list.Add(new PersonalInformation(firstName, lastName, identificationNumber)); 
      }
      
      Console.WriteLine();
      
      // Prints only the first and last names from each object in the list.
      foreach (PersonalInformation item in list) 
      {
          Console.WriteLine(item.firstName + " " + item.lastName);
      }
    }
  }
}




