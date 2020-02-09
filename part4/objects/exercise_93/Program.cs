using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account stevesAccount = new Account("Steve's bank account", 100.00); // Creates a new object called stevesAccount and adds 100 to it.

      stevesAccount.Deposit(20.0); // Calls the deposit method and uses the amount as a parameter. Deposits 20.

      Console.WriteLine(stevesAccount.balance); // Prints the objects balance. Prints "120".


    }
  }
}



