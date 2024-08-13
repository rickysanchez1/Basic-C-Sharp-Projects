using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        // private lists
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        // Using Player instead of string since we have a player class
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
