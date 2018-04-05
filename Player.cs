using System;
using System.Collections.Generic;


namespace Card_Deck
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();

        public Player(string name = "buddy")
        {
            this.name = name;
        }

        public Card draw(Deck deck)
        {
            Card drawn = deck.deal();
            hand.Add(drawn);
            return drawn;
        }

        public Card discard(int index)
        {
            if(index >= hand.Count)
            {
                return null;
            } else {
                Card temp = hand[index];
                hand.RemoveAt(index);
                return temp;
            }
            

        }
    }
}