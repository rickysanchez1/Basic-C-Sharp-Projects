using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        // What properties does a player have?
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
