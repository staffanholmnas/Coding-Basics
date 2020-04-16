namespace Exercise
{
  using System;
  public class Book : IComparable<Book>
  {

    public string name { get; set; }
    public int age { get; set; }

    public Book(string name, int age)
    {
      // Fill in the blanks
      this.name = name;
      this.age = age;
    }


    public override string ToString()
    {
      // Don't touch this
      return this.name + " (recommended for " + this.age + " year-olds or older)";
    }


    public int CompareTo(Book other)
    {

      // Do some magic here
      if (this.age == other.age)
      {
          return this.name.CompareTo(other.name);
      }
      return this.age - other.age;
    }

  }
}