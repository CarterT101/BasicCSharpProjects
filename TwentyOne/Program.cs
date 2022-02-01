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

            Deck deck = new Deck(); //deck object that has property cards should have 52 cards
            deck = Shuffle(deck);

            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            Console.Read();
        }

        public static Deck Shuffle(Deck deck) //public (accessible anywhere), static (dont want to create object program before calling), deck (type of data returning),
                                              //shuffle (name of function), parameter of type 'Deck' and variable name 'deck' when you want to refer to it inside method
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random(); //object 'random' has some methods associated with it

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex); 
            }
            deck.Cards = TempList;
            return deck;

        }

    }
}
