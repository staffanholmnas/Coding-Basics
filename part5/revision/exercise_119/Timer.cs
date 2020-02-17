using System;

namespace exercise_119
{
    public class Timer
    {
        public ClockHand seconds;
        public ClockHand hundredthOfSecond;

        // The construct creates new objects from the ClockHand Class with the limit as parameters.
        public Timer()
        {
            this.seconds = new ClockHand(60); 
            this.hundredthOfSecond = new ClockHand(100);
        }
        
        // Prints the state of the timer object.
        public override string ToString()
        {
            return this.seconds + ":" + this.hundredthOfSecond;

        }

        // This method advances the variables by calling the Advance method from the ClockHands class.
        public void Advance()
        {
            this.hundredthOfSecond.Advance();

            if (this.hundredthOfSecond.value == 0)
            {
                this.seconds.Advance();
            }
        }
    }
}