using System;
using System.Collections.Generic;

namespace Card_Deck 
{
    public class Dealer : Player
    {
        public Dealer(string name = "dealer") : base(name)
        {

        }

        public bool hitStay()
        {
            if(handtotal <= 16)
            {
                return true;    
            }
            else
            {
                return false;
            }

        }

        public void aceVal()
        {
            Dictionary<Card, int> aces = new Dictionary<Card, int>();
            foreach(Card card in hand)
            {
                if(card.stringVal == "Ace")
                {
                    aces.Add(card, 11);
                }
            }

            while((handtotal + 10) > 21)
            {

            }
        }
    }
}