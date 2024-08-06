using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    public class Player
    {
        // What properties does a player have?
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        // Overloading with operator +. Takes 2 operands, Game and player and returns a game
        public static Game operator+ (Game game, Player player)
        {
            // takes game add players to it and returns game
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
