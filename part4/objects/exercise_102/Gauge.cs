using System;

namespace exercise_102
{
    public class Gauge
    {
        public int value { get; set; } // Instance variable.

        public Gauge() // Constructor.
        {

        }
        public void Increase() // Method that increases by 1.
        {
            if (this.value < 5)
            {
                this.value++;
            }
        }
        public void Decrease() // Method that decreases by 1 but can't be negative.
        {
            if (this.value > 0)
            {
                this.value--;
            }
        }
        public bool Full() // Method that returns true if the value is exactly 5.
        {
            if (this.value == 5)
            {
                return true;                
            }
            else
            {
                return false;
            }

        }
    }
}
