using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Box
    {
        public List<Card> cards;

        public Box()
        {
            reset();
            shuffle();
        }
        public Box reset()
        {
            cards = new List<Card>();
            string[] symbol = { "hearts", "diamonds", "spades", "clubs" };
            string[] strVals = { "Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King" };
           
            foreach (string suit in symbol)
            {
                
                for (int i = 0; i < strVals.Length; i++)
                {
                    Card noob = new Card(strVals[i], suit, i + 1);
                    cards.Add(noob);
                }
            }
            return this;
        }
        public Box shuffle()
        {
           
            Random rand = new Random();
            for (int end = cards.Count - 1; end > 0; end--)
            {
               
                int randx = rand.Next(end);
                Card temp = cards[randx];
                
                cards[randx] = cards[end];
                cards[end] = temp;
            }
            return this;
        }

        public Card deal()
        {
            if (cards.Count > 0)
            {

                //grab top card
                Card res = cards[0];
                //remove said card
                cards.RemoveAt(0);
                //return said card.
                return res;
            }
            else
            {
                reset();
                return deal();
            }
        }

    }
}
