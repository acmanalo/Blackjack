using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class User : Player
    {
        public int Bankroll { get; set; }
        public int CurrentBet { get; set; }

        public User()
        {
            Bankroll = 500;
            CurrentBet = 0;
        }
    }
}
