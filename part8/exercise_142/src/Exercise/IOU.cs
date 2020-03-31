using System.Collections.Generic;

namespace Exercise
{
    public class IOU
    {
        private Dictionary<string, int> dictionary;
        public IOU()
        {
            this.dictionary = new Dictionary<string, int>();
        }
        public void ChangeDebt(string toWhom, int amount)
        {
            if (this.dictionary.ContainsKey(toWhom))
            {
                // If the person is already on the debt list, add the old debt to the new debt. 
                // Then remove the key/value element from the dictionary and add a new key/value pair. 
                // The debt can't be negative in any case.
                int newAmount = this.dictionary[toWhom] + amount;
                this.dictionary.Remove(toWhom);
                if (newAmount >= 0)
                {
                    this.dictionary.Add(toWhom, newAmount);
                }
                else
                {
                    this.dictionary.Add(toWhom, 0);
                }
            }
            else if (amount >= 0)
            {
                this.dictionary.Add(toWhom, amount);
            }
            else
            {
                this.dictionary.Add(toWhom, 0);
            }
        }
        public int HowMuchDoIOweTo(string toWhom)
        {
            if (this.dictionary.ContainsKey(toWhom))
            {
                return this.dictionary[toWhom];
            }
            else
            {
                return 0; // If the person doesn't exist, return zero instead.
            }
        }
    }
}
