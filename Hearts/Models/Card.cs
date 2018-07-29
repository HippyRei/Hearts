namespace Hearts.Models
{
    using System;
    using Hearts.Constants;

    class Card : IComparable
    {
        public CardValues.Suit Suit { get; }

        public CardValues.Value Value { get; }

        public Card(CardValues.Suit suit, CardValues.Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        override
        public string ToString()
        {
            return $"{Enum.GetName(typeof(CardValues.Value), Value)} of {Enum.GetName(typeof(CardValues.Suit), Suit)}";
        }

        public string ToShortHand()
        {
            string suit;
            string value;

            switch (Suit)
            {
                case CardValues.Suit.Clubs:
                    suit = "C";
                    break;
                case CardValues.Suit.Diamonds:
                    suit = "D";
                    break;
                case CardValues.Suit.Hearts:
                    suit = "H";
                    break;
                case CardValues.Suit.Spades:
                    suit = "S";
                    break;
                default:
                    suit = "";
                    break;
            }

            switch (Value)
            {
                case CardValues.Value.Two:
                    value = "2";
                    break;
                case CardValues.Value.Three:
                    value = "3";
                    break;
                case CardValues.Value.Four:
                    value = "4";
                    break;
                case CardValues.Value.Five:
                    value = "5";
                    break;
                case CardValues.Value.Six:
                    value = "6";
                    break;
                case CardValues.Value.Seven:
                    value = "7";
                    break;
                case CardValues.Value.Eight:
                    value = "8";
                    break;
                case CardValues.Value.Nine:
                    value = "9";
                    break;
                case CardValues.Value.Ten:
                    value = "10";
                    break;
                case CardValues.Value.Jack:
                    value = "J";
                    break;
                case CardValues.Value.Queen:
                    value = "Q";
                    break;
                case CardValues.Value.King:
                    value = "K";
                    break;
                case CardValues.Value.Ace:
                    value = "A";
                    break;
                default:
                    value = "";
                    break;
            }

            return $"{value}{suit}";
        }

        public int CompareTo(object obj)
        {
            var card = (Card)obj;
            return this.Value - card.Value;
        }
    }
}
