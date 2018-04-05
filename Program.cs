using System;

namespace Card_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player1 = new Player();
            deck.shuffle();
            player1.draw(deck);
            player1.draw(deck);
            player1.draw(deck);
            player1.draw(deck);
            player1.draw(deck);
            deck.reset();
            Console.WriteLine(player1.hand);

        }
    }
}
