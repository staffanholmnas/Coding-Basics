using System;

namespace exercise_100
{
    public class Debt
    {
        private double balance;
        private double interestRate;    


        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance() // Method that prints the balance.
        {
            Console.WriteLine(this.balance);
        }

        public void WaitOneYear() // Method that increases the balance by multiplying with interest.
        {
            this.balance = this.balance * this.interestRate;
        }
    }
}
