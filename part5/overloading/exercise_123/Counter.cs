using System;

namespace exercise_123
{
    public class Counter
    {

        public int value { get; set; }

        public Counter() : this(0) { } // Constructor overloading, sets the initial value to 0.

        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public void Increase()
        {
            this.Increase(1); // Method overloading, calls the increase method to increase by 1.
        }

        public void Decrease() // Method overloading, calls the decrease method to decrease by 1.
        {
            this.Decrease(1);
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                this.value += increaseBy; 
            }
        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value -= decreaseBy;
            }
        }
    }
}