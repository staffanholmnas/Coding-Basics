using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!

      Account heikkisAccount = new Account("Heikki's account", 1000.0); // Creates 2 new objects.
      Account personalAccount = new Account("Personal account", 0);

      heikkisAccount.Withdrawal(100.0); // Calls methods to withdraw and deposit.
      personalAccount.Deposit(100.0);

      Console.WriteLine(heikkisAccount); // Calls toString method that returns the balances.
      Console.WriteLine(personalAccount);
    }
  }
}



