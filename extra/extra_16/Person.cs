
namespace extra_16
{
    public class Person
    {
        private int age;
        private string name;
        private int height;
        private int weight;

        public Person(string name) : this(name, 0, 0, 0) {}

        public Person(string name, int age) : this(name, age, 0, 0) {}
    
        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public int GrowOlder(int howMuch)
        {
            return this.age += howMuch;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age + ", height " + this.height + "cm, weight " + this.weight + "kg";
        }
    }
}