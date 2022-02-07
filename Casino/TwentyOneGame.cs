using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway //multiple INHERITANCE 
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {

                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //this says to end this method and continue with foreach loop, makes player put new bet in that is correct
                }
                Bets[player] = bet; //added to dictionary, this entry with player name and bet
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //writes to console not on new line
                    Dealer.Deal(player.Hand);
                    if (i == 1) //second turn
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //static method so preface with class name
                        if (blackJack)
                        {
                            Console.WriteLine("Backjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //you win your bet times 1.5 plus original bet 
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses.");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //if any of these are true the while loop breaks
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //lambda expression, where produces a list
                    //looping through each key value pair and finding the player in playerlist that matches key value pair where name = person we dealing with
                    //take that player and take the balance and add what they bet * 2 to their balance
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //this turns bool into nullable boolean, can have the value null which is not normal
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins!");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} playerWon {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player]; //bets[player] evaluates to int, it is a key value pair
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;
                    return;
                }
            }
        }
        public override void ListPlayers() //virtual method testing
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
