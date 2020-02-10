using System;

namespace exercise_107
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros"; // Returns a string value when the print method is called.
        }

        public void EatLunch()
        {
            this.balance = this.balance - 10.60; // Subtracts 10.60 from the objects value.
        }

        public void DrinkCoffee()
        {
            this.balance = this.balance - 2.0; // Subtracts 2.0 from the objects value.
        }
    }
}