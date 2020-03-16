
namespace extra_12
{
    public class Person
    {
        private int age;
        private string name;
        public Person(string name)
        {
            this.age = 0;
            this.name = name;
        }

        public int GrowOlder(int howMuch)
        {
           return this.age += howMuch;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age;
        }
    }
}