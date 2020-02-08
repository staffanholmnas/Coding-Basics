using System;

namespace sandbox
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string initialName)
        {
            this.age = 0;
            this.name = initialName;
        }

        public void PrintPerson()
        {
            Console.WriteLine(this.name + ", age " + this.age + " years");
        }
        public void GrowOlder()
        {
            if (this.age < 100)
            {
                this.age++;
            }

        }
    }
}