using System;

namespace Abstract_Class
{
    public class PlusOperation : Operation
    {
        public PlusOperation() : base("PlusOperation")
        {
        }

        public override void Execute()
        {
            Console.Write("First number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is " + (first + second));
        }
    }
}