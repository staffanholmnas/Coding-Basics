using System;

namespace exercise_135
{
    public class UserInterface
    {
        private JokeManager manager;
        public UserInterface(JokeManager manager)
        {
            this.manager = manager;
        }

        public void Start()
        {
            // This method only starts the program by calling the commands mehtod.
            JokeCommands();
        }
        public void JokeCommands()
        {
            // Here are all the commands that the user can issue.
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

                string command = Console.ReadLine();

                if (command == "X")
                {
                    break;
                }

                if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string joke = Console.ReadLine();
                    manager.AddJoke(joke);
                }
                else if (command == "2")
                {
                    Console.WriteLine("Drawing a joke.");
                    Console.WriteLine(manager.DrawJoke());

                }
                else if (command == "3")
                {
                    Console.WriteLine("Printing the jokes.");
                    manager.PrintJokes();
                }
            }
        }
    }
}