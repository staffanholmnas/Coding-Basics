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
            this.observations = 0;
            this.name = name;
            this.latinName = latinName;
        }
        public BirdDatabase()
        {
            this.observations = 0;
        }


        public void Observations()
        {
            this.observations++;
        }
        public bool ObservationCheck(string birdName)
        {
            if (birdName == this.name)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }
        public BirdDatabase Addbirds(string birdName, string latinName)
        {  
            return new BirdDatabase(birdName, latinName); 
        }
        public override string ToString()
        {
            return this.name + " (" + this.latinName + "): " + this.observations + " observations";
        }
    }
}