using System;

namespace Equals
{
    public class Book
    {
        public string name { get; set; }
        public string content { get; set; }
        public int published { get; set; }

        public Book(string name, int published, string content)
        {
            this.name = name;
            this.published = published;
            this.content = content;
        }

        public override string ToString()
        {
            return "Name: " + this.name + " (" + this.published + ")\n"
                + "Content: " + this.content;
        }

        public override bool Equals(object compared)
        {
            // if the variables are located in the same position, they are equal
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type Book, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                // convert the object to a Book object
                Book comparedBook = (Book)compared;

                // if the values of the object variables are equal, the objects are, too
                return this.name == comparedBook.name && this.published == comparedBook.published && this.content == comparedBook.content;
            }
        }
        public override int GetHashCode()
        {
            if (this.name == null)
            {
                return this.published;
            }
            return this.published + this.name.GetHashCode();

            // The next line would also work!
            // return HashCode.Combine(this.name, this.published, this.content);
        }
    }
}