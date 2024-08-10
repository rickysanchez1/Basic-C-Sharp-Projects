using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    public abstract class Game
    {
        // Using Player instead of string since we have a player class
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        // any class inheriting this class must implement this method
        public abstract void Play();
        // Virtual method have implementation but can be overriden
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
