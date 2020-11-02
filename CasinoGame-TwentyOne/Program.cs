using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame_TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card card = new Card() { Face = "King", Suit = "Spades" };--object initializatio
            ////polymorphism-the ability of a class to morpho into its inheriting class to gain certain advantages
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //game.Add(game);

            ////  PokerGame
            ////   SolitaireGame
            //Game game = new TwentyOneGame();
            // TwentyOneGame game = new TwentyOneGame();
            // game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            // game.ListPlayers();
            // Console.ReadLine();
            //Game game = new TwentyOneGame();
            // game.Players =  new List<Player>();
            // Player player = new Player();
            // player.Name = "Jesse";
            // game = game + player;
            // game = game - player;

            Card card = new Card();
            card.Suit = Suit.Clubs;
            ConsoleColor color = ConsoleColor.Blue;
            Deck deck = new Deck();
            deck.Shuffle(3);

          //  foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
    }
}







//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;





