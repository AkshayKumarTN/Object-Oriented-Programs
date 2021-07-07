using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Player
    {
        string name;
        public List<Card> hand;

        public Player(string person)
        {
            name = person;
            hand = new List<Card>();
        }

        public Card draw(Box box)
        {
            Card noob = box.deal();
            hand.Add(noob);
            return noob;
        }
    }
}
