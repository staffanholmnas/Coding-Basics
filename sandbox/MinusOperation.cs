using System;

namespace Abstract_Class
{
    public class MinusOperation : Operation
    {
        public MinusOperation() : base("MinusOperation")
        {
        }

        public override void Execute()
        {
            Console.Write("First number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The difference of the numbers is " + (first - second));
        }
    }
}