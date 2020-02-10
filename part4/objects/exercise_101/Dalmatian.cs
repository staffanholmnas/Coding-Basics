using System;

namespace exercise_101
{
    public class Dalmatian
    {
        public string name { get; set; } // Instance variables with get, and set abilities.
        public int spots { get; set; }


        public Dalmatian(string name, int spots) // Constructor.
        {
            this.name = name;
            this.spots = spots;
        }
    }
}
