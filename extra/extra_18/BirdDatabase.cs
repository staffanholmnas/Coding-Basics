using System;
using System.Collections.Generic;

namespace extra_18
{
    public class BirdDatabase
    {
        public List<Bird> birdList;
        public BirdDatabase()
        {
            this.birdList = new List<Bird>();
        }
        public void ObservationCheck(string birdName)
        {
            int nameFound = 0;
            foreach (Bird item in birdList)
            {
                if (birdName == item.name)
                {
                    item.Observations();
                    nameFound = 1;
                }
            }
            if (nameFound == 0)
            {
                Console.WriteLine("Not a bird!");
            }
        }
    }
}