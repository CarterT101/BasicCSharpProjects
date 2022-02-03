using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //Hand is a list (built in method 'Add()'), 'Deck' is composed of cards,
                                          //First() is a method, available to a list that takes first item from that list
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); //RemoveAt() built in list method that removes at the index 
            
        }
    }
}
