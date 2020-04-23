namespace Exercise
{
    using System;
    public class Person
    {

        public string name { get; }
        public int age { get; }

        public Person(string name, int age)
        {
           
            if (name == null || name == "" || name.Length > 40)
            {
                throw new ArgumentException("Give a real name.");
            }
            if (age < 0 || age > 120)
            {
                throw new ArgumentException("Give an age between 0 and 120.");
            }
            this.name = name;
            this.age = age;
        }
    }
}