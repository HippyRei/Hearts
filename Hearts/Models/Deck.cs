namespace Hearts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using Hearts.Constants;

    class Deck
    {
        private IList<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            foreach (CardValues.Suit suit in Enum.GetValues(typeof(CardValues.Suit))) {
                foreach (CardValues.Value value in Enum.GetValues(typeof(CardValues.Value)))
                {
                    cards.Add(new Card(suit, value));
                }
            }

            this.Shuffle();
        }

        public Card Draw()
        {
            var result = cards.First();
            cards.RemoveAt(0);
            return result;
        }

        public void Shuffle()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = cards.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                var value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}
