using System;

namespace exercise_129
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherJack = new Song("The Lonely Island", "Jack Scarecrow", 296);

            if (jackSparrow.Equals(anotherSparrow))
            {
                Console.WriteLine("Songs are equal.");
            }
            else
            {
                Console.WriteLine("Songs are not equal.");
            }
            if (!jackSparrow.Equals(anotherJack))
            {
                Console.WriteLine("Strange things are afoot.");
            }
        }
    }
}
