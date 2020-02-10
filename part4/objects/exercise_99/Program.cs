using System;

namespace exercise_99
{
    class Program
    {
        public static void Main(string[] args)
        {

            DecreasingCounter counter = new DecreasingCounter(20); // Creates a new object that has a value.
            counter.PrintValue(); // Prints the value.
            counter.Decrement(); // Decreases the value by 1.

            counter.PrintValue();
            counter.Decrement();
            counter.Decrement();
            counter.PrintValue();
            counter.Reset(); // Resets the value to 0.

            counter.PrintValue();
            counter.Decrement();

        }
    }
}



