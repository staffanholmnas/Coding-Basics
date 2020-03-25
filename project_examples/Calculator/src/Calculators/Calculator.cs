using System;

namespace Calculators
{
    public class Calculator
    {

        public double value { get; private set; }

        public Calculator()
        {
            this.value = 0;
        }

        public void Sum(int number)
        {
            this.value = this.value + number;
        }

        public void Substract(int number)
        {
            this.value -= number;
        }

        public void Multiply(int number)
        {
            this.value = this.value * number;
        }

        public void Divide(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                this.value = this.value / number;
            }
        }

        public void AddTwoToThePowerOf(int number)
        {
            this.value = this.value + Math.Pow(2, number);
        }
    }
}
