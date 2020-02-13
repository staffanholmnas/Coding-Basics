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

        // Method that multplies the value number passed to it with the number provided by the constructor.
        public int Multiply(int number) 
        {
            this.number = number * this.number; // The product becomes the new instance variable.
            return this.number;
        }

    }
}