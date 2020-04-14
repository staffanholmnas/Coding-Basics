using System.Collections.Generic;

namespace Exercise
{
    public class Box : IPackable
    {
        public List<IPackable> list;
        private int capacity;
        public Box(int capacity)
        {
            this.capacity = capacity;
            this.list = new List<IPackable>();
        }

        public void Add(IPackable item)
        {
            if ((Weight() + item.Weight()) <= this.capacity)
            {
                list.Add(item);
            }
        }

        public int Weight()
        {
          int sumOfWeight = 0;
            foreach (IPackable item in list)
            {
                sumOfWeight = sumOfWeight + item.Weight();
            }

            return sumOfWeight;
        }

        public override string ToString()
        {
            return list.Count + " items, total weight " + Weight() + " kg";
        }
    }
}