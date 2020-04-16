namespace Exercise
{
    using System;
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
            if (this.value == 11)
            {
                return this.suit + " " + "J";
            }
            if (this.value == 12)
            {
                return this.suit + " " + "Q";
            }
            if (this.value == 13)
            {
                return this.suit + " " + "K";
            }
            if (this.value == 14)
            {
                return this.suit + " " + "A";
            }
            return this.suit + " " + this.value;
        }

        public int CompareTo(Card another)
        {
            if (this.value == another.value)
            {
                return this.suit.CompareTo(another.suit);
            }
            return this.value - another.value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Card objectCompared = (Card)obj;

            if (this.suit == objectCompared.suit && this.value == objectCompared.value)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            
            return HashCode.Combine(this.suit, this.value);
        }
    }
}