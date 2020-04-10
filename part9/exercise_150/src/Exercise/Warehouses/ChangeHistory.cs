namespace Exercise
{
    using System.Linq;
    using System.Collections.Generic;
    public class ChangeHistory
    {
        private List<int> history;

        public ChangeHistory()
        {
            this.history = new List<int>();
        }

        public void Add(int status)
        {
            this.history.Add(status);
        }

        public void Clear()
        {
            this.history.Clear();
        }

        public int MaxValue()
        {
            int maxValue = 0;
            if (this.history.Count > 0)
            {
                maxValue = this.history.Max();
            }
            return maxValue;
        }

        public int MinValue()
        {
            int minValue = 0;
            if (this.history.Count > 0)
            {
                minValue = this.history.Min();
            }
            return minValue;
        }

        public override string ToString()
        {
            //  This would also get the last value:
            //  int current = 0;
            //  foreach (var item in this.history)
            //    {
            //      current = item;
            //    } 
            
            return "Current: " + this.history.LastOrDefault() + " Min: " + MinValue() + " Max: " + MaxValue();
        }
    }
}
