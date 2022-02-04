using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Carter", "Evan", "Kenn" };
            //game.ListPlayers(); //calling the superclass method 'game'
            //                    //superclass meaning 'a method that has been inherited from another class'

            //List<Game> games = new List<Game>();
            ////Game game = new TwentyOneGame(); //polymorphism
            //TwentyOneGame game = new TwentyOneGame(); 
            //games.Add(game);


            //TwentyOneGame game = new TwentyOneGame(); //testing virtual method
            //game.Players = new List<string>() { "Jesse", "Bill", "Evan" };
            //game.ListPlayers();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Carter"; //setting variable Name = Carter
            //game = game + player; //in a way, this is our method
            //game -= player; //same way as writing the operator above just shorter



            Deck deck = new Deck(); //deck object that has property cards should have 52 cards
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.Read();

        }

    }
}
