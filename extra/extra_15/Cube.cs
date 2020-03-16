using System;

namespace extra_15
{
    public class Cube
    {
        private int edgeLength;
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }
        public int Volume()
        {
            int volume = this.edgeLength * this.edgeLength * this.edgeLength;

            return volume;
        }
        public override string ToString()
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + Volume();
        }
    }
}