using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //File IO TESTING

            //string text = "Here is some text."; //text variable
            //File.WriteAllText(@"C:\Users\hoove\Documents\logs.txt", text); //creating file, or adding to file there and adding the text from variable
            //string text = File.ReadAllText(@"C:\Users\hoove\Documents\logs.txt"); //reads created text

            //DATETIME TESTING

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // timespan gives time in days

            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame(); //polymorphism
                game += player; //adding player to the game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now");
            Console.Read();









            











            //EXAMPLES, TESTING, PRACTICE, ETC 



            //Deck deck = new Deck(); //deck object that has property cards should have 52 cards

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);



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

            //Card card1 = new Card();
            //Card card2 = card1; //sets card2 equal to card1 //we basically just gave card2 the address to card1 for memory
            ////before Card was class, but now that card class is struct, card1 is its on instance not relating to card2. 
            //card1.Face = Face.Eight; //sets card1 to eight
            //card2.Face = Face.King;  //overwrites card1 with card2 face king

            //Console.WriteLine(card1.Face);


            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //} //this can be translated into lambda function below



            //int count = deck.Cards.Count(x => x.Face == Face.Ace); //Cards is a list, Count() is a lambda function
            ////this is counting how many Ace in it and assigning it to variable int count
            ////x represents each element in list
            //// '=>' basically means evaluate this on each item
            //Console.WriteLine(count);



            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //where the face = king and map it to new list
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}



            //List<int> numberList = new List<int>() { 1, 2, 3, 5, 6, 8, 123, 7 };
            //int sum = numberList.Sum();
            //Console.WriteLine(sum);


            //Console.Read();

        }

    }
}
