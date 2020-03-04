namespace exercise_136
{
  public class Person
  {
    private string name;
    private int age;

    public Person(string givenName)
    {
      this.name = givenName;
      this.age = 0;
    }

    public bool IsOfAge()
    {
      return (this.age >= 18);
    }

    public int HowManyNames()
    {
      // Do something here
      // Splits the names at each whitespace and returns the amount of parts.
      return this.name.Split().Length;
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return this.name;
    }
  }
}