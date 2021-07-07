using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Deck Of Cards");
            Box box = new Box();
           
            Console.WriteLine(" No. of Cards : "+box.cards.Count);

            Player john = new Player("JOHN");
            Player mark = new Player("Mark");
            Player ak = new Player("AK");
            Player rock = new Player("ROCK");
            for (int i = 1; i < 10; i++)
            {
                john.draw(box);
                mark.draw(box);
                ak.draw(box);
                rock.draw(box);
            }
            Console.WriteLine("\n------------------- Rock's Number of Cards : " + rock.hand.Count+" ----------------------");
            ShowCards(rock);
            Console.WriteLine("\n------------------- AK's Number of Cards : " + ak.hand.Count+" ----------------------");
            ShowCards(ak);
            Console.WriteLine("\n------------------- Mark's Number of Cards : " + mark.hand.Count+" ----------------------");
            ShowCards(mark);
            Console.WriteLine("\n------------------- john's Number of Cards : " + john.hand.Count+" ----------------------");
            ShowCards(john);

        }
        public static void ShowCards(Player player)
        {
            foreach (Card list in player.hand)
            {
                Console.WriteLine("\nCard : " + list.cardValue);
                Console.WriteLine("Symbol : " + list.symbol);
                Console.WriteLine("Card : " + list.value);
            }
        }
    }
}
