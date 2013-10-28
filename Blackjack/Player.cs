using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        public List<Card> hand = new List<Card>();
        public bool handIsSoft;

        public int getHandValue()
        {
            int handValue = 0;
            bool hasAce = false;
            foreach (Card card in hand)
            {
                if (card.Value == Values.Ace) { hasAce = true; }

                if (card.Value < Values.Jack) { handValue += (int)card.Value; }
                else { handValue += 10; }
            }

            if (hasAce == true && handValue < 12)
            {
                handValue += 10;
                handIsSoft = true;
            }
            else
                handIsSoft = false;

            return handValue;
        }

        public virtual string[] getHandString()
        {
            string[] handStringArray = new string[hand.Count];
            int i = 0;
            foreach (Card card in hand)
            {
                handStringArray[i++] = card.ToString();
            }

            return handStringArray;
        }


        public bool IsBust()
        {
            if (getHandValue() > 21)
                return true;
            return false;
        }

        public bool HasBlackJack()
        {
            if (getHandValue() == 21)
                return true;
            return false;
        }
    }
}
