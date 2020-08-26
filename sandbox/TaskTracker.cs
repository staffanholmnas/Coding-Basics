using System;
using System.Collections.Generic;

namespace ListInDictionary
{
    public class TaskTracker
    {
        private Dictionary<string, List<int>> completedExercises;

        public TaskTracker()
        {
            this.completedExercises = new Dictionary<string, List<int>>();
        }

        public void Add(string user, int exercise)
        {
            // an empty list has to be added for a new user if one has not already been added
            if (!this.completedExercises.ContainsKey(user))
            {
                this.completedExercises.Add(user, new List<int>());
            }

            // let's first retrieve the list containing the exercises completed by the user and add to it
            
            //List<int> completed = this.completedExercises[user];
            //completed.Add(exercise);

            // the previous would also work
            this.completedExercises[user].Add(exercise);
        }

        public void Print()
        {
            Dictionary<string, List<int>>.KeyCollection keys = this.completedExercises.Keys;

            foreach (string name in keys)
            {
                foreach (int completed in this.completedExercises[name])
                {
                    Console.WriteLine(name + ": " + completed);
                }
            }
        }
    }
}