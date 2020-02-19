namespace exercise_130
{


    public class Book
    {

        public string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }


        // BEGIN SOLUTION
        public override bool Equals(object compared)
        {
            // Converts the Object type compared object
            // into a Book type object called comparedBook so that the values can be compared.
            Book comparedBook = (Book)compared; 

            // if the values of the object variables are the same, the objects are equal
            if (this.name == comparedBook.name &&
                this.publicationYear == comparedBook.publicationYear)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
        // END SOLUTION
    }
}