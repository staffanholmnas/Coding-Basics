using System;

namespace extra_17
{
    public class Identification
    {
        private string id;
        private string name;

        public Identification(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            
            // Type casting - object to Identification - so that the values can be compared.
            Identification objectCompared = (Identification)obj;  

            if (this.id == objectCompared.id)
            {
                return true;
            }

        return false;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name);
        }

        public override string ToString()
        {
            return this.id + ": " + this.name;
        }
    }
}