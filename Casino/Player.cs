using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100) //this automatically assigns 100 to beginning balance if they do not provide said balance
        { //do not need any implimentation, this resuses code from constructor below inside this constructor
        }
        public Player(string name, int beginningBalance) //the code within this constructor gets reused above
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bett that size.");
                return false;

            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
