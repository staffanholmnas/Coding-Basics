namespace Exercise
{
    using System.Collections.Generic;
    public abstract class Box
    {
        public abstract void Add(Item item);

        public abstract bool IsInBox(Item item);
    }
}