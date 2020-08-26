namespace Inheritance_2
{
  public class Persons
  {
    public string name { get; set; }
    public string address { get; set; }

    public Persons(string name, string address)
    {
      this.name = name;
      this.address = address;
    }

    public override string ToString()
    {
      return this.name + ", " + this.address;
    }
  }
}