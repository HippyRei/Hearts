namespace Hearts.Constants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CardValues
    {
        /// <summary>
        /// Represents a playing card suit
        /// </summary>
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        /// <summary>
        /// Represents a playing card value
        /// </summary>
        public enum Value
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
    }
}
