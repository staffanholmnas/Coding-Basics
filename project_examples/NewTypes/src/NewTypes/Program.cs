using System;
using Pets;
using WildAnimals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog doggie = new Dog();
            Cat cattie = new Cat();
            Bird birdie = new Bird();
            Squirrel squirt = new Squirrel();
            Rabbit roger = new Rabbit();
            Console.WriteLine(doggie.TalkToOwner());
            Console.WriteLine(cattie.TalkToOwner());
            Console.WriteLine(birdie.TalkToOwner());
            Console.WriteLine(squirt.WhatDoIEat());
            Console.WriteLine(roger.WhatDoIEat());
        }
    }
}