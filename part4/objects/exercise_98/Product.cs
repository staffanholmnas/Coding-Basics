using System;

namespace exercise_98
{
    public class Product
    {
        private int quantity;
        private double price;
        private string name;

        public Product(string name, double price, int quantity) // Construct with 3 parameters.
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void PrintProduct() // Method for printing.
        {
            Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantity + " pcs");

        }


    }

}
