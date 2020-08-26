namespace IComparable
{
  // IComparable is in System
  using System;
  // Implement IComparable<Member>
  // Explicit comparison to Member, not other objects
  public class Member : IComparable<Member>
  {
    public string name { get; }
    public int height { get; }

    // Basic constructor
    public Member(string name, int height)
    {
      this.name = name;
      this.height = height;
    }

    // CompareTo Member
    // For this we implement IComparable<Member>
    // With just IComparable, we would compare objects
    // With CompareTo(object obj)
    public int CompareTo(Member member) // This method must be used when implementing Icomparable.
    {
        return this.height - member.height;
    }

    // Basic ToString
    public override string ToString()
    {
      return this.name + " (" + this.height + ")";
    }
  }
}