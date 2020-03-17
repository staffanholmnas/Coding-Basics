using System;

namespace extra_18
{
    public class Birds
    {
        public string name { get; set; }
        public string latinName { get; set; }
        public Birds(string name, string latinName)
        {
            this.name = name;
            this.latinName = latinName;
        }
        public override string ToString()
        {
            return this.name + " (" + this.latinName + "): ";
        }
    }
}