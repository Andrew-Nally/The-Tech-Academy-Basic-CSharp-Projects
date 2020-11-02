using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame-TwentyOne
    //base class--will neber be an instance of a Game-- will always be a certain game( solitaire, poker, go fish etc.. so Game.cs is an abstract class-- will only ever be inherited from.
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //inheriting class--no implementation--basically a contract that says that any class inheriting this class must implement this method---inheriting class will definte this method and will implment it exactly as it inherits---void /override will satisfiy contract-- 
        public abstract void Play();

        public virtual void ListPlayers()
        //virtual method exists inside an absract class--get inherited by an inheriting class but has the ability to override it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
