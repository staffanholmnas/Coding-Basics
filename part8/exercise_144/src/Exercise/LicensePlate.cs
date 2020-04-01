using System;

namespace Exercise
{
    public class LicensePlate
    {
        public string liNumber { get; }
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }


        public override string ToString()
        {
            return country + " " + liNumber;
        }

        public override bool Equals(object compared)
        {
            if (this == compared) //Compares the locations of the objects. If they are the same, they are equal.
            {
                return true;
            }

            // If the compared object is null, or not of the correct type, then they are not equal.
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            // Converts the object to an object specific to this class.
            LicensePlate comparedPlate = (LicensePlate)compared;

            // If the values of the object variables are the same, the objects are equal.
            return this.liNumber == comparedPlate.liNumber && this.country == comparedPlate.country;
        }

        public override int GetHashCode()
        {
            // Returns a new hash code which is a combination of the objects values.
            // Make it as unique as possible so that as few objects as possible end up with the same hash value.
            return HashCode.Combine(this.liNumber, this.country);
        }
    }
}