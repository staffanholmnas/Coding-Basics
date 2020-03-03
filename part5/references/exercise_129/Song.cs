using System;

namespace exercise_129
{

    public class Song 
    {

        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }

        // BEGIN SOLUTION
        public override bool Equals(object compared)
        {
            if (this == compared) //Compares the locations of the objects.
            {
                return true;
            }

            // If the compared object is null, or
            // if the type of the compared object is not Song, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            // Converts the Object type compared object
            // into an Song type object called comparedSong so that the values can be compared. 

            Song comparedSong = (Song)compared;
            
            // if the values of the object variables are the same, the objects are equal
            if (this.artist == comparedSong.artist &&
                this.name == comparedSong.name &&
                this.durationInSeconds == comparedSong.durationInSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(artist, name, durationInSeconds);
        }
        // END SOLUTION
    }
}