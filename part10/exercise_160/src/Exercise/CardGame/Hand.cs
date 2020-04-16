namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class Hand : IComparable<Hand>
    {
        private List<Card> hand;

        public Hand()
        {
            this.hand = new List<Card>();
        }

        public void Add(Card card)
        {
            if (!this.hand.Contains(card))
            {
                this.hand.Add(card);
            }
        }

        public void Print()
        {
            foreach (Card item in this.hand)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Sort()
        {
            this.hand.Sort();
        }


        public int CompareTo(Hand hand)
        {
            int sumOfHand = 0;
            foreach (Card item in this.hand)
            {
                sumOfHand = sumOfHand + item.value;
            }

            int sumOfHandCompared = 0;
            foreach (Card item in hand.hand)
            {
                sumOfHandCompared = sumOfHandCompared + item.value;
            }

            return sumOfHand - sumOfHandCompared;
        }
    }
}