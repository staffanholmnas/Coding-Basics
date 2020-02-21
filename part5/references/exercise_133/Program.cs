using System;
using System.Collections.Generic;

namespace exercise_133
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Creates two new objects with different amount of money.
      Money money = new Money(100, 00);
      Money moreMoney = new Money(500, 50);

      // Calls the method to add the two amounts to a total
      // and create a new object with that amount.
      Money combined = money.Plus(moreMoney);

      // Prints the object's values.
      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(combined);
      
      // Subtracts one object's value from another object's value
      // and creates a new objects with that amount.
      Money lessMoney = moreMoney.Minus(money);

      // Prints the new amounts of the objects.
      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(lessMoney);

      // Again, a new object is created.
      lessMoney = lessMoney.Minus(money);

      // Prints again.
      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(lessMoney);

      // Calls a method to check which of the objects has less value.
      Console.WriteLine(lessMoney.LessThan(moreMoney));
      Console.WriteLine(lessMoney.LessThan(money));

      // Checks the subtraction method again to see if it goes below 0,
      // which it shouldn't.
      lessMoney = lessMoney.Minus(moreMoney);
      Console.WriteLine(lessMoney);
    }
  }
}
