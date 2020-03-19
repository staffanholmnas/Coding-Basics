namespace extra_18
{
    public class Bird
    {
        
        public string name;
        public string latinName;
        public int observations;
        public Bird(string name, string latinName)
        {
            this.name = name;
            this.latinName = latinName;
            this.observations = 0;
        }

        public override string ToString()
        {
            return this.name + " (" + this.latinName + "): " + this.observations + " observations";
        }
        public void Observations()
        {
            this.observations++;
        }
    }
}