using System;
using System.Collections.Generic;

namespace Card_Deck
{
    public class Card 
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card()
        {
            
        }
        
        public Card(string suit, string stringVal,int val)
        {
            stringVal = stringVal;
            suit = suit;
            val = val;
        }

    }
}