using System;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person adaL = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
            Person eskoU = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
            Console.WriteLine(adaL);
            Console.WriteLine(eskoU);
            Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            Console.WriteLine(ollie);
            ollie.Study();
            Console.WriteLine(ollie);
            Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
            Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
            Console.WriteLine(ada);
            Console.WriteLine(esko);
        }
    }
}
