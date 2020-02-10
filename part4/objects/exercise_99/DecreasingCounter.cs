using System;

namespace exercise_99
{
    public class DecreasingCounter
    {
        private int value;   // a variable that remembers the value of the counter

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            // write the method implementation here
            // the aim is to decrement the value of the counter by one

            if (value > 0) // If the value is greater than 0 it decreases by 1. Can't be negative.
            {
                value--;
            }


        }

        public void Reset() // Resets the value to 0.
        {
            // write the method implementation here∑

            value = 0;

        }
    }
}

