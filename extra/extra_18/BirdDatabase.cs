using System.Collections.Generic;
using System;

namespace extra_18
{
    public class BirdDatabase
    {
        private int observations;
        public Birds bird;


        public BirdDatabase()
        {
            this.observations = 2;
        }

        public void Observations()
        {
            this.observations++;
        }
        public Birds Addbirds(string name, string latinName)
        {
            Birds bird = new Birds(name, latinName);
            
            return bird;
        }
        public override string ToString()
        {
            return "this " + this.observations;
        }
    }
}