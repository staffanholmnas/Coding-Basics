using System;
using System.Collections.Generic;

namespace extra_18
{
    class Program
    {
        public static void Main(string[] args)
        {
            BirdDatabase db = new BirdDatabase();
            UserInterface ui = new UserInterface(db);
            ui.Start();
        }
    }
}
