using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasinoGame-TwentyOne;


namespace CasinoGame-TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public Suit Suit { get; set; }
        //the card class has a prop of data type string called suit. Ca get or set prop }
        public Face Face { get; set; }
    }
    //defin enum/class--one file one class--define enum right beliow card
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
}
