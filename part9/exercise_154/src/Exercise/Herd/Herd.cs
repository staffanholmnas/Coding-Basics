namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class Herd : IMovable
    {
        private List<IMovable> list;
        public Herd()
        {
            this.list = new List<IMovable>();
        }

        public void AddToHerd(IMovable movable)
        {
            this.list.Add(movable);
        }

        public void Move(int dx, int dy)
        {
            foreach (IMovable item in list)
            {
                item.Move(dx, dy);
            }
        }

        public override string ToString()
        {
            return ConcatenateStringsToOne();
        }

        public List<string> GetListOfStrings()
        {
            List<string> listOfStrings = new List<string>();

            foreach (IMovable item in this.list)
            {
                listOfStrings.Add((item.ToString()));
                listOfStrings.Add("\n");
            }

            return listOfStrings;
        }

        public string ConcatenateStringsToOne()
        {
            string oneString = String.Join(String.Empty, GetListOfStrings());
            return oneString;
        }
    }
}