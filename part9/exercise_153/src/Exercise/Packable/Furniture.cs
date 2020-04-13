namespace Exercise
{
    public class Furniture : IPackable
    {
        private string furniture;
        private string color;
        private int weight;
        public Furniture(string furniture, string color, int weight)
        {
            this.furniture = furniture;
            this.color = color;
            this.weight = weight;
        }

        public int Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.color + " " + this.furniture + " - weight " + this.weight + " kg";
        }
    }
}