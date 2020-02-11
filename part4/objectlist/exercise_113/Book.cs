using System;

namespace exercise_113
{

    public class Book
    {

        public string name { get; }
        public int pages { get; set; }
        public int year { get; set; }

        public Book(string name, int pages, int year)
        {
            this.name = name;
            this.pages = pages;
            this.year = year;
        }

        public override string ToString()
        {
            return this.name + ", " + this.pages + " pages, " + this.year;
        }
    }
}