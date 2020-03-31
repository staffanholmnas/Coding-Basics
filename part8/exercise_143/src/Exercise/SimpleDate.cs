using System;

namespace Exercise
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    public bool Earlier(SimpleDate compared)
    {
      if (this.year < compared.year)
      {
        return true;
      }
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }
      return false;
    }

    public override bool Equals(object compared)
    {
      // DO SOMETHING HERE
      if (this == compared) //Compares the locations of the objects. If they are the same, they are equal.
            {
                return true;
            }

            // If the compared object is null, or not of the correct type, then they are not equal.
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            // Converts the object to an object specific to this class.
            SimpleDate comparedDate = (SimpleDate)compared;
            
            // If the values of the object variables are the same, the objects are equal
            return this.day == comparedDate.day &&
                this.month == comparedDate.month &&
                this.year == comparedDate.year;
    }
    public override int GetHashCode()
    {
      // DO SOMETHING HERE
      // Returns a new hash code which is a combination of the objects values.
      // Make it as unique as possible so that as few objects as possible end up with the same hash value.
      return HashCode.Combine(this.day, this.month, this.year);
    }
  }
}