using System;

namespace extra_18
{
    public class UserInterface
    {
        private BirdDatabase database;

        public UserInterface(BirdDatabase database)
        {
            this.database = database;
        }

        public void Start()
        {
            ReadCommands();

        }

        public void ReadCommands()
        {
            while (true)
            {
                Console.WriteLine("?");
                string input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                if (input == "Add")
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Name in latin:");
                    string latinName = Console.ReadLine();
                    database.Addbirds(name, latinName);
                }
                if (input == "Observation")
                {
                    Console.WriteLine("Bird?");
                    string observation = Console.ReadLine();
                    break;
                }
                if (input == "All")
                {
                    Console.WriteLine(this.database);
                }
            }
        }
    }
}

