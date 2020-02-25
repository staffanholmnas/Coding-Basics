using System;

namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      // When a new object is created, the cents can't be more than 100. In that case
      // the euros are increased instead.
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      // The new clone has the first objects values and added to that are the values of the object that calls.
      newMoney.euros = newMoney.euros + addition.euros;
      newMoney.cents = newMoney.cents + addition.cents;

      // This changes the amount to the correct format if more than 100 cents are added.
      // 140 cents, for instance, is 1.40e.
      if (newMoney.cents > 99)
      {
        newMoney.euros = newMoney.euros + newMoney.cents / 100;
        newMoney.cents = newMoney.cents % 100;
      }
      
      // return the new Money object
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      // Subtracts one objects values from the other.
      newMoney.euros = newMoney.euros - decreaser.euros;
      newMoney.cents = newMoney.cents - decreaser.cents;

      // Cents can't be minus, it decreases the euros instead. Corrects the format.
      if (newMoney.cents < 0)
      {
        newMoney.euros = newMoney.euros - 1;
        newMoney.cents = newMoney.cents + 100;
      }

      // The total cant be negative.
      if (newMoney.euros < 0 || newMoney.cents < 0)
      {
          newMoney.euros = 0;
          newMoney.cents = 0;
      }

      // return the new Money object
      return newMoney;
    }

    
    public bool LessThan(Money compared)
    {
      // Do something here
      // This method compares the objects, which has the greater value.
      if (compared.euros > this.euros) 
      {
          return true;
      }
      if (compared.euros == this.euros && compared.cents > this.cents)
      {
          return true;
      }
      else
      {
          return false;
      }
    }

    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
