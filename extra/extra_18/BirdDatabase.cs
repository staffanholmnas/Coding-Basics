using System;
using System.Collections.Generic;

namespace extra_18
{
    public class BirdDatabase
    {
        public Birds name;
        public int observations;
        public BirdDatabase()
        {
            this.observations = 0;
        }

        public void Observation()
        {
            this.observations++;
        }
        public void PrintAll()
        {

        }
        public void PrintOne()
        {

        }
    }
}