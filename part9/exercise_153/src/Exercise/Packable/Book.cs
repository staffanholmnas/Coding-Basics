namespace Exercise
{
    public class Book : IPackable
    {
        private string author;
        private string name;
        private int publication;
        private int weight;
        public Book(string author, string name, int publication)
        {
            this.author = author;
            this.name = name;
            this.publication = publication;
            this.weight = 1;
        }

        public int Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.author + ": " + this.name + " (" + this.publication + ")";
        }
    }
}