using System;

namespace Enumerators
{
    public class Card : IComparable<Card>
    {
        public int value { get; }
        public Suit suit { get; }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return suit + " " + value;
        }

        public int CompareTo(Card another)
        {
            return this.value - another.value;
        }
    }
}