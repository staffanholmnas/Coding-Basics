using System;

namespace extra_18
{
    public class UserInterface
    {
        public BirdDatabase database;

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
                    Console.WriteLine("Name in Latin:");
                    string latinName = Console.ReadLine();

                    Bird bird = new Bird(name, latinName);

                    database.birdList.Add(bird);
                }
                if(input == "Observation")
                {
                    Console.WriteLine("Bird?");
                    string birdName = Console.ReadLine();
                    this.database.ObservationCheck(birdName);
                }
                if (input == "All")
                {
                    for (int i = database.birdList.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(database.birdList[i]);
                    }
                }
                if (input == "One")
                {
                    Console.WriteLine("Which bird?");
                    string name = Console.ReadLine();

                    foreach (Bird item in database.birdList)
                    {
                        if (name == item.name)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}

