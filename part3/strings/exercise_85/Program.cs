using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:"); // Asks for 2 inputs, username and password.
      string username = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string password = Console.ReadLine();

      if (username == "alex" && password == "sunshine") // Checks for correct username and password for user 1.
      {
        Console.WriteLine("You have successfully logged in!"); // Prints a successful login.
      }
      else if (username == "emma" && password == "haskell") // Checks for correct username and password for user 2.
      {
        Console.WriteLine("You have successfully logged in!"); // Prints a successful login.
      }
      else
      {
        Console.WriteLine("Incorrect username or password!"); // If the login fails print this.
      }
    }
  }
}

