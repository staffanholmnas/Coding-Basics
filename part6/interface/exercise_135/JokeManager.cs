using System;
using System.Collections.Generic;

namespace exercise_135
{
    public class JokeManager
    {
        public List<string> jokes;

        public JokeManager()
        {   
            // When constructor is invoked a new list is created.
            this.jokes = new List<string>();
        }

        public void AddJoke(string joke)
        {
            // Adds the joke passed to the method to the jokes list.
            jokes.Add(joke);
        }

        public string DrawJoke()
        {
            // Randomly draws a joke, if there aren't any it returns a notice instead.
            if (this.jokes.Count == 0)
            {
                return "Jokes are in short supply.";
            }
            else
            {
                Random draw = new Random();
                int index = draw.Next(0, this.jokes.Count);
                return this.jokes[index];
            }
        }

        public void PrintJokes()
        {
            // Prints all the jokes in the list.
            foreach (string joke in jokes)
          {
            Console.WriteLine(joke);
          }
        }
    }
}