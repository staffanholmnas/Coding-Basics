using System;

namespace exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString() // Returns a string value when the print method is called.
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}