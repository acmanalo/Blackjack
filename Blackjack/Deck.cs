using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        static int topCardIndex = 0;
        static Card topCard;
        static Card[] cardArray = new Card[52];

        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                int value = (i + 4) / 4;
                int suit = (i + 4) % 4;
                cardArray[i] = new Card(suit, value);
            }
        }

        public void Shuffle()
        {
            topCardIndex = 0;
            Random random = new Random();
            for (int i = 51; i >= 0; i--)
            {
                Card temp = cardArray[i];
                int j = random.Next(0, i + 1);
                cardArray[i] = cardArray[j];
                cardArray[j] = temp;
            }
        }

        public Card DrawFromDeck()
        {
            topCard = cardArray[topCardIndex++];
            return topCard;
        }
    }
}
