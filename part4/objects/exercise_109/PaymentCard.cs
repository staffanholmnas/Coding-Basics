using System;

namespace exercise_109
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
            if (this.balance - 10.60 > 0) // Checks if there is enough money before subtracting.
            {
                this.balance = this.balance - 10.60; // Subtracts 10.60 from the objects value.
            }

        }
        public void DrinkCoffee()
        {
            if (this.balance - 2.0 > 0) // Checks if there is enough money before subtracting.
            {
                this.balance = this.balance - 2.0; // Subtracts 2.0 from the objects value.
            }
        }
        public void AddMoney(double amount) // Method that adds to the balance the value passed to it.
        {
            // write code here
            if (amount > 0) // Cannot add negative value.
            {
                this.balance += amount; // Adds the amount passed to the method to the balance.

                if (amount > 150) // The amount cannot exceed 150.
                {
                    this.balance = 150;
                }
            }
        }
    }
}