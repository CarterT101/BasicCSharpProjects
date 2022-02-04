using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //overloading operator+, taking two operands:
                                                                //game, and player and returning a game.
                                                                //takes the game and adds a player to it and returns game
                                                                
        {
            game.Players.Add(player); //players is a list which have built in methods
            return game;
        }
        public static Game operator- (Game game, Player player) //both of these operators use some polymorphism 
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
