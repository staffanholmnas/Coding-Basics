using System;

namespace Inheritance_3
{
  
  public class Point3D : Point
  {

    private int z;

    public Point3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
    }
    new protected string Location()
    {
      return base.Location() + ", " + z;    // the resulting string has the form "x, y, z"
    }
    new public int ManhattanDistanceFromOrigin()
    {
      // first ask the base for the distance based on x and y
      // and add the effect of the z coordinate to that result
      return base.ManhattanDistanceFromOrigin() + Math.Abs(this.z);
    }

    public override string ToString()
    {
      return "(" + this.Location() + ") distance " + this.ManhattanDistanceFromOrigin();
    }
  }
}