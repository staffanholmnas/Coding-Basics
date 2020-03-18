using System.Collections.Generic;
using System;

namespace extra_18
{
    public class BirdDatabase
    {
        private int observations;
        private string name;
        private string latinName;


        public BirdDatabase(string name, string latinName)
        {
            this.observations = 2;
            this.name = name;
            this.latinName = latinName;
        }
        public BirdDatabase()
        {
            this.observations = 2;
        }


        public void Observations()
        {
            this.observations++;
        }
        public BirdDatabase Addbirds(string name, string latinName)
        {
            BirdDatabase bird = new BirdDatabase(name, latinName);

            return bird;
            
        }
        public override string ToString()
        {
            return "this " + this.observations + " " + this.name + " " + this.latinName;
        }
    }
}