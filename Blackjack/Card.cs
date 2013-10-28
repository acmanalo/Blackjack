using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(int suit, int value)
        {
            this.Suit = (Suits)suit;
            this.Value = (Values)value;
        }

        public override string ToString()
        {
            string name = Value + " of " + Suit;
            return name;
        }
    }
}
