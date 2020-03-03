using System;

namespace exercise_131
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {

            //compare with Item.identifier
            
            // Converts the Object type into Item type so that the values can be compared.
            Item comparedItem = (Item)compared;

            // if the values of the object variables are the same, the objects are equal
            if (this.identifier == comparedItem.identifier)
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
            return HashCode.Combine(identifier, name);
        }
    }
}
