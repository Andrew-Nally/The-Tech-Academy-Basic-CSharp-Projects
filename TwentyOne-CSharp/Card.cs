using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyOne_CSharp;


namespace TwentyOne_CSharp
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        //the card class has a prop of data type string called suit. Ca get or set prop }
        public string Face { get; set; }
    }
}