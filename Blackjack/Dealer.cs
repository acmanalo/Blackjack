using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Dealer : Player
    {
        public bool IsSoftSeventeen()
        {
            if (getHandValue() == 17 && handIsSoft)
                return true;
            return false;
        }

        public bool MustHit()
        {
            if (getHandValue() < 17 || IsSoftSeventeen())
                return true;
            return false;
        }
    }
}
