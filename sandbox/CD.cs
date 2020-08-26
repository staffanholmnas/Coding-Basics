namespace Interfaces_2
{
    public class CD : IStorable
    {
        public string artist;
        public string name;
        public double weight;
        public int year;
        public CD(string artist, string name, int year)
        {
            this.artist = artist;
            this.name = name;
            this.weight = 0.1;
            this.year = year;
        }

        public double Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.artist + " - " + this.name + " (" + this.year + ")";
        }
    }
}