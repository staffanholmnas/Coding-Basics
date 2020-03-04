namespace exercise_135
{
    class Program
    {
        public static void Main(string[] args)
        {   
            // Creates a new object from the joke manager class.
            // A new UI of JokeManager type is created then we call the method that starts the program.
            JokeManager manager = new JokeManager();
            UserInterface ui = new UserInterface(manager);
            ui.Start();
        }
    }
}