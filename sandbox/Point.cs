using System;

namespace Inheritance_3
{
    public class Point
    {

        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int ManhattanDistanceFromOrigin()
        {
            return Math.Abs(this.x) + Math.Abs(this.y);
        }

        protected string Location()
        {
            return this.x + ", " + this.y;
        }

        public override string ToString()
        {
            return "(" + this.Location() + ") distance " + this.ManhattanDistanceFromOrigin();
        }
    }
}

