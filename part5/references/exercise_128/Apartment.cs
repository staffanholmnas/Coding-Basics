namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
      // Compares the size of the apartments.
      if (this.squares > compared.squares) 
      {
          return true;
      }
      else
      {
          return false;
      }
    }

    private int Price()
    {
      // Calculates the price.
      int price = this.squares * this.pricePerSquare; 
      return price;
    }

    public int PriceDifference(Apartment compared)
    {
      // Calculates the pricedifference using the price method.
      int pricedifference = this.Price() - compared.Price(); 
      // Math.Abs returns the absolute value
      return Math.Abs(pricedifference);
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      if (this.Price() > compared.Price()) // Compares the price of the apartments.
      {
          return true;
      }
      else
      {
          return false;
      }
    }
  }
}
