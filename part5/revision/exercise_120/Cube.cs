using System;

namespace exercise_120
{

    public class Cube
    {
        public int edgeLength { get; set; }


        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        // The cubes volume is calculated and returned.
        public int Volume()
        {
            int volume = this.edgeLength * this.edgeLength * this.edgeLength;
            return volume;
        }

        // Prints the length and the volume of the cube.
        public override string ToString()
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + this.Volume();
        }

    }
}