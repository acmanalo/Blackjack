using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        Deck deck = new Deck();
        
        public void Deal(params Player[] players)
        {
            deck.Shuffle();
            foreach (Player player in players)
            {
                Hit(player);
                Hit(player);
            }
        }

        public void Hit(Player player)
        {
            Card cardDrawn = deck.DrawFromDeck();
            player.hand.Add(cardDrawn);
        }

        public void Restart(params Player[] players)
        {
            foreach (Player player in players)
            {
                player.hand.Clear();
            }

            Deal(players);
        }

        public void Payout(User user)
        {
            user.Bankroll += 2*user.CurrentBet;
            user.CurrentBet = 0;
        }

        public void DealersTurn(Dealer dealer, User user)
        {
            while (dealer.MustHit() || dealer.getHandValue() < user.getHandValue())
                Hit(dealer);
        }
    }
}
