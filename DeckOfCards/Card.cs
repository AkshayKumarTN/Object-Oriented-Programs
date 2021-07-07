using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {
        public string cardValue;
        public string symbol;
        public int value;

        public Card(string name, string symbol, int value)
        {
            this.cardValue = name;
            this.symbol = symbol;
            this.value = value;
        }
    }
}
