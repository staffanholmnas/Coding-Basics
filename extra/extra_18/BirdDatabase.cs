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
            bool nameFound = false;
            foreach (Bird item in birdList)
            {
                if (birdName == item.name)
                {
                    item.Observations();
                    nameFound = true;
                }
            }
            if (nameFound == false)
            {
                Console.WriteLine("Not a bird!");
            }
        }
    }
}