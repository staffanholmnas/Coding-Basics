using System;

namespace exercise_104
{

    public class Multiplier
    {
        public int number {get; set;} // Instance variables.

        public Multiplier(int number) // Constructor.
        {
            this.number = number;
        }
        public int Multiply(int number) // Method that multplies the value number passed to it with the number provided by the constructor.
        {
            this.number = number * this.number;
            return this.number;
        }

    }
}